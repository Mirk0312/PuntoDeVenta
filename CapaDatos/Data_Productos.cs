using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Data_Productos
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();

        public int renglonesAfectados = 0;

        public Boolean Insertar(string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            try
            {
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarProducto";
                //TIPO DE CONEXION
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
                comandoSQL.Parameters.AddWithValue("@codigo", codigo);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                comandoSQL.Parameters.AddWithValue("@costo", costo);
              
                // Ejecutar la consulta y obtener el número de filas afectadas
                renglonesAfectados = comandoSQL.ExecuteNonQuery();

                // Limpiar los parámetros del comando
                comandoSQL.Parameters.Clear();

                // Cerrar la conexión
                connSQL.CerrarConexion();

                // Devolver true si la inserción fue exitosa
                return true;
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine(ex.ToString());
                // Devolver false si ocurrió un error durante la inserción
                return false;
            }
        }

        public Boolean Actualizar(String id, string codigo, string nombre, string descripcion, string ubicacion, string costo)
        {
            try
            {
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_ActualizarProducto";
                //TIPO DE CONEXION
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
                comandoSQL.Parameters.AddWithValue("@id", id);
                comandoSQL.Parameters.AddWithValue("@codigo", codigo);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                comandoSQL.Parameters.AddWithValue("@costo", costo);
              
                // Ejecutar la consulta y obtener el número de filas afectadas
                renglonesAfectados = comandoSQL.ExecuteNonQuery();

                // Limpiar los parámetros del comando
                comandoSQL.Parameters.Clear();

                // Cerrar la conexión
                connSQL.CerrarConexion();

                // Devolver true si la actualización fue exitosa
                return true;
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine(ex.ToString());
                // Devolver false si ocurrió un error durante la actualización
                return false;
            }
        }
    }
}