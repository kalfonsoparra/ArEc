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
    public class ArchivoUsuario
    {
        protected string filename = "Usuario ArEc.txt";
        public ArchivoUsuario(string filename)
        {
            this.filename = filename;
        }
        public String GuardarUsuario(string guarda)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine(guarda);
            sw.Close();
            return "Usuario guardado";
        }
    }
}
