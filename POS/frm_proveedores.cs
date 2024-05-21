using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
namespace POS
{
    public partial class frm_proveedores : Form
    {
        public frm_proveedores()
        {
            InitializeComponent();
        }

        private void frm_proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nuevo()
        {
            try
            {
                txt_IDP.Enabled = false;
                txt_IDP.Text = "NUEVO";

                txt_EncargadoP.Clear();
                txt_EmpresaP.Clear();
                txt_ProductoP.Clear();
                txt_CostoP.Clear();
                txt_VentaP.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en NUEVO" + ex.Message);

            }
        }
        private void btn_GuardarP_Click_1(object sender, EventArgs e)
        {
            {
                // Validar datos
                if (string.IsNullOrWhiteSpace(txt_EmpresaP.Text))
                {
                    MessageBox.Show("Obligatorio poner empresa");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_EncargadoP.Text))
                {
                    MessageBox.Show("Obligatorio poner nombre de encargado");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_ProductoP.Text))
                {
                    MessageBox.Show("Obligatorio poner producto");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_CostoP.Text))
                {
                    MessageBox.Show("Obligatorio poner costo");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_VentaP.Text))
                {
                    MessageBox.Show("Obligatorio poner venta");
                    return;
                }


                // Recolectar campos
                string id = "", empresa, encargado, producto, costo, venta;
                empresa = txt_EmpresaP.Text;
                encargado = txt_EncargadoP.Text;
                producto = txt_ProductoP.Text;
                costo = txt_CostoP.Text;
                venta = txt_VentaP.Text;

                Proveedores pv = new Proveedores(empresa, encargado, producto, costo, venta);

                // Determinar si es un nuevo registro o una actualización
                if (txt_IDP.Text.Equals("NUEVO", StringComparison.OrdinalIgnoreCase))
                {
                    // Estructura para un "INSERT"
                    try
                    {
                        if (pv.fnInsertar())
                        {
                            MessageBox.Show("Guardado correctamente");
                            nuevo(); // Limpiar campos después de guardar
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
                    }
                }
                else
                {
                    // Estructura para un "UPDATE"
                    id = txt_IDP.Text;
                    pv.setId(id);
                    try
                    {
                        if (pv.fnActualizar())
                        {
                            MessageBox.Show("Actualizado correctamente");
                            nuevo(); // Limpiar campos después de actualizar
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
                    }
                }
            }


        }

        private void btn_NuevoP_Click_1(object sender, EventArgs e)
        {
            nuevo();
        }
    }

}

