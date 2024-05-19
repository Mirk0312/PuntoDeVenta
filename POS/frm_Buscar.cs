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
using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace POS
{
    public partial class frm_Buscar : Form
    {
        private string query = "";
        private string consulta = "";
        private string campo = "";
        public string ID_BUSQUEDA = "";

        public frm_Buscar()
        {
            InitializeComponent();
        }

        public void setQuery(string valor)
        {
            query = valor.Trim();
        }

        public void setCampo(string valor)
        {
            campo = valor.Trim();
        }

        private string getCampo()
        {
            if (campo.Length == 0)
                campo = "id";
            return campo;
        }

        private string getConsulta()
        {
            if (query.Length == 0)
                consulta = "SELECT 'SIN DATOS A BUSCAR O BUSQUEDA INCOMPLETA DESCRIPCION";
            else if (txt_BuscarB.Text.Length == 0)
            {
                consulta = query + " ORDER BY " + getCampo() + " ASC";
            }
            else
            {
                consulta = query + " WHERE " + getCampo() + " LIKE '%" + txt_BuscarB.Text + "%'";
            }
            return consulta;
        }

        private void frm_Buscar_Load(object sender, EventArgs e)
        {
            mostrarResultados();
        }

        private void mostrarResultados()
        {
            try
            {
                string consultaBuscar = getConsulta();
                Data_buscar datos = new Data_buscar();
                DataTable dt = datos.consultaDataGridView(consultaBuscar);
                dgV_datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[frmBuscar] " + ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mostrarResultados();
        }

        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgV_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgV_datos.Rows[e.RowIndex];
                ID_BUSQUEDA = row.Cells["id"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
