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
    public class ArchivoProducto
    {
        protected string filename="Productos ArEc.txt";

        public ArchivoProducto(string filename)
        {
            this.filename = filename;
        }
        public string GuardarProducto(string productos)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine(productos);
            sw.Close();
            return "Producto guardado";
        }

    }
}
