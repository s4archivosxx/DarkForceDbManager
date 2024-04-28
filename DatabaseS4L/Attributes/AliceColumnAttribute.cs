using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseS4L.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AliceColumnAttribute : Attribute
    {
        public string Name { get; }

        /// <summary>
        /// Especifica que esta propiedad es una columna de base de datos
        /// </summary>
        public AliceColumnAttribute()
        {
            Name = this.TypeId.GetType().Name;
        }

        /// <summary>
        /// Especifica que esta propiedad es una columna de base de datos
        /// </summary>
        /// <param name="name">Nombre de la columna</param>
        public AliceColumnAttribute(string name)
        {
            Name = name;
        }
    }
}
