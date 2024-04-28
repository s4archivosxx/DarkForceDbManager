using DatabaseS4L.Attributes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseS4L.Serialization
{
    public class DatabaseDeserialize
    {
        public DatabaseDeserialize()
        {
        }

        object DeserializeValue(Type propertyType, AliceColumnAttribute attribute, MySqlDataReader r)
        {
            switch (propertyType.GetTypeCode())
            {
                case TypeCode.Boolean:
                    return r.GetBoolean(attribute.Name);

                case TypeCode.Byte:
                    return r.GetByte(attribute.Name);

                case TypeCode.Decimal:
                    return r.GetDecimal(attribute.Name);

                case TypeCode.Double:
                    return r.GetDouble(attribute.Name);

                case TypeCode.Int16:
                    return r.GetInt16(attribute.Name);

                case TypeCode.Int32:
                    return r.GetInt32(attribute.Name);

                case TypeCode.Int64:
                    return r.GetInt64(attribute.Name);

                case TypeCode.Single:
                    return r.GetFloat(attribute.Name);

                case TypeCode.String:
                    return r.GetString(attribute.Name);

                case TypeCode.UInt16:
                    return r.GetUInt16(attribute.Name);

                case TypeCode.UInt32:
                    return r.GetUInt32(attribute.Name);

                case TypeCode.UInt64:
                    return r.GetUInt64(attribute.Name);

                case TypeCode.SByte:
                    return r.GetSByte(attribute.Name);

                default:
                    throw new ArgumentException("No se reconoce el tipo de dato");
            }
        }

        public object Deserialize(Type typeEntity, MySqlDataReader r)
        {
            var instance = Activator.CreateInstance(typeEntity);
            var typeInfo = typeEntity.GetTypeInfo();
            var properties = typeInfo.GetProperties(BindingFlags.Public);

            var aliceTable = typeInfo.GetCustomAttribute<AliceTableAttribute>();
            if (aliceTable == null)
                throw new ArgumentException("No se puede deserializar un objeto sin el atributo AliceTable");

            foreach (var property in properties)
            {
                var aliceColumn = property.GetCustomAttribute<AliceColumnAttribute>();
                if (aliceColumn == null)
                    continue;

                property.SetValue(instance, DeserializeValue(property.PropertyType, aliceColumn, r));
            }
            return instance;
        }

        public object[] DeserializeArray(Type typeEntity, MySqlDataReader r)
        {
            throw new NotImplementedException();
        }
    }
}
