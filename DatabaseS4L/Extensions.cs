using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DatabaseS4L
{
    public static class ObjectExtensions
    {
        public static object Extract(this object o, out Type type, out TypeInfo typeInfo, out List<PropertyInfo> properties)
        {
            type = o.GetType();
            typeInfo = type.GetTypeInfo();
            properties = typeInfo.GetProperties().ToList();
            return o;
        }
    }

    public static class TypeExtensions
    {
        public static TypeCode GetTypeCode(this Type type)
        {
            return Type.GetTypeCode(type);
        }

        public static string GetTypeArrayObjectName(this Type type)
        {
            if (!type.IsClass && !type.IsArray)
                throw new ArgumentException(type.Name + " debe ser una matríz.");
            return type.Name.Replace("[]", "");
        }

        public static TypeCode GetTypeCodeByName(this Type type)
        {
            if (!Enum.TryParse<TypeCode>(GetTypeArrayObjectName(type), out var result))
                result = TypeCode.Object;
            return result;
        }
    }
}
