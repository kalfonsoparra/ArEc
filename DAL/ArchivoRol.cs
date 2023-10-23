using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Entity;

namespace DAL
{
    public class ArchivoRol
    {
        protected string filename = "rol.txt";

        public ArchivoRol(string filename)
        {
            this.filename = filename;
        }
        public string GuardarVentas(string rol)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine(rol);
            sw.Close();
            return " ";
        }
    }
}
