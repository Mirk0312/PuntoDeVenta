using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Data_Proveedores
    {
        private ConexionSQL connSQL = new ConexionSQL();
        public int renglonesAfectados = 0;

        // Método para insertar un proveedor en la base de datos
        public bool Insertar(string empresa, string encargado, string producto, string costo, string venta)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_InsertarProveedores", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@empresa", empresa);
                    comandoSQL.Parameters.AddWithValue("@encargado", encargado);
                    comandoSQL.Parameters.AddWithValue("@producto", producto);
                    comandoSQL.Parameters.AddWithValue("@costo", costo);
                    comandoSQL.Parameters.AddWithValue("@venta", venta);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la inserción fue exitosa
                    return renglonesAfectados > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al insertar el proveedor: " + ex.Message);
                // Devolver false si ocurrió un error durante la inserción
                return false;
            }
        }

        // Método para actualizar un proveedor en la base de datos
        public bool Actualizar(string id, string empresa, string encargado, string producto, string costo, string venta)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_ActualizarProveedor", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@id", id);
                    comandoSQL.Parameters.AddWithValue("@empresa", empresa);
                    comandoSQL.Parameters.AddWithValue("@encargado", encargado);
                    comandoSQL.Parameters.AddWithValue("@producto", producto);
                    comandoSQL.Parameters.AddWithValue("@costo", costo);
                    comandoSQL.Parameters.AddWithValue("@venta", venta);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la actualización fue exitosa
                    return renglonesAfectados > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al actualizar el proveedor: " + ex.Message);
                // Devolver false si ocurrió un error durante la actualización
                return false;
            }
        }

        // Método para eliminar un proveedor en la base de datos
        public bool Eliminar(string id)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("DELETE FROM Proveedores WHERE Id = @id", connection))
                {
                    // Agregar parámetro
                    comandoSQL.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si el cliente fue eliminado exitosamente
                    return renglonesAfectados > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al eliminar el proveedor: " + ex.Message);
                // Devolver false si ocurrió un error durante la eliminación
                return false;
            }
        }

        // Método para obtener un proveedor por ID en la base de datos
        public DataTable ObtenerProveedorPorID(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("SELECT * FROM Proveedores WHERE Id = @id", connection))
                {
                    comandoSQL.Parameters.AddWithValue("@id", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comandoSQL))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el proveedor: " + ex.Message);
            }
            return dt;
        }
    }
}
