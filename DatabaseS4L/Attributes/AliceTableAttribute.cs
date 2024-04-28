using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseS4L.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AliceTableAttribute : Attribute
    {
        public string Name { get; }

        /// <summary>
        /// Especifica que esta clase es una tabla de base de datos
        /// </summary>
        /// <param name="name">Nombre de la tabla</param>
        public AliceTableAttribute(string name)
        {
            Name = name;
        }
    }
}
