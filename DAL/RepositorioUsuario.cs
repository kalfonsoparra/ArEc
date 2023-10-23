using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class RepositorioUsuario : ArchivoUsuario
    {
        public RepositorioUsuario(string filename) : base(filename)
        {
        }
        public List<Usuario> Consulta()
        {
            try
            {
                List<Usuario> list = new List<Usuario>();
                StreamReader streamReader = new StreamReader(filename);
                while (!streamReader.EndOfStream)
                {
                    list.Add(mapeo(streamReader.ReadLine()));
                }
                streamReader.Close();
                return list;
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }
        public Usuario mapeo(String dato)
        {
            if (dato == "" || dato == null) { return null; }
            var linea = dato.Split(';');
            Usuario usuario = new Usuario()
            {
                Cedula = int.Parse(linea[0]),
                Nombre = linea[1],
                Apellido = linea[2],
                Nombre_Usuario = linea[3],
                Contraseña_Usuario = linea[4],
                rol = new repositorioRol("rol.txt").Buscar(linea[5]),
                Dirreccion = linea[6],
                Fecha_Nacimiento = linea[7],
                Telefono = linea[8],
                Correo = linea[9]
            };
            return usuario;
        }

    }
}
    

