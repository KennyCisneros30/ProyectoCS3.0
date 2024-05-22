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
        public readonly Propietario _propietario;

        public NPropietario(Propietario propietarioRepositorio)
        {
            _propietario = propietarioRepositorio;
        }

        public void GuardarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                throw new ArgumentException("Todos los campos deben ser completados.");
            }

            _propietario.InsertarPropietario(dni, nombres, apellidos, correo, telefono, direccion);
        }
        public void ModificarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                throw new ArgumentException("Todos los campos deben ser completados.");
            }

            _propietario.ModificarPropietario(dni, nombres, apellidos, correo, telefono, direccion);
        }

        public void EliminarPropietario(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException("El DNI debe ser proporcionado.");
            }

            _propietario.EliminarPropietario(dni);
        }

        public DataTable BuscarPropietarioPorDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException("El DNI debe ser proporcionado.");
            }

            return _propietario.BuscarPropietarioPorDNI(dni);
        }
    }
}
