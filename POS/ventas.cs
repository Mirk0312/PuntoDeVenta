using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
namespace POS
{
    public partial class ventas : Form
    {
        private Data_Ventas Data_Ventas;
        private DataTable carrito;
        public ventas()
        {

            InitializeComponent();
            InicializarCarrito();
        }
        private void InicializarCarrito()
        {
            carrito = new DataTable();
            carrito.Columns.Add("ProductoID", typeof(int));
            carrito.Columns.Add("Codigo", typeof(string));
            carrito.Columns.Add("Nombre", typeof(string));
            carrito.Columns.Add("Precio", typeof(decimal));
            carrito.Columns.Add("Cantidad", typeof(int));
            data.DataSource = carrito;
        }
        private void btn_buscarV_Click(object sender, EventArgs e)
        {
            string codigo = txt_codigoV.Text;
            Data_Ventas venta = new Data_Ventas();
            DataTable producto = venta.GetProductoPorCodigo(codigo);

            if (producto.Rows.Count > 0)
            {
                DataRow row = producto.Rows[0];
                DataRow newRow = carrito.NewRow();
                newRow["ProductoID"] = row["ProductoID"];
                newRow["Codigo"] = row["Codigo"];
                newRow["Nombre"] = row["Nombre"];
                newRow["Precio"] = row["Precio"];
                newRow["Cantidad"] = 1;
                carrito.Rows.Add(newRow);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btn_agregarV_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data.SelectedRows)
                {
                    row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                }

            }
        }

        private void btn_eliminarVenta_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data.SelectedRows)
                {
                    if (Convert.ToInt32(row.Cells["Cantidad"].Value) > 1)
                    {
                        row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) - 1;
                    }
                    else
                    {
                        data.Rows.Remove(row);
                    }
                }
            }
        }

        private void Vender_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalVenta = 0;
                foreach (DataRow row in carrito.Rows)
                {
                    totalVenta += Convert.ToDecimal(row["Precio"]) * Convert.ToInt32(row["Cantidad"]);
                }
                Data_Ventas venta = new Data_Ventas();  

                venta.RealizarVenta(carrito, totalVenta);
                MessageBox.Show("Venta realizada con éxito.");
                carrito.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
