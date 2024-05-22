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
        public readonly Vehiculo _vehiculo;

        public NVehiculo(Vehiculo vehiculoRepositorio)
        {
            _vehiculo = vehiculoRepositorio;
        }

        public void GuardarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            if (string.IsNullOrWhiteSpace(placa) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException("Todos los campos obligatorios deben ser completados.");
            }

            _vehiculo.InsertarVehiculo(placa, valor, año, cilindraje, modelo, color, idPropietario);
        }

        public void ModificarVehiculo(string placa, decimal valor, int año, int cilindraje, string modelo, string color, int idPropietario)
        {
            if (string.IsNullOrWhiteSpace(placa) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException("Todos los campos obligatorios deben ser completados.");
            }

            _vehiculo.ModificarVehiculo(placa, valor, año, cilindraje, modelo, color, idPropietario);
        }

        public void EliminarVehiculo(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                throw new ArgumentException("La placa debe ser proporcionada.");
            }

            _vehiculo.EliminarVehiculo(placa);
        }

        public DataTable BuscarVehiculoPorPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                throw new ArgumentException("La placa debe ser proporcionada.");
            }

            return _vehiculo.BuscarVehiculoPorPlaca(placa);
        }

    }
}
