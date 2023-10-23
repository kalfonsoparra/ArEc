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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private void botonHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show(this);
            this.Hide();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show(this);
            this.Hide();
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {
            Facturar facturar = new Facturar();
            facturar.Show(this);
            this.Hide();
        }

        private void botonCotizar_Click(object sender, EventArgs e)
        {
            Cotizar cotizar = new Cotizar();
            cotizar.Show(this);
            this.Hide();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show(this);
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal menu_Principal = new Menu_Principal();
            menu_Principal.Show(this);
            this.Hide();
        }
    }
}
