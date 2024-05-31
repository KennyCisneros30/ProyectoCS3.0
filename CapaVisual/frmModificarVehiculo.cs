using CapaDatos.Interface;
using CapaNegocio;
using ProyectoCS.Controlador;
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
    public partial class frmModificarVehiculo : Form
    {
        public frmModificarVehiculo()
        {
            InitializeComponent();
            // Inicialización de la conexión SQL y del negocio de vehículos
            ConeccionSQL conexionSQL = new ConeccionSQL();
            Vehiculo vehiculoRepositorio = new Vehiculo(conexionSQL);
            NVehiculo vehiculoNegocio = new NVehiculo(vehiculoRepositorio);

            // Suscribir el evento TextChanged de los TextBox
            MVPlacaTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVValorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVAñoTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVCilindrajeTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVModeloTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVColorTextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            MVDNITextBox.TextChanged += new EventHandler(TextBox_TextChanged);

            // Inicialmente deshabilitar el botón
            GuardarV.Enabled = false;
            EliminarVehiculo.Enabled = false;
        }
        // Método que se ejecuta cuando cambia el texto en alguno de los TextBox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Habilitar los botones de guardar y eliminar si todos los TextBox tienen texto
            GuardarV.Enabled = !string.IsNullOrWhiteSpace(MVPlacaTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVValorTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVAñoTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVCilindrajeTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVModeloTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVColorTextBox.Text) &&
                             !string.IsNullOrWhiteSpace(MVDNITextBox.Text);
            // Habilitar el botón de eliminar si el TextBox de la placa tiene texto
            EliminarVehiculo.Enabled = !string.IsNullOrWhiteSpace(MVPlacaTextBox.Text);
        }

        // Método para buscar un vehículo por placa
        private void BuscarPlaca_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConeccionSQL conexionSQL = new ConeccionSQL())
                {
                    Vehiculo vehiculoRepositorio = new Vehiculo(conexionSQL);
                    NVehiculo vehiculoNegocio = new NVehiculo(vehiculoRepositorio);

                    // Buscar un vehículo por placa y cargar sus datos en los TextBox correspondientes
                    DataTable vehiculo = vehiculoNegocio.BuscarVehiculoPorPlaca(MVPlacaBuscarTextBox.Text);

                    if (vehiculo.Rows.Count > 0)
                    {
                        DataRow row = vehiculo.Rows[0];
                        MVPlacaTextBox.Text = row["PLACA"].ToString();
                        MVValorTextBox.Text = row["VALOR"].ToString();
                        MVAñoTextBox.Text = row["AÑO"].ToString();
                        MVCilindrajeTextBox.Text = row["CILINDRAJE"].ToString();
                        MVModeloTextBox.Text = row["MODELO"].ToString();
                        MVColorTextBox.Text = row["COLOR"].ToString();
                        MVDNITextBox.Text = row["DNI"].ToString(); // Cambiar a "DNI" en lugar de "ID_PROPIETARIO"
                    }
                    else
                    {
                        MessageBox.Show("Vehículo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para guardar la modificación de un vehículo
        private void GuardarV_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConeccionSQL conexionSQL = new ConeccionSQL())
                {
                    Vehiculo vehiculoRepositorio = new Vehiculo(conexionSQL);
                    NVehiculo vehiculoNegocio = new NVehiculo(vehiculoRepositorio);

                    // Modificar un vehículo con los datos ingresados en los TextBox
                    vehiculoNegocio.ModificarVehiculo(
                        MVPlacaTextBox.Text,
                        Convert.ToDecimal(MVValorTextBox.Text),
                        Convert.ToInt32(MVAñoTextBox.Text),
                        Convert.ToInt32(MVCilindrajeTextBox.Text),
                        MVModeloTextBox.Text,
                        MVColorTextBox.Text,
                        Convert.ToInt32(MVDNITextBox.Text)
                    );

                    MessageBox.Show("Modificación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los TextBox después de modificar exitosamente
                    LimpiarTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para eliminar un vehículo
        private void EliminarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConeccionSQL conexionSQL = new ConeccionSQL())
                {
                    Vehiculo vehiculoRepositorio = new Vehiculo(conexionSQL);
                    NVehiculo vehiculoNegocio = new NVehiculo(vehiculoRepositorio);

                    // Eliminar un vehículo con la placa ingresada en el TextBox
                    vehiculoNegocio.EliminarVehiculo(MVPlacaTextBox.Text);

                    MessageBox.Show("Vehículo eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los TextBox después de eliminar exitosamente
                    LimpiarTextBoxes();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Método para limpiar los TextBox
        private void LimpiarTextBoxes()
        {
            MVPlacaBuscarTextBox.Clear();
            MVPlacaTextBox.Clear();
            MVValorTextBox.Clear();
            MVAñoTextBox.Clear();
            MVCilindrajeTextBox.Clear();
            MVModeloTextBox.Clear();
            MVColorTextBox.Clear();
            MVDNITextBox.Clear();
        }

        // Método para cerrar el formulario actual y abrir el formulario de vehículos
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmVehiculos formuVehiculos = new frmVehiculos();
            formuVehiculos.Show();
            this.Close();
        }
    }
}
