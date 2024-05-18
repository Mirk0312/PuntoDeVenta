using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DataUsuarios
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int RenglonesAfectados = 0;
        public string NombreUsuario = "";
        public string UserName = "";

        public DataUsuarios()
        {

        }

        public Boolean Insertar(string nombre, string apellidoP, string apellidoM, string correo, string direccion, string telefono)
        {
            //INSERTAR PERFILES
            try
            {
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //enviar nombre del recurso sql
                comandoSQL.CommandText = "proc_InsertarUsuario";
                //Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@apellidoP", apellidoP);
                comandoSQL.Parameters.AddWithValue("@apellidoM", apellidoM);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@direccion", direccion);
                comandoSQL.Parameters.AddWithValue("@telefono", telefono);
                //ejecutar query
                RenglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                //cerrar sesion
                connSQL.CerrarConexion();

                return true; // Indica que la inserción fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuarios:Insertar " + ex.Message);
                return false; // Indica que hubo un error durante la inserción
            }
        }

        public Boolean Autenticar(string usuario, string pass)
        {
            try
            {
                // Abrir conexión
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Enviar nombre del recurso sql
                comandoSQL.CommandText = "proc_ValidaUsuario";
                // Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@password", pass);
                // Ejecutar consulta y leer resultados
                SqlDataReader reader = comandoSQL.ExecuteReader();

                // Verificar si se encontró una fila que coincide con las credenciales
                if (reader.HasRows)
                {
                    // Credenciales válidas, cerrar conexión y devolver true
                    reader.Close();
                    connSQL.CerrarConexion();
                    return true;
                }
                else
                {
                    // No se encontraron coincidencias, cerrar conexión y devolver false
                    reader.Close();
                    connSQL.CerrarConexion();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuarios:Autenticar " + ex.Message);
                RenglonesAfectados = 0;
                return false;
            }
        }



    }
}