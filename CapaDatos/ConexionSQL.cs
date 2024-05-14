using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionSQL
    {
      private SqlConnection conn;
        string conexionString;
        String nombreServidor = "";
        string nombreBD = "POS";
        string usuarioBD = "";
        string passwordBD = "";
        public ConexionSQL()
        {
            try
            {
                conexionString = $"Server={nombreServidor};Database={nombreBD};User ID{usuarioBD},Password{passwordBD}";
                conn = new SqlConnection(); //ConectionString

            }
            catch (Exception ex)
            {
                Console.WriteLine("ConexionSQL: " + ex.Message);
            }
        }

        public SqlConnection AbrirConexion()
            {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        
         public SqlConnection CerrarConexion()
            {
            try
            {
               if (conn.State == ConnectionState.Open)
                   conn.Close();
              return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               return null;
    }

}
        }
    }

              
    


