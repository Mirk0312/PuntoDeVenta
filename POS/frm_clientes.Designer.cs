namespace POS
{
    partial class frm_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_CerrarCliente = new Button();
            label2 = new Label();
            picturebox_prueba = new PictureBox();
            label1 = new Label();
            txt_TelefonoCliente = new TextBox();
            txt_CorreoCliente = new TextBox();
            txt_ClaveCliente = new TextBox();
            txt_RFCCliente = new TextBox();
            txt_NombreCliente = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btn_EliminarCliente = new Button();
            btn_NuevoCliente = new Button();
            btn_GuardarCliente = new Button();
            label3 = new Label();
            txt_numeroCliente = new TextBox();
            btn_EditarCliente = new Button();
            btn_ActualizarCliente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_CerrarCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(picturebox_prueba);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 26;
            // 
            // btn_CerrarCliente
            // 
            btn_CerrarCliente.Image = Properties.Resources.CerrarVentana;
            btn_CerrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarCliente.Location = new Point(705, 11);
            btn_CerrarCliente.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarCliente.Name = "btn_CerrarCliente";
            btn_CerrarCliente.Size = new Size(83, 27);
            btn_CerrarCliente.TabIndex = 23;
            btn_CerrarCliente.Text = "        Cerrar";
            btn_CerrarCliente.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(112, 16);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 21;
            label2.Text = "Clientes";
            // 
            // picturebox_prueba
            // 
            picturebox_prueba.BackColor = Color.SlateGray;
            picturebox_prueba.Image = Properties.Resources.icons8_clientes_100;
            picturebox_prueba.Location = new Point(31, 2);
            picturebox_prueba.Margin = new Padding(3, 2, 3, 2);
            picturebox_prueba.Name = "picturebox_prueba";
            picturebox_prueba.Size = new Size(65, 54);
            picturebox_prueba.TabIndex = 1;
            picturebox_prueba.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(31, 317);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 38;
            label1.Text = "Telefono:";
            // 
            // txt_TelefonoCliente
            // 
            txt_TelefonoCliente.Location = new Point(204, 317);
            txt_TelefonoCliente.Margin = new Padding(3, 2, 3, 2);
            txt_TelefonoCliente.Name = "txt_TelefonoCliente";
            txt_TelefonoCliente.Size = new Size(263, 23);
            txt_TelefonoCliente.TabIndex = 36;
            // 
            // txt_CorreoCliente
            // 
            txt_CorreoCliente.Location = new Point(204, 267);
            txt_CorreoCliente.Margin = new Padding(3, 2, 3, 2);
            txt_CorreoCliente.Name = "txt_CorreoCliente";
            txt_CorreoCliente.Size = new Size(263, 23);
            txt_CorreoCliente.TabIndex = 35;
            // 
            // txt_ClaveCliente
            // 
            txt_ClaveCliente.Location = new Point(204, 219);
            txt_ClaveCliente.Margin = new Padding(3, 2, 3, 2);
            txt_ClaveCliente.Name = "txt_ClaveCliente";
            txt_ClaveCliente.Size = new Size(263, 23);
            txt_ClaveCliente.TabIndex = 34;
            // 
            // txt_RFCCliente
            // 
            txt_RFCCliente.Location = new Point(204, 177);
            txt_RFCCliente.Margin = new Padding(3, 2, 3, 2);
            txt_RFCCliente.Name = "txt_RFCCliente";
            txt_RFCCliente.Size = new Size(263, 23);
            txt_RFCCliente.TabIndex = 33;
            // 
            // txt_NombreCliente
            // 
            txt_NombreCliente.Location = new Point(204, 140);
            txt_NombreCliente.Margin = new Padding(3, 2, 3, 2);
            txt_NombreCliente.Name = "txt_NombreCliente";
            txt_NombreCliente.Size = new Size(263, 23);
            txt_NombreCliente.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(31, 267);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 30;
            label6.Text = "Correo electronico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(31, 220);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 29;
            label7.Text = "Clave:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(31, 178);
            label8.Name = "label8";
            label8.Size = new Size(33, 17);
            label8.TabIndex = 28;
            label8.Text = "RFC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(31, 141);
            label9.Name = "label9";
            label9.Size = new Size(60, 17);
            label9.TabIndex = 27;
            label9.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(btn_ActualizarCliente);
            panel2.Controls.Add(btn_EditarCliente);
            panel2.Controls.Add(btn_EliminarCliente);
            panel2.Controls.Add(btn_NuevoCliente);
            panel2.Controls.Add(btn_GuardarCliente);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 387);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 39;
            // 
            // btn_EliminarCliente
            // 
            btn_EliminarCliente.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarCliente.Location = new Point(520, 10);
            btn_EliminarCliente.Name = "btn_EliminarCliente";
            btn_EliminarCliente.Size = new Size(88, 30);
            btn_EliminarCliente.TabIndex = 3;
            btn_EliminarCliente.Text = "      Eliminar";
            btn_EliminarCliente.TextAlign = ContentAlignment.MiddleRight;
            btn_EliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_NuevoCliente
            // 
            btn_NuevoCliente.Image = Properties.Resources.NuevoArchivo;
            btn_NuevoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NuevoCliente.Location = new Point(20, 10);
            btn_NuevoCliente.Name = "btn_NuevoCliente";
            btn_NuevoCliente.Size = new Size(88, 30);
            btn_NuevoCliente.TabIndex = 0;
            btn_NuevoCliente.Text = "      Nuevo";
            btn_NuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarCliente
            // 
            btn_GuardarCliente.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarCliente.Location = new Point(136, 10);
            btn_GuardarCliente.Name = "btn_GuardarCliente";
            btn_GuardarCliente.Size = new Size(88, 30);
            btn_GuardarCliente.TabIndex = 1;
            btn_GuardarCliente.Text = "      Guardar";
            btn_GuardarCliente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 102);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 40;
            label3.Text = "No. de Cliente:";
            // 
            // txt_numeroCliente
            // 
            txt_numeroCliente.Location = new Point(204, 99);
            txt_numeroCliente.Margin = new Padding(3, 2, 3, 2);
            txt_numeroCliente.Name = "txt_numeroCliente";
            txt_numeroCliente.Size = new Size(263, 23);
            txt_numeroCliente.TabIndex = 41;
            // 
            // btn_EditarCliente
            // 
            btn_EditarCliente.Image = Properties.Resources.icons8_update_24;
            btn_EditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditarCliente.Location = new Point(259, 10);
            btn_EditarCliente.Name = "btn_EditarCliente";
            btn_EditarCliente.Size = new Size(88, 30);
            btn_EditarCliente.TabIndex = 4;
            btn_EditarCliente.Text = "      Editar";
            btn_EditarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_ActualizarCliente
            // 
            btn_ActualizarCliente.Image = Properties.Resources.GuardarArchivo;
            btn_ActualizarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActualizarCliente.Location = new Point(389, 10);
            btn_ActualizarCliente.Name = "btn_ActualizarCliente";
            btn_ActualizarCliente.Size = new Size(97, 30);
            btn_ActualizarCliente.TabIndex = 5;
            btn_ActualizarCliente.Text = "        Actualizar";
            btn_ActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 437);
            Controls.Add(txt_numeroCliente);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(txt_TelefonoCliente);
            Controls.Add(txt_CorreoCliente);
            Controls.Add(txt_ClaveCliente);
            Controls.Add(txt_RFCCliente);
            Controls.Add(txt_NombreCliente);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_clientes";
            Text = "frm_clientes";
            Load += frm_clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_EliminarCliente;
        private Button btn_AgregarC;
        private TextBox txt_RFCC;
        private Label label11;
        private TextBox txt_CorreoC;
        private TextBox txt_TelefonoClientes;
        private TextBox txt_NombreC;
        private TextBox txt_ClaveC;
        private TextBox txt_NumeroclienteC;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btn_ActualizarC;
        private Button btn_EditarCliente;
        private Panel panel2;
        private Button btn_CerrarProduc;
        private Label label1;
        private Panel panel1;
       
        private Button btn_NuevoCliente;
        private Button btn_GuardarCliente;
        private Button btn_CerrarCliente;
        private Label label2;
        private PictureBox picturebox_prueba;
        private TextBox txt_DireccionPerfil;
        private TextBox txt_TelefonoCliente;
        private TextBox txt_CorreoCliente;
        private TextBox txt_ClaveCliente;
        private TextBox txt_RFCCliente;
        private TextBox txt_NombreCliente;
        private Label label5;
        private Label label3;
        private TextBox txt_numeroCliente;
        private Button btn_ActualizarCliente;
    }
}