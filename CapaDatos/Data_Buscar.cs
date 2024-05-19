using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq.Expressions;

namespace CapaDatos
{
    public class Data_buscar
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();

        public int renglonesAfectados = 0;

        public DataTable consultaDataGridView(string laConsulta)
        {
            DataTable consultaData = new DataTable();
            try
            {
                // Abre la conexión SQL
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Asigna la consulta SQL al objeto SqlCommand
                comandoSQL.CommandText = laConsulta;
                // Crea un SqlDataAdapter y asigna el SqlCommand a él
                SqlDataAdapter consultaDataAdapter = new SqlDataAdapter(comandoSQL);
                // Llena el DataTable con los resultados de la consulta
                consultaDataAdapter.Fill(consultaData);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción y registra el error
                Console.WriteLine("[consultaDataGridView] ---> " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar la conexión después de usarla
                connSQL.CerrarConexion();
            }

            return consultaData;
        }
    }
}