using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto:Calculos
    {
        public int Codido_Producto { get; set; }
        public string Name_Producto { get; set; }
        public bool Estado { get; set; }
        public int Cantidad { get; set; }
        public float Precio_producto { get;set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }

        public Producto()
        {
        }

        public Producto(int codido_Producto, string name_Producto, bool estado, int cantidad, float precio_producto, DateTime fecha_Entrada, DateTime fecha_Salida)
        {
            Codido_Producto = codido_Producto;
            Name_Producto = name_Producto;
            Estado = estado;
            Cantidad = cantidad;
            Precio_producto = precio_producto;
            Fecha_Entrada = fecha_Entrada;
            Fecha_Salida = fecha_Salida;
        }
    }
}
