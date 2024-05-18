using System.Data.SqlClient;
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
        SqlConnection conn;

        string nombreServidor = "LPKM\\SQLEXPRESS";
        string nombreBD = "POS";
        string usuarioBD = "Admin";
        string passwordBD = "admin123";
        private string conexionString;

        public ConexionSQL()
        {
            try
            {
                conexionString = $"Server={nombreServidor};Database={nombreBD};User ID={usuarioBD};Password={passwordBD}";
                conn = new SqlConnection(conexionString); // ConnectionString
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


        public void CerrarConexion()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
