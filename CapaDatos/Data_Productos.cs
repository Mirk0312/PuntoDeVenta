using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Data_Productos
    {
        private ConexionSQL connSQL = new ConexionSQL();

        public int renglonesAfectados = 0;

        public Boolean Insertar(string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_InsertarProducto", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@codigo", codigo);
                    comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                    comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                    comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                    comandoSQL.Parameters.AddWithValue("@costo", costo);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la inserción fue exitosa
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al insertar el producto: " + ex.Message);
                // Devolver false si ocurrió un error durante la inserción
                return false;
            }
        }

        public Boolean Actualizar(string id, string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_ActualizarProducto", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@id", id);
                    comandoSQL.Parameters.AddWithValue("@codigo", codigo);
                    comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                    comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                    comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                    comandoSQL.Parameters.AddWithValue("@costo", costo);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la actualización fue exitosa
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al actualizar el producto: " + ex.Message);
                // Devolver false si ocurrió un error durante la actualización
                return false;
            }
        }
        public DataTable ObtenerProductoPorID(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("SELECT * FROM Productos WHERE Id = @id", connection))
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
                Console.WriteLine("Error al obtener el producto: " + ex.Message);
            }
            return dt;
        }
    }
}
  
