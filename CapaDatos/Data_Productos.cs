using Microsoft.Data.SqlClient;
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

        public Boolean Insertar(string codigo, string nombre, string descripcion, string ubicacion, string costo, string venta)
        {
            try
            {

                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarUsuario";
                //TIPO DE CONEXION
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //Agregar parametros
              
                comandoSQL.Parameters.AddWithValue("@codigo", codigo);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@descripcion", descripcion);
                comandoSQL.Parameters.AddWithValue("@ubicacion", ubicacion);
                comandoSQL.Parameters.AddWithValue("@costo", costo);
                comandoSQL.Parameters.AddWithValue("@venta", venta);



                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion
                return true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());   
            }
        }

        

    }
    
}
