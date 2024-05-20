using CapaNegocio.CapaNegocio;
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
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {

        }
        private void nuevo()
        {
            try
            {
                txt_idCliente.Enabled = false;
                txt_idCliente.Text = "NUEVO";

                txt_nombre.Clear();
                txt_rfc.Clear();
                txt_clave.Clear();
                txt_correo.Clear();
                txt_telefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en NUEVO: " + ex.Message);
            }
        }
    }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            {
                // Validar datos
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    MessageBox.Show("El nombre del cliente es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_rfc.Text))
                {
                    MessageBox.Show("El RFC del cliente es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_clave.Text))
                {
                    MessageBox.Show("La clave del cliente es obligatoria.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_correo.Text))
                {
                    MessageBox.Show("El correo electrónico del cliente es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_telefono.Text))
                {
                    MessageBox.Show("El teléfono del cliente es obligatorio.");
                    return;
                }

                // Recolectar datos del formulario
                string nombre = txt_nombre.Text;
                string RFC = txt_rfc.Text;
                string clave = txt_clave.Text;
                string correo = txt_correo.Text;
                string telefono = txt_telefono.Text;

                // Crear un nuevo cliente
                Clientes  cr = new Clientes(nombre, RFC, clave, correo, telefono);

                // Determinar si es un nuevo cliente o una actualización
                if (txt_idCliente.Text.Equals("NUEVO", StringComparison.OrdinalIgnoreCase))
                {
                    // Insertar un nuevo cliente
                    if (cr.Insertar())
                    {
                        MessageBox.Show("Cliente guardado correctamente.");
                        nuevo()
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el cliente.");
                    }
                }
                else
                {
                    // Actualizar un cliente existente
                    cliente.Id = txt_idCliente.Text; // Asignar el ID del cliente
                    if (cliente.Actualizar())
                    {
                        MessageBox.Show("Cliente actualizado correctamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente.");
                    }
                }
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
