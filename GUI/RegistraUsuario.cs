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
    public partial class RegistraUsuario : Form
    {
        public RegistraUsuario()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }
    }
}
