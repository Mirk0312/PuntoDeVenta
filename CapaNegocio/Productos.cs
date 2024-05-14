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
        string id, codigo, nombre, descripcion, ubicacion, costo, venta;

        public void setId(string valor)
        {
            id = valor;
        }
        

        public Productos(string codigo, string nombre, string descripcion, string ubicacion, string costo, string venta)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.costo = costo;
            this.venta = venta;
        }

        public Boolean fnInsertar() 
        {
           Boolean resultado = false;
            Data_Productos prod = new Data_Productos();
            resultado=prod.Insertar(codigo,nombre, descripcion,ubicacion, costo, venta);
            return resultado;
            
        }
        public Boolean fnActualizar() 
        {
            Boolean resultado = false;
            Data_Productos prod = new Data_Productos();
            resultado = prod.Insertar(codigo, nombre, descripcion, ubicacion, costo, venta);
            return resultado;


        }

    }
}
