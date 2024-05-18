using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_Buscar : Form
    {
        private String query = "";
        private String consulta = "";
        private String campo = "";
        public String ID_BUSQUEDA = "";
        public void setQuery(String valor)
        {
            query = valor.Trim();
        }
        public void setCampo(String valor)
        {
            campo = valor.Trim();
        }
        private String getCampo()
        {
            if (campo.Length == 0)
                campo = "id";
            return campo;
        }
        private String getConsulta()
        {
            if (query.Length == 0)
                consulta = "SELECT 'SIN DATOS A BUSCAR O BUSQUEDA INCOMPLETA DESCRIPCION";
            else if (txt_BuscarBuscar.Text.Length == 0)
            {
                consulta = query + " order by " + campo + "nombre asc";
            }
            else
            {
                consulta = query + "where " + campo + " like % " + txt_BuscarBuscar.Text + "%";
            }
            return consulta;
        }

        public frm_Buscar()
        {
            InitializeComponent();
        }

        private void frm_Buscar_Load(object sender, EventArgs e)
        {
            //Obtener query de la tabla
            //query "select id, nombre, precio, from productos order by nombre asc"
            mostrarResultados();
            //Mostrar resultado dV_datos

        }
        private void mostrarResultados()
        {
            try
            {
                //levantar conexion a BD con resultado del query

                //ENVIAR CONSULTA
                String consultaBuscar = getConsulta();
                //LLENAR DATAGRIDVIEW
                //crear un metodo en capaDatos que reciba parametros SQLCommand, retorne un DataSet
                CapaDatos.Data_buscar datos = new CapaDatos.Data_buscar();
                DataTable dt = datos.consultaDataGridView(consultaBuscar);
                dgV_datos.DataSource = dt;



            }
            catch (Exception ex)
            {
                Console.WriteLine("[frmBuscar]" + ex.Message);
                //escribir a un archivo de LOG
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String cadena = txt_BuscarBuscar.Text;
            if (cadena.Length == 0)
                cadena = query;
            else
                cadena = "";
            query = "";
            mostrarResultados();
        }

        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgV_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
