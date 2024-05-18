using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Productos
    {
       private string id, codigo, nombre, descripcion, ubicacion, costo;

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




        public Productos(string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.costo = costo;
        }

        public Boolean fnInsertar() 
        {
           Boolean resultado = false;
            Data_Productos prod = new Data_Productos();
            resultado=prod.Insertar(codigo,nombre, descripcion,ubicacion, costo);
            return resultado;
            
           
            return false;    
        }
        public Boolean fnActualizar()
        {
            try
            {
                // Crear una instancia de la clase Data_Productos para manejar las operaciones de base de datos
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

