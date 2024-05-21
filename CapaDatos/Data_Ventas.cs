using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using CapaDatos;
namespace CapaDatos
{
    public class Data_Ventas
    {

        private string connectionString;

        public DataTable GetProductoPorCodigo(string codigo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductoID, Codigo, Nombre, Precio FROM Productos WHERE Codigo = @Codigo";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);

                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public void RealizarVenta(DataTable productos, decimal totalVenta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insertar la venta
                    string insertVentaQuery = "INSERT INTO Ventas (TotalVenta) VALUES (@TotalVenta); SELECT SCOPE_IDENTITY();";
                    SqlCommand insertVentaCmd = new SqlCommand(insertVentaQuery, conn, transaction);
                    insertVentaCmd.Parameters.AddWithValue("@TotalVenta", totalVenta);
                    int ventaID = Convert.ToInt32(insertVentaCmd.ExecuteScalar());

                    // Insertar los detalles de la venta
                    foreach (DataRow row in productos.Rows)
                    {
                        string insertDetalleQuery = "INSERT INTO DetallesVenta (VentaID, ProductoID, Cantidad, Precio) VALUES (@VentaID, @ProductoID, @Cantidad, @Precio)";
                        SqlCommand insertDetalleCmd = new SqlCommand(insertDetalleQuery, conn, transaction);
                        insertDetalleCmd.Parameters.AddWithValue("@VentaID", ventaID);
                        insertDetalleCmd.Parameters.AddWithValue("@ProductoID", row["ProductoID"]);
                        insertDetalleCmd.Parameters.AddWithValue("@Cantidad", row["Cantidad"]);
                        insertDetalleCmd.Parameters.AddWithValue("@Precio", row["Precio"]);
                        insertDetalleCmd.ExecuteNonQuery();
                    }

                    // Actualizar el stock de los productos
                    foreach (DataRow row in productos.Rows)
                    {
                        string updateStockQuery = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE ProductoID = @ProductoID";
                        SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                        updateStockCmd.Parameters.AddWithValue("@Cantidad", row["Cantidad"]);
                        updateStockCmd.Parameters.AddWithValue("@ProductoID", row["ProductoID"]);
                        updateStockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
