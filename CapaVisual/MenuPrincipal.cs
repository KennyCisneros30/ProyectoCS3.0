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
            // Constructor de la clase MenuPrincipal
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Método que se ejecuta al hacer clic en el botón button1
            frmPropietario formuPropietario = new frmPropietario();
            formuPropietario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Método que se ejecuta al hacer clic en el botón button3
            frmVehiculos formuVehiculos = new frmVehiculos();
            formuVehiculos.Show();
            this.Hide();
        }
    }

}
