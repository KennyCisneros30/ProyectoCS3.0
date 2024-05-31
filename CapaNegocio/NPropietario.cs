using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos.Interface;
using System.Data;


namespace CapaNegocio
{
    public class NPropietario
    {
        // Campo readonly para la instancia de Propietario
        public readonly Propietario _propietario;

        // Constructor que inicializa el campo _propietario
        public NPropietario(Propietario propietarioRepositorio)
        {
            _propietario = propietarioRepositorio;
        }

        // Método para guardar un nuevo propietario, validando los campos obligatorios
        public void GuardarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                // Lanza una excepción si algún campo obligatorio está vacío
                throw new ArgumentException("Todos los campos deben ser completados.");
            }
            // Llama al método de Propietario para insertar un nuevo propietario
            _propietario.InsertarPropietario(dni, nombres, apellidos, correo, telefono, direccion);
        }
        // Método para modificar un propietario existente, validando los campos obligatorios
        public void ModificarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                // Lanza una excepción si algún campo obligatorio está vacío
                throw new ArgumentException("Todos los campos deben ser completados.");
            }

            // Llama al método de Propietario para modificar un propietario existente
            _propietario.ModificarPropietario(dni, nombres, apellidos, correo, telefono, direccion);
        }
        // Método para eliminar un propietario, validando el campo DNI
        public void EliminarPropietario(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                // Lanza una excepción si el campo DNI está vacío
                throw new ArgumentException("El DNI debe ser proporcionado.");
            }

            // Llama al método de Propietario para eliminar un propietario
            _propietario.EliminarPropietario(dni);
        }

        // Método para buscar un propietario por DNI, validando el campo DNI
        public DataTable BuscarPropietarioPorDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                // Lanza una excepción si el campo DNI está vacío
                throw new ArgumentException("El DNI debe ser proporcionado.");
            }

            // Llama al método de Propietario para buscar un propietario por DNI
            return _propietario.BuscarPropietarioPorDNI(dni);
        }
    }
}
