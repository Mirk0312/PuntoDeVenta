using CapaNegocio;
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
            try
            {
                txt_IDProduc.Enabled = false;
                txt_IDProduc.Text = "NUEVO";

                txt_CodigoProduc.Text = "";
                txt_NombreProduc.Text = "";
                txt_DescripcionProduc.Text = "";
                txt_VentaProduc.Text = "";
                txt_CostoProduc.Text = "";
                cbx_UnidadProduc.SelectedIndex = 0;
                cbx_UbicacionProduc.SelectedIndex = 0;

            }
            catch (Exception ex)
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
            //Validar datos 
            if (txt_CodigoProduc.Text.Length == 0) {
                MessageBox.Show("Obligatorio codigo del producto");
            } else if (txt_NombreProduc.Text.Length == 0) 
            {
                MessageBox.Show("Obligatorio NOMBRE del producto"); //LLenar campos
            }

            //Recolectar campos
            String codigo, nombre, descripcion, ubicacion, costo, venta;
            codigo = txt_CodigoProduc.Text;
            nombre = txt_NombreProduc.Text;
            descripcion = txt_DescripcionProduc.Text;
            ubicacion = cbx_UbicacionProduc.SelectedValue.ToString();
            costo = txt_CostoProduc.Text;
            venta = txt_VentaProduc.Text;

            Productos pr = new Productos(codigo,nombre,descripcion,ubicacion,costo, venta);


            //Instanciar clase productos de capa negocio

            if (txt_IDProduc.Text == "nuevo".ToUpper())
            {
                //estrucutura para un "INSERT"
                if (pr.fnInsertar()) 
                {
                    MessageBox.Show("Guardado correctamente");
                }
            }
            else 
            {
                //estructura para un "UPDATE"
                pr.fnActualizar();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Llamar a un formulario hijo que se llamara FrmBuscar pasar query
            frm_Buscar frmhijo = new frm_Buscar();
            frmhijo.setQuery("SELECT * FROM PRODUCTOS");
            frmhijo.setCampo("nombre");
            DialogResult resultado = frmhijo.ShowDialog();
            txt_IDProduc.Text = frmhijo.ID_BUSQUEDA;
            //Mostrar frmBuscar, despues del cierre

            //obtener ID de la busqueda
            //Consultar BD
            //Mostrar o llenar los campos en pantalla
        }

        private void frm_productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
