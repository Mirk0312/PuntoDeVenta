using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DataUsuarios
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int RenglonesAfectados = 0;

        public DataUsuarios()
        { 
           
        }
        

        public Boolean Insertar(string nombre, string apellidoP, string apellidoM, string correo, string direccion, string telefono) 
        {
            try {
                //Abrir conexion 
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos sql
                comandoSQL.CommandText = "proc_InsertarUsuario";
                //Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("apellidoP", apellidoP);
                comandoSQL.Parameters.AddWithValue("apellidoM", apellidoM);
                comandoSQL.Parameters.AddWithValue("correo", correo);
                comandoSQL.Parameters.AddWithValue("direccion", direccion);
                comandoSQL.Parameters.AddWithValue("telefono",telefono);
                //Ejecutar query
                RenglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //cerrar conexion

            }
            catch (Exception ex)             
            { 
            Console.WriteLine(ex.ToString);
            }
        
        } //Fin insertar



        public Boolean Autenticar(string usuario, string pass)
        {
            try 
            {

            //Abrir conexion 
            comandoSQL.Connection = connSQL.AbrirConexion();
            //Enviar nombre de recursos sql
            comandoSQL.CommandText = "proc_ValidaUsuario";
            //Tipo de comando
            comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("password", pass);
                //Ejecutar query
                RenglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //cerrar conexion
                return true;

            } 
            catch (Exception ex)
            { 
            Console.WriteLine("DataUsuario:Autenticar " + ex.Message);
                RenglonesAfectados = 0;
                  }
        } //Fin autenticar



    }
}
