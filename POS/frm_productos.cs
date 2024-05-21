using CapaDatos;
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

        private void frm_productos_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con ubicaciones
            cbx_UbicacionProduc.Items.Add("Hermosillo");
            cbx_UbicacionProduc.Items.Add("Guadalajara");
            cbx_UbicacionProduc.Items.Add("Ciudad de México");

            // Seleccionar un valor por defecto si es necesario
            if (cbx_UbicacionProduc.Items.Count > 0)
            {
                cbx_UbicacionProduc.SelectedIndex = 0;
            }

            // También asegúrate de llenar cualquier otro ComboBox u otros elementos que necesiten ser inicializados.
        }

        private void nuevo()
        {
            try
            {
                txt_IDProduc.Enabled = false;
                txt_IDProduc.Text = "NUEVO";

                txt_CodigoProduc.Clear();
                txt_NombreProduc.Clear();
                txt_DescripcionProduc.Clear();
                txt_VentaProduc.Clear();
                txt_CostoProduc.Clear();
                cbx_UnidadProduc.SelectedIndex = 0;
                cbx_UbicacionProduc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en NUEVO: " + ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Validar datos
            if (string.IsNullOrWhiteSpace(txt_CodigoProduc.Text))
            {
                MessageBox.Show("Obligatorio código del producto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_NombreProduc.Text))
            {
                MessageBox.Show("Obligatorio NOMBRE del producto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_DescripcionProduc.Text))
            {
                MessageBox.Show("Obligatorio DESCRIPCIÓN del producto");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_CostoProduc.Text))
            {
                MessageBox.Show("Obligatorio COSTO del producto");
                return;
            }
            if (cbx_UbicacionProduc.SelectedItem == null)
            {
                MessageBox.Show("Obligatorio UBICACIÓN del producto");
                return;
            }

            // Recolectar campos
            string id = "", codigo, nombre, descripcion, ubicacion, costo;
            codigo = txt_CodigoProduc.Text;
            nombre = txt_NombreProduc.Text;
            descripcion = txt_DescripcionProduc.Text;
            ubicacion = cbx_UbicacionProduc.SelectedItem.ToString();
            costo = txt_CostoProduc.Text;

            Productos pr = new Productos(codigo, nombre, descripcion, ubicacion, costo);

            // Determinar si es un nuevo registro o una actualización
            if (txt_IDProduc.Text.Equals("NUEVO", StringComparison.OrdinalIgnoreCase))
            {
                // Estructura para un "INSERT"
                try
                {
                    if (pr.fnInsertar())
                    {
                        MessageBox.Show("Guardado correctamente");
                        nuevo(); // Limpiar campos después de guardar
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
            }
            else
            {
                // Estructura para un "UPDATE"
                id = txt_IDProduc.Text;
                pr.setID(id);
                try
                {
                    if (pr.fnActualizar())
                    {
                        MessageBox.Show("Actualizado correctamente");
                        nuevo(); // Limpiar campos después de actualizar
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                }
            }
        }



        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Llamar a un formulario hijo que se llamará FrmBuscar y pasar query
            frm_Buscar frmhijo = new frm_Buscar();
            frmhijo.setQuery("SELECT id, Codigo, Nombre, Descripcion, Ubicacion, Costo FROM Productos");
            frmhijo.setCampo("Nombre");  // Puedes ajustar el campo según sea necesario
            DialogResult resultado = frmhijo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txt_IDProduc.Text = frmhijo.ID_BUSQUEDA;

                // Cargar los datos del producto seleccionado
                Data_Productos dataProd = new Data_Productos();
                DataTable dt = dataProd.ObtenerProductoPorID(frmhijo.ID_BUSQUEDA);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txt_CodigoProduc.Text = row["Codigo"].ToString();
                    txt_NombreProduc.Text = row["Nombre"].ToString();
                    txt_DescripcionProduc.Text = row["Descripcion"].ToString();
                    cbx_UbicacionProduc.SelectedItem = row["Ubicacion"].ToString();
                    txt_CostoProduc.Text = row["Costo"].ToString();
                    // Cargar otros campos necesarios...
                }
            }


        }
    }
}

