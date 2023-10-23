using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña_Usuario {  get; set; }
        public Rol rol{ get; set; }
        public string Dirreccion {  get; set; }

        public string Fecha_Nacimiento {  get; set; }
        public string Telefono {  get; set; }
        public string Correo { get; set; }

        public Usuario() 
        {

        }

        public Usuario(int cedula, string nombre, string apellido, string nombre_Usuario, string contraseña_Usuario, Rol rol,
            string dirreccion, string fecha_Nacimiento, string telefono, string correo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Nombre_Usuario = nombre_Usuario;
            Contraseña_Usuario = contraseña_Usuario;
            this.rol = rol;
            Dirreccion = dirreccion;
            Fecha_Nacimiento = fecha_Nacimiento;
            Telefono = telefono;
            Correo = correo;
        }
       public override string ToString()
        {
            return $"{Cedula};{Nombre};{Apellido};{Nombre_Usuario};{Contraseña_Usuario};{rol.id_rol};{Dirreccion};{Fecha_Nacimiento};{Telefono};{Correo}";
        }
    }
}
