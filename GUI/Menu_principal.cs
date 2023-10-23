using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Inicio_Sesion inicio = new Inicio_Sesion();
            inicio.Show();
            this.Hide();
        }

        private void botonHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }

        private void botonCotizar_Click(object sender, EventArgs e)
        {
            Cotizar cotizar = new Cotizar();
            cotizar.Show();
            this.Hide();
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {
            Facturar facturar = new Facturar();
            facturar.Show();
            this.Hide();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void botonInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
