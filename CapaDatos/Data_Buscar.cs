using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaDatos
{
    public class Data_buscar
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();

        public int renglonesAfectados = 0;

        public DataTable consultaDataGridView(String laconsulta)
        {
            DataTable consultaData = new DataTable();

            comandoSQL.Connection = connSQL.AbrirConexion();

            comandoSQL.CommandText = "proc_InsertarProducto";

            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.CommandType = CommandType.Text;


            return consultaData;
        }
    }
  
}
