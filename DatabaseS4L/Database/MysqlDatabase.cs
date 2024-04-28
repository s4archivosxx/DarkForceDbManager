using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DatabaseS4L
{
    public abstract class MysqlDatabase
    {
        protected string s_connection = string.Empty;

        protected MySqlConnection _mysqlConnection;
        protected MySqlCommand _mysqlCommand;

        protected bool _mysqlOpen = false;
        protected bool _needDataReader = false;

        protected string _mysqlQuery = string.Empty;
        protected string _operator = "=";
        protected string _validator = "AND";

        protected object _instance;
        protected Type _instanceType;
        protected TypeInfo _instaceTypeInfo;
        protected List<PropertyInfo> _instancePropertyInfos;

        protected string MysqlConnection
        {
            get => s_connection;
            set
            {
                if (value == string.Empty)
                    return;
                s_connection = value;
            }
        }

        protected MySqlConnection Open()
        {
            _mysqlConnection = new MySqlConnection(MysqlConnection);
            _mysqlConnection.Open();
            return _mysqlConnection;
        }

        public bool IsValidConnection()
        {
            return Open() != null && _mysqlConnection.State == ConnectionState.Open;
        }

        internal virtual void CloseMysqlConnection()
        {
            _mysqlConnection.Close();
            _mysqlConnection.Dispose();
        }

        public void Close()
        {
            if (_mysqlOpen)
            {
                _mysqlConnection.Close();
                _mysqlOpen = false;
                _mysqlConnection = null;
                _needDataReader = false;
                _mysqlCommand?.Cancel();
                _mysqlCommand = null;
                _instance = null;
            }
        }

        public void Dipose()
        {
            _mysqlConnection.Dispose();
            _mysqlCommand?.Dispose();
        }

        [Obsolete]
        internal virtual MySqlConnection GetConnection()
        {
            var con = new MySqlConnection(s_connection);
            if (_mysqlConnection == null)
                _mysqlConnection = con;
            else
                return _mysqlConnection;
            return con;
        }

        internal virtual MysqlDatabase CreateCommand(MySqlConnection mysql)
        {
            _mysqlCommand = mysql.CreateCommand();
            return this;
        }

        internal virtual MysqlDatabase CreateCommand(MySqlConnection mysql, object instance)
        {
            _mysqlCommand = mysql.CreateCommand();
            _instance = instance.Extract(out _instanceType, out _instaceTypeInfo, out _instancePropertyInfos);
            return this;
        }

        internal virtual MysqlDatabase Select(string table)
        {
            _mysqlQuery = "SELECT * FROM " + table;
            _needDataReader = true;
            return this;
        }

        internal virtual MysqlDatabase Insert(string table)
        {
            _mysqlQuery = "INSERT INTO " + table;
            _needDataReader = false;
            return this;
        }

        internal virtual MysqlDatabase Update(string table)
        {
            _mysqlQuery = "UPDATE " + table;
            _needDataReader = false;
            return this;
        }

        internal virtual MysqlDatabase OrderBy(string column)
        {
            if (_mysqlQuery.Contains("ORDER BY"))
                return this;
            _mysqlQuery += " ORDER BY " + column;
            return this;
        }

        internal virtual MysqlDatabase Limit(int start, int limit)
        {
            if (_mysqlQuery.Contains("LIMIT"))
                return this;
            _mysqlQuery += " LIMIT " + start + ", " + limit;
            return this;
        }

        internal virtual MysqlDatabase Into()
        {
            _mysqlQuery += "(";
            _instancePropertyInfos
                .ForEach(x => _mysqlQuery += string.Format("{0},", x.Name));
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
            _mysqlQuery += ")";
            return this;
        }

        internal virtual MysqlDatabase Values()
        {
            _mysqlQuery += " VALUES (";
            _instancePropertyInfos
                .ForEach(x => _mysqlQuery += string.Format("@{0},", x.Name));
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
            _mysqlQuery += ")";

            _mysqlCommand.CommandText = _mysqlQuery;
            _instancePropertyInfos
                .ForEach(x => _mysqlCommand.Parameters.AddWithValue("@" + x.Name, x?.GetValue(_instance) ?? "\"\""));
            return this;
        }

        internal virtual MysqlDatabase Set(int skip = 1)
        {
            _mysqlQuery += " SET ";
            _instancePropertyInfos.Skip(skip).ToList()
                .ForEach(x => _mysqlQuery += string.Format("{0}=@{0},", x.Name));
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
            _instancePropertyInfos.ForEach(x => _mysqlCommand.Parameters.AddWithValue("@" + x.Name, x?.GetValue(_instance) ?? ""));
            return this;
        }

        internal virtual MysqlDatabase Set(int skip, int limit, bool blocked)
        {
            _mysqlQuery += " SET ";
            for (var index = 0; index < _instancePropertyInfos.Count; index++)
            {
                if (index >= limit && blocked)
                    break;

                if (index == skip)
                    continue;

                var property = _instancePropertyInfos[index];
                _mysqlQuery += string.Format("{0}=@{0},", property.Name);
                _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property.GetValue(_instance));
            }
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
            return this;
        }

        internal virtual MysqlDatabase Set(params string[] columns)
        {
            _mysqlQuery += " SET ";
            for (var index = 0; index < columns.Length; index++)
            {
                var column = columns[index];
                var property = _instancePropertyInfos.Find(x => x.Name == column);
                _mysqlQuery += string.Format("{0}=@{0},", property.Name);
               _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property.GetValue(_instance));
            }
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
            return this;
        }

        internal virtual MysqlDatabase Set(string column)
        {
            _mysqlQuery += " SET ";
            var property = _instancePropertyInfos.Find(x => x.Name == column);
            _mysqlQuery += string.Format("{0}=@{0}", property.Name);
            _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property?.GetValue(_instance) ?? "");
            return this;
        }

        internal virtual MysqlDatabase Set(string column, long value)
        {
            _mysqlQuery += " SET ";
            var property = _instancePropertyInfos.Find(x => x.Name == column);
            _mysqlQuery += string.Format("{0}=@_{0}", property.Name);
            _mysqlCommand.Parameters.AddWithValue("@_" + property.Name, value);
            return this;
        }

        internal virtual MysqlDatabase IntoValues()
        {
            Into();
            Values();
            Finish();

            void Into()
            {
                _mysqlQuery += "(";
                _instancePropertyInfos.ForEach(x => _mysqlQuery += string.Format("{0},", x.Name));
                _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
                _mysqlQuery += ")";
            }

            void Values()
            {
                _mysqlQuery += " VALUES (";
                _instancePropertyInfos.ForEach(x => _mysqlQuery += string.Format("@{0},", x.Name));
                _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 1);
                _mysqlQuery += ")";
            }

            void Finish()
            {
                _mysqlCommand.CommandText = _mysqlQuery;
                _instancePropertyInfos.ForEach(x => _mysqlCommand.Parameters.AddWithValue("@" + x.Name, x?.GetValue(_instance) ?? "\"\""));
            }

            return this;
        }

        internal virtual MysqlDatabase And()
        {
            _validator = "AND";
            return this;
        }

        internal virtual MysqlDatabase Or()
        {
            _validator = "OR";
            return this;
        }

        internal virtual MysqlDatabase WithOperator(string @operator)
        {
            _operator = @operator;
            return this;
        }

        /// <summary>
        /// Añade un where a la consulta con la primera propiedad del objeto.
        /// </summary>
        /// <returns></returns>
        internal virtual MysqlDatabase Where()
        {
            if (_instance == null)
            {
                _mysqlCommand.CommandText = _mysqlQuery;
                return this;
            }

            var property = _instancePropertyInfos.First();

            _mysqlQuery += " WHERE ";
            _mysqlQuery += string.Format("{0}{1}@{0}", property.Name, _operator);

            _mysqlCommand.CommandText = _mysqlQuery;
            if (!_mysqlCommand.Parameters.Contains("@" + property.Name))
                _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property.GetValue(_instance));

            return this;
        }

        internal virtual MysqlDatabase Where(string column)
        {
            if (_instance == null)
            {
                _mysqlCommand.CommandText = _mysqlQuery;
                return this;
            }

            var property = _instancePropertyInfos
                .FirstOrDefault(x => x.Name == column);

            _mysqlQuery += " WHERE ";
            _mysqlQuery += string.Format("{0}{1}@{0}", property.Name, _operator);

            _mysqlCommand.CommandText = _mysqlQuery;
            if (!_mysqlCommand.Parameters.Contains("@" + property.Name))
                _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property.GetValue(_instance));

            return this;
        }

        internal virtual MysqlDatabase Where(params string[] columns)
        {
            if (_instance == null)
            {
                _mysqlCommand.CommandText = _mysqlQuery;
                return this;
            }

            _mysqlQuery += " WHERE ";
            for (var index = 0; index < columns.Length; index++)
            {
                var name = columns[index];
                var property = _instancePropertyInfos.FirstOrDefault(x => x.Name == name);
                _mysqlQuery += string.Format("{0}{1}@{0} {2} ", name, _operator, _validator);

                if (!_mysqlCommand.Parameters.Contains("@" + property.Name))
                    _mysqlCommand.Parameters.AddWithValue("@" + property.Name, property.GetValue(_instance));
            }
            _mysqlQuery = _mysqlQuery.Remove(_mysqlQuery.Length - 4);
            _mysqlCommand.CommandText = _mysqlQuery;

            return this;
        }

        internal virtual object Execute<TResult>()
        {
            if (string.IsNullOrEmpty(_mysqlCommand.CommandText))
                _mysqlCommand.CommandText = _mysqlQuery;

            if (_needDataReader)
                return _mysqlCommand.ExecuteReader();
            else
                return _mysqlCommand.ExecuteNonQuery();
        }

        internal virtual MySqlDataReader ExecuteReader()
        {
            if (string.IsNullOrEmpty(_mysqlCommand.CommandText))
                _mysqlCommand.CommandText = _mysqlQuery;

            if (!_needDataReader)
                return default;

            return _mysqlCommand.ExecuteReader();
        }

        internal virtual int ExecuteNonQuery()
        {
            if (string.IsNullOrEmpty(_mysqlCommand.CommandText))
                _mysqlCommand.CommandText = _mysqlQuery;

            return _mysqlCommand.ExecuteNonQuery();
        }

        internal virtual long ExecuteGetId()
        {
            if (string.IsNullOrEmpty(_mysqlCommand.CommandText))
                _mysqlCommand.CommandText = _mysqlQuery;
            _mysqlCommand.ExecuteNonQuery();

            return _mysqlCommand.LastInsertedId;
        }

        [Obsolete]
        internal virtual MySqlCommand BuildQuery(MySqlConnection con, string query, params object[] values)
        {
            var cmd = con.CreateCommand();
            cmd.CommandText = query;
            for (int i = 0; i < values.Length; i += 2)
                cmd.Parameters.AddWithValue(values[i].ToString(), values[i + 1]);
            return cmd;
        }
    }
}
