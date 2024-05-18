using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                txt_IDProducto.Enabled = false;
                txt_IDProducto.Text = "NUEVO";

                txt_CodigoProducto.Text = "";
                txt_NombreProducto.Text = "";
                txt_DescripcionProducto.Text = "";
                txt_VentaProducto.Text = "";
                txt_CostoProducto.Text = "";
                cbx_UnidadProducto.SelectedIndex = 0;
                cbx_UbicacionProducto.SelectedIndex = 0;

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
            if (txt_CodigoProducto.Text.Length == 0)
            {

                MessageBox.Show("Obligatorio codigo del producto");

            }
            else if (txt_NombreProducto.Text.Length == 0)
            {
                MessageBox.Show("Obligatorio NOMBRE del producto");
            }
            else if (txt_DescripcionProducto.Text.Length == 0)
            {
                MessageBox.Show("Obligatorio DESCRIPCION del producto");

            }
            else if (txt_CostoProducto.Text.Length == 0)
            {
                MessageBox.Show("Obligatorio COSTO del producto");

            }
            else if (cbx_UbicacionProducto.SelectedIndex == 0) { 
                MessageBox.Show("Obligatorio UBICACION del producto");
             }

                //Recolectar campos
                String id ="", codigo= "", nombre = "", descripcion = "", ubicacion = "", costo;
                codigo = txt_CodigoProducto.Text;
                nombre = txt_NombreProducto.Text;
                descripcion = txt_DescripcionProducto.Text;
                ubicacion = cbx_UbicacionProducto.SelectedValue.ToString();
                costo = txt_CostoProducto.Text;


                Productos pr = new Productos(codigo, nombre, descripcion, ubicacion, costo);

                //Instanciar clase productos de capa negocio

                // Determinar si es un nuevo registro o una actualización
                if (txt_IDProducto.Text == "nuevo".ToUpper())
                {
                    // Estructura para un "INSERT"
                    if (pr.fnInsertar())
                    {
                        MessageBox.Show("Guardado correctamente");
                        nuevo(); // Limpiar campos después de guardar
                    }
                }
                else
                {

                    // Estructura para un "UPDATE"
                    id = txt_IDProducto.Text;
                    pr.setID(id);
                    if (pr.fnActualizar())
                        MessageBox.Show("Actualizado correctamente");
                }
            }
        
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Llamar a un formulario hijo que se llamara FrmBuscar pasar query
            frm_Buscar frmhijo = new frm_Buscar();
            frmhijo.setQuery("SELECT * FROM PRODUCTOS");
            frmhijo.setCampo("nombre");
            DialogResult resultado = frmhijo.ShowDialog();
            txt_IDProducto.Text = frmhijo.ID_BUSQUEDA;
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
