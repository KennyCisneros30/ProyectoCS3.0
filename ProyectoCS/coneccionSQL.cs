using System;
using System.Data.SqlClient;

namespace ProyectoCS.Controlador
{
    public class ConeccionSQL : IDisposable
    {
        // Objeto de conexión SQL
        private SqlConnection conexion;
        // Cadena de conexión a la base de datos
        private string connectionString;

        // Constructor de la clase
        public ConeccionSQL()
        {
            // Modifica la cadena de conexión según tu configuración
            connectionString = "Data Source=DESKTOP-9D404SB\\MSSQLSERVER01;Initial Catalog=CS6_3;Integrated Security=True";

            // Inicializa el objeto de conexión con la cadena de conexión
            conexion = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            try
            {
                // Verifica si la conexión es nula y la inicializa si es necesario
                if (conexion == null)
                {
                    conexion = new SqlConnection(connectionString);
                }

                // Abre la conexión si no está abierta
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Retorna la conexión abierta
                return conexion;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                Console.WriteLine("Cadena de conexión: " + connectionString);
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                // Verifica si la conexión está abierta y la cierra
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
            finally
            {
                conexion.Dispose(); // Liberar recursos
            }
        }

        // Implementación de la interfaz IDisposable
        public void Dispose()
        {
            // Llama al método para cerrar la conexión
            CerrarConexion();
            // Suprime la finalización del recolector de basura
            GC.SuppressFinalize(this);
        }
    }
}
