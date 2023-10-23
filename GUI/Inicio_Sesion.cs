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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {

        }

        private void butonSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonIngreso_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
            this.Hide();
        }
    }
}
