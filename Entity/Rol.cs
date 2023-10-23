using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Rol
    {
        public int id_rol {  get; set; }
        public string name_rol { get; set; }

        public Rol()

        {
        }

        public Rol(int id_rol, string name_rol)
        {
            this.id_rol = id_rol;
            this.name_rol = name_rol;
        }
        public override string ToString()
        {
            return $"{id_rol};{name_rol}";
        }
    }
}
