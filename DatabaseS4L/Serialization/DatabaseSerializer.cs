using MySql.Data.MySqlClient;
using System;

namespace DatabaseS4L.Serialization
{
    public class DatabaseSerializer
    {
        private readonly DatabaseDeserialize _deserializer;

        public DatabaseSerializer()
        {
            _deserializer = new DatabaseDeserialize();
        }

        public object Deserialize(Type entity, MySqlDataReader reader)
        {
            return _deserializer.Deserialize(entity, reader);
        }
    }
}
