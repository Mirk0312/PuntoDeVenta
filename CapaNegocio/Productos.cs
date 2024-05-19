using CapaDatos;
using System;

namespace CapaNegocio
{
    public class Productos
    {
        // Campos privados
        private string id, codigo, nombre, descripcion, ubicacion, costo;

        // Métodos de acceso y modificación para cada campo
        public void setID(string valor)
        {
            id = valor;
        }

        public string getID()
        {
            return id;
        }

        public void setCodigo(string valor)
        {
            codigo = valor;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public void setNombre(string valor)
        {
            nombre = valor;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setDescripcion(string valor)
        {
            descripcion = valor;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setUbicacion(string valor)
        {
            ubicacion = valor;
        }

        public string getUbicacion()
        {
            return ubicacion;
        }

        public void setCosto(string valor)
        {
            costo = valor;
        }

        public string getCosto()
        {
            return costo;
        }

        // Constructor con parámetros
        public Productos(string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.costo = costo;
        }

        // Método para insertar un producto
        public Boolean fnInsertar()
        {
            try
            {
                Boolean resultado = false;
                Data_Productos prod = new Data_Productos();
                resultado = prod.Insertar(codigo, nombre, descripcion, ubicacion, costo);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el producto: " + ex.Message);
                return false;
            }
        }

        // Método para actualizar un producto
        public Boolean fnActualizar()
        {
            try
            {
                Data_Productos prod = new Data_Productos();
                bool resultado = prod.Actualizar(id, codigo, nombre, descripcion, ubicacion, costo);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el producto: " + ex.Message);
                return false;
            }
        }
    }
}
