using ProyectoCS.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.Interface
{
    public class Vehiculo
    {
        private readonly ConeccionSQL _conexionSQL;

        public Vehiculo(ConeccionSQL conexionSQL)
        {
            _conexionSQL = conexionSQL;
        }

        public void InsertarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("InsertarVehiculo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@Valor", valor);
                    command.Parameters.AddWithValue("@Año", año);
                    command.Parameters.AddWithValue("@Cilindraje", cilindraje);
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@ID_PROPIETARIO", idPropietario);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ModificarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("ModificarVehiculo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@Valor", valor);
                    command.Parameters.AddWithValue("@Año", año);
                    command.Parameters.AddWithValue("@Cilindraje", cilindraje);
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@ID_PROPIETARIO", idPropietario);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarVehiculo(string placa)
        {
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("EliminarVehiculo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Placa", placa);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarVehiculoPorPlaca(string placa)
        {
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("BuscarVehiculoPorPlaca", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Placa", placa);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
