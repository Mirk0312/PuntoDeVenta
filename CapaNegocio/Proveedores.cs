using System;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Proveedores
    {
        private string id, empresa, encargado, producto, costo, venta;

        public void setId(string valor)
        {
            id = valor;
        }

        public string getId()
        {
            return id;
        }

        public void setEmpresa(string valor)
        {
            empresa = valor;
        }

        public string getEmpresa()
        {
            return empresa;
        }

        public void setEncargado(string valor)
        {
            encargado = valor;
        }

        public string getEncargado()
        {
            return encargado;
        }

        public void setProducto(string valor)
        {
            producto = valor;
        }

        public string getProducto()
        {
            return producto;
        }

        public void setCosto(string valor)
        {
            costo = valor;
        }

        public string getCosto()
        {
            return costo;
        }
        public void setVenta(string valor)
        {
            venta = valor;
        }

        public string getVenta()
        {
            return venta;
        }



        public Proveedores(string id, string empresa, string encargado, string producto, string costo, string venta) { 
        
            this.id = id;
            this.empresa = empresa;
            this.encargado = encargado;
            this.producto = producto;
            this.costo = costo;
            this.venta = venta;
        }
        public Boolean fnInsertar()
        {
            try {
                Boolean resultado = false;
                Data_Proveedores prod = new Data_Proveedores();
                resultado = prod.Insertar(empresa, encargado, producto, costo, venta);
                return resultado;

            }     
            catch (Exception ex) 
            {           
                Console.WriteLine("Error al insertar proveedor:" + ex.Message);
                return false;
            }
        }
        public Boolean fnActualizar()
        {
            try
            {
                Boolean resultado = false;
                Data_Proveedores prod = new Data_Proveedores();
                resultado = prod.Insertar(empresa, encargado, producto, costo, venta);
                return resultado;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar proveedor:" + ex.Message);
                return false;
            }
        }

    }
}