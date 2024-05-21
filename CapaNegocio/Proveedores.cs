using System;
using CapaDatos;

namespace CapaNegocio
{
    public class Proveedores
    {
        public string Id { get; private set; }
        public string Empresa { get; private set; }
        public string Encargado { get; private set; }
        public string Producto { get; private set; }
        public string Costo { get; private set; }
        public string Venta { get; private set; }

        public Proveedores(string empresa, string encargado, string producto, string costo, string venta)
        {
            Empresa = empresa;
            Encargado = encargado;
            Producto = producto;
            Costo = costo;
            Venta = venta;
        }

        public void SetId(string valor) => Id = valor;
        public void SetEmpresa(string valor) => Empresa = valor;
        public void SetEncargado(string valor) => Encargado = valor;
        public void SetProducto(string valor) => Producto = valor;
        public void SetCosto(string valor) => Costo = valor;
        public void SetVenta(string valor) => Venta = valor;

        public bool fnInsertar()
        {
            try
            {
                Data_Proveedores prod = new Data_Proveedores();
                return prod.Insertar(Empresa, Encargado, Producto, Costo, Venta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar proveedor: " + ex.Message);
                return false;
            }
        }

        public bool fnActualizar()
        {
            try
            {
                Data_Proveedores prod = new Data_Proveedores();
                return prod.Actualizar(Id, Empresa, Encargado, Producto, Costo, Venta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar proveedor: " + ex.Message);
                return false;
            }
        }
    }
}
