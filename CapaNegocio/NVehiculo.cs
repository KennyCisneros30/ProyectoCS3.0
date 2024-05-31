using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;

namespace CapaNegocio
{
    public class NVehiculo
    {
        // Campo readonly para la instancia de Vehiculo
        public readonly Vehiculo _vehiculo;

        // Constructor que inicializa el campo _vehiculo
        public NVehiculo(Vehiculo vehiculoRepositorio)
        {
            _vehiculo = vehiculoRepositorio;
        }
        // Método para guardar un nuevo vehículo, validando campos obligatorios
        public void GuardarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            if (string.IsNullOrWhiteSpace(placa) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(color))
            {
                // Lanza una excepción si algún campo obligatorio está vacío
                throw new ArgumentException("Todos los campos obligatorios deben ser completados.");
            }

            // Llama al método de Vehiculo para insertar un nuevo vehículo
            _vehiculo.InsertarVehiculo(placa, valor, año, cilindraje, modelo, color, idPropietario);
        }

        // Método para modificar un vehículo existente, validando campos obligatorios
        public void ModificarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            if (string.IsNullOrWhiteSpace(placa) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(color))
            {
                // Lanza una excepción si algún campo obligatorio está vacío
                throw new ArgumentException("Todos los campos obligatorios deben ser completados.");
            }

            // Llama al método de Vehiculo para modificar un vehículo existente
            _vehiculo.ModificarVehiculo(placa, valor, año, cilindraje, modelo, color, idPropietario);
        }

        // Método para eliminar un vehículo, validando la placa
        public void EliminarVehiculo(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                // Lanza una excepción si la placa está vacía
                throw new ArgumentException("La placa debe ser proporcionada.");
            }

            // Llama al método de Vehiculo para eliminar un vehículo
            _vehiculo.EliminarVehiculo(placa);
        }

        // Método para buscar un vehículo por placa, validando la placa
        public DataTable BuscarVehiculoPorPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                // Lanza una excepción si la placa está vacía
                throw new ArgumentException("La placa debe ser proporcionada.");
            }

            // Llama al método de Vehiculo para buscar un vehículo por placa
            return _vehiculo.BuscarVehiculoPorPlaca(placa);
        }

    }
}
