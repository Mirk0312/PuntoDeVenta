using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Data_Clientes
    {
        private ConexionSQL connSQL = new ConexionSQL();
        public int renglonesAfectados = 0;

        // Método para insertar un cliente en la base de datos
        public bool Insertar(string nombre, string RFC, string clave, string correo, string telefono)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_InsertarCliente", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                    comandoSQL.Parameters.AddWithValue("@RFC", RFC);
                    comandoSQL.Parameters.AddWithValue("@clave", clave);
                    comandoSQL.Parameters.AddWithValue("@correo", correo);
                    comandoSQL.Parameters.AddWithValue("@telefono", telefono);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la inserción fue exitosa
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al insertar el cliente: " + ex.Message);
                // Devolver false si ocurrió un error durante la inserción
                return false;
            }
        }

        // Método para actualizar un cliente en la base de datos
        public bool Actualizar(string id, string nombre, string RFC, string clave, string correo, string telefono)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("proc_ActualizarCliente", connection))
                {
                    // Configurar el comando
                    comandoSQL.CommandType = CommandType.StoredProcedure;
                    // Agregar parámetros
                    comandoSQL.Parameters.AddWithValue("@id", id);
                    comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                    comandoSQL.Parameters.AddWithValue("@RFC", RFC);
                    comandoSQL.Parameters.AddWithValue("@clave", clave);
                    comandoSQL.Parameters.AddWithValue("@correo", correo);
                    comandoSQL.Parameters.AddWithValue("@telefono", telefono);

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    renglonesAfectados = comandoSQL.ExecuteNonQuery();

                    // Devolver true si la actualización fue exitosa
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción e imprimir el mensaje de error
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                // Devolver false si ocurrió un error durante la actualización
                return false;
            }
        }

        // Método para eliminar un cliente de la base de datos
        public bool Eliminar(string id)
        {
            try
            {
                using (SqlConnection connection = connSQL.AbrirConexion())
                using (SqlCommand comandoSQL = new SqlCommand("DELETE FROM Clientes WHERE Id = @id", connection))
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
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                // Devolver false si ocurrió un error durante la eliminación
                return false;
            }
        }
    }
}
