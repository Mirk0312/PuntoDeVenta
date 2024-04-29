using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
        }
        private void nuevo()
        {
            try {
                txt_ID.Enabled = false;
                txt_ID.Text = "NUEVO";

                txt_codigo.Text = "" ;
                txt_nombre.Text = "" ;
                txt_descripcion.Text = "" ;
                txt_venta.Text = "";
                txt_costo.Text = "";
                cbx_unidad.SelectedIndex = 0;
                cbx_ubicacion.SelectedIndex = 0;

                }catch(Exception ex)
            {
                MessageBox.Show("Error en NUEVO", ex.Message);
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "nuevo".ToUpper()) 
            {
                //estrucutura para un "INSERT"
            }
            else
            {
                //estructura para un "UPDATE"
            }
        }
    }
}
