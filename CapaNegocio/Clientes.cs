using System;
using CapaDatos;

namespace CapaNegocio
{
    public class Clientes
    {
        // Campos privados
        private string id, nombre, RFC, clave, correo, telefono;

        // Métodos de acceso y modificación para cada campo
        public void setId(string valor)
        {
            id = valor;
        }

        public string getId()
        {
            return id;
        }

        public void setNombre(string valor)
        {
            nombre = valor;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setRFC(string valor)
        {
            RFC = valor;
        }

        public string getRFC()
        {
            return RFC;
        }

        public void setClave(string valor)
        {
            clave = valor;
        }

        public string getClave()
        {
            return clave;
        }

        public void setCorreo(string valor)
        {
            correo = valor;
        }

        public string getCorreo()
        {
            return correo;
        }

        public void setTelefono(string valor)
        {
            telefono = valor;
        }

        public string getTelefono()
        {
            return telefono;
        }

        // Constructor con parámetros
        public Clientes(string id, string nombre, string RFC, string clave, string correo, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.RFC = RFC;
            this.clave = clave;
            this.correo = correo;
            this.telefono = telefono;
        }

        // Constructor sin ID (para nuevos clientes)
        public Clientes(string nombre, string RFC, string clave, string correo, string telefono)
        {
            this.nombre = nombre;
            this.RFC = RFC;
            this.clave = clave;
            this.correo = correo;
            this.telefono = telefono;
        }

        // Método para insertar un nuevo cliente
        public bool Insertar()
        {
            try
            {
                Data_Clientes dataClientes = new Data_Clientes();
                return dataClientes.Insertar(nombre, RFC, clave, correo, telefono);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el cliente: " + ex.Message);
                return false;
            }
        }

        // Método para actualizar un cliente existente
        public bool Actualizar()
        {
            try
            {
                Data_Clientes dataClientes = new Data_Clientes();
                return dataClientes.Actualizar(id, nombre, RFC, clave, correo, telefono);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un cliente
        public bool Eliminar()
        {
            try
            {
                Data_Clientes dataClientes = new Data_Clientes();
                return dataClientes.Eliminar(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                return false;
            }
        }
    }
}
