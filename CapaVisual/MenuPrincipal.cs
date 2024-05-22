using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPropietario formuPropietario = new frmPropietario();
            formuPropietario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVehiculos formuVehiculos = new frmVehiculos();
            formuVehiculos.Show();
            this.Hide();
        }
    }

}
