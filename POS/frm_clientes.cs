﻿using CapaNegocio;
using System;
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
            // Inicializar cualquier elemento necesario en el formulario
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
            string id = "", nombre, RFC, clave, correo, telefono;
            nombre = txt_nombre.Text;
            RFC = txt_rfc.Text;
            clave = txt_clave.Text;
            correo = txt_correo.Text;
            telefono = txt_telefono.Text;

            // Crear un nuevo cliente
            Clientes cr = new Clientes(nombre, RFC, clave, correo, telefono);

            // Determinar si es un nuevo cliente o una actualización
            if (txt_idCliente.Text.Equals("NUEVO", StringComparison.OrdinalIgnoreCase))
            {
                // Insertar un nuevo cliente
                if (cr.Insertar())
                {
                    MessageBox.Show("Cliente guardado correctamente.");
                    nuevo();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente.");
                }
            }
            else
            {
                // Actualizar un cliente existente
                id = txt_idCliente.Text;
                cr.setId(id); // Asignar el ID del cliente
                if (cr.Actualizar())
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    nuevo();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idCliente.Text) || txt_idCliente.Text.Equals("NUEVO", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                return;
            }

            // Confirmar si el usuario desea eliminar el cliente
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Clientes cr = new Clientes(txt_idCliente.Text, txt_nombre.Text, txt_rfc.Text, txt_clave.Text, txt_correo.Text, txt_telefono.Text);
                if (cr.Eliminar())
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    nuevo();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.");
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Implementa la lógica para actualizar la lista de clientes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
