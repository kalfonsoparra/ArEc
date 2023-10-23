using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class RepositorioRol : ArchivoRol
    {
        public RepositorioRol(string filename) : base(filename)
        {
        }
        public List<Rol> consulta()
        {
            List<Rol> rol = new List<Rol>();
            StreamReader streamReader = new StreamReader(filename);
            while (streamReader.EndOfStream) 
            {
                rol.Add(mapear(streamReader.ReadLine()));
            }
            return rol;
        }
        public Rol mapear(string dato)
        {
            var line = dato.Split(';');
            Rol rol = new Rol
            {
                id_rol = int.Parse( line[0]),
                name_rol = line[1]
            };
            return rol;
        }

    }
}
