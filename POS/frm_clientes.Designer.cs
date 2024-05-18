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
            btn_CerrarClientes = new Button();
            btn_EliminarClientes = new Button();
            btn_AgregarClientes = new Button();
            txt_RFCClientes = new TextBox();
            label11Clientes = new Label();
            txt_CorreoClientes = new TextBox();
            txt_TelefonoClientes = new TextBox();
            txt_NombreClientes = new TextBox();
            txt_ClaveClientes = new TextBox();
            txt_NodeCliente = new TextBox();
            label10Clientes = new Label();
            label9 = new Label();
            label8Clientes = new Label();
            label7Clientes = new Label();
            label6Clientes = new Label();
            pictureBox1Clientes = new PictureBox();
            btn_ActualizarClientes = new Button();
            btn_EditarClientes = new Button();
            panel2 = new Panel();
            label2Clientes = new Label();
            panel1 = new Panel();
            btn_GuardarClientes = new Button();
            label1Clientes = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Clientes).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CerrarClientes
            // 
            btn_CerrarClientes.Image = Properties.Resources.CerrarVentana;
            btn_CerrarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarClientes.Location = new Point(807, 26);
            btn_CerrarClientes.Name = "btn_CerrarClientes";
            btn_CerrarClientes.Size = new Size(95, 32);
            btn_CerrarClientes.TabIndex = 24;
            btn_CerrarClientes.Text = "        Cerrar";
            btn_CerrarClientes.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarClientes.UseVisualStyleBackColor = true;
            btn_CerrarClientes.Click += btn_CerrarCP_Click;
            // 
            // btn_EliminarClientes
            // 
            btn_EliminarClientes.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarClientes.Location = new Point(286, 15);
            btn_EliminarClientes.Name = "btn_EliminarClientes";
            btn_EliminarClientes.Size = new Size(110, 40);
            btn_EliminarClientes.TabIndex = 31;
            btn_EliminarClientes.Text = "  Eliminar";
            btn_EliminarClientes.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarClientes
            // 
            btn_AgregarClientes.Image = Properties.Resources.icons8_add_24;
            btn_AgregarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarClientes.Location = new Point(25, 13);
            btn_AgregarClientes.Name = "btn_AgregarClientes";
            btn_AgregarClientes.Size = new Size(103, 40);
            btn_AgregarClientes.TabIndex = 30;
            btn_AgregarClientes.Text = "  Agregar";
            btn_AgregarClientes.UseVisualStyleBackColor = true;
            // 
            // txt_RFCClientes
            // 
            txt_RFCClientes.Location = new Point(206, 214);
            txt_RFCClientes.Name = "txt_RFCClientes";
            txt_RFCClientes.Size = new Size(310, 23);
            txt_RFCClientes.TabIndex = 28;
            // 
            // label11Clientes
            // 
            label11Clientes.AutoSize = true;
            label11Clientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11Clientes.Location = new Point(25, 214);
            label11Clientes.Name = "label11Clientes";
            label11Clientes.Size = new Size(36, 19);
            label11Clientes.TabIndex = 27;
            label11Clientes.Text = "RFC:";
            // 
            // txt_CorreoClientes
            // 
            txt_CorreoClientes.Location = new Point(206, 311);
            txt_CorreoClientes.Name = "txt_CorreoClientes";
            txt_CorreoClientes.Size = new Size(310, 23);
            txt_CorreoClientes.TabIndex = 26;
            // 
            // txt_TelefonoClientes
            // 
            txt_TelefonoClientes.Location = new Point(206, 374);
            txt_TelefonoClientes.Name = "txt_TelefonoClientes";
            txt_TelefonoClientes.Size = new Size(310, 23);
            txt_TelefonoClientes.TabIndex = 25;
            // 
            // txt_NombreClientes
            // 
            txt_NombreClientes.Location = new Point(206, 162);
            txt_NombreClientes.Name = "txt_NombreClientes";
            txt_NombreClientes.Size = new Size(310, 23);
            txt_NombreClientes.TabIndex = 24;
            // 
            // txt_ClaveClientes
            // 
            txt_ClaveClientes.Location = new Point(206, 261);
            txt_ClaveClientes.Name = "txt_ClaveClientes";
            txt_ClaveClientes.Size = new Size(310, 23);
            txt_ClaveClientes.TabIndex = 23;
            // 
            // txt_NodeCliente
            // 
            txt_NodeCliente.Location = new Point(206, 114);
            txt_NodeCliente.Name = "txt_NodeCliente";
            txt_NodeCliente.Size = new Size(310, 23);
            txt_NodeCliente.TabIndex = 22;
            // 
            // label10Clientes
            // 
            label10Clientes.AutoSize = true;
            label10Clientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10Clientes.Location = new Point(25, 311);
            label10Clientes.Name = "label10Clientes";
            label10Clientes.Size = new Size(124, 19);
            label10Clientes.TabIndex = 21;
            label10Clientes.Text = "Correo electronico:";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 388);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 20;
            label9.Text = "* Teléfono: ";
            // 
            // label8Clientes
            // 
            label8Clientes.AutoSize = true;
            label8Clientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8Clientes.Location = new Point(25, 162);
            label8Clientes.Name = "label8Clientes";
            label8Clientes.Size = new Size(62, 19);
            label8Clientes.TabIndex = 19;
            label8Clientes.Text = "Nombre:";
            // 
            // label7Clientes
            // 
            label7Clientes.AutoSize = true;
            label7Clientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7Clientes.Location = new Point(25, 265);
            label7Clientes.Name = "label7Clientes";
            label7Clientes.Size = new Size(45, 19);
            label7Clientes.TabIndex = 18;
            label7Clientes.Text = "Clave:";
            label7Clientes.Click += label7_Click;
            // 
            // label6Clientes
            // 
            label6Clientes.AutoSize = true;
            label6Clientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6Clientes.Location = new Point(25, 113);
            label6Clientes.Name = "label6Clientes";
            label6Clientes.Size = new Size(111, 20);
            label6Clientes.TabIndex = 17;
            label6Clientes.Text = "No. de Cliente:";
            // 
            // pictureBox1Clientes
            // 
            pictureBox1Clientes.Image = Properties.Resources.icons8_clientes_100;
            pictureBox1Clientes.Location = new Point(3, 0);
            pictureBox1Clientes.Name = "pictureBox1Clientes";
            pictureBox1Clientes.Size = new Size(119, 136);
            pictureBox1Clientes.TabIndex = 32;
            pictureBox1Clientes.TabStop = false;
            // 
            // btn_ActualizarClientes
            // 
            btn_ActualizarClientes.Image = Properties.Resources.icons8_update_24;
            btn_ActualizarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActualizarClientes.Location = new Point(425, 13);
            btn_ActualizarClientes.Name = "btn_ActualizarClientes";
            btn_ActualizarClientes.Size = new Size(109, 38);
            btn_ActualizarClientes.TabIndex = 33;
            btn_ActualizarClientes.Text = "    Actualizar";
            btn_ActualizarClientes.UseVisualStyleBackColor = true;
            // 
            // btn_EditarClientes
            // 
            btn_EditarClientes.Image = Properties.Resources.icons8_update_24;
            btn_EditarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditarClientes.Location = new Point(560, 10);
            btn_EditarClientes.Name = "btn_EditarClientes";
            btn_EditarClientes.Size = new Size(107, 41);
            btn_EditarClientes.TabIndex = 34;
            btn_EditarClientes.Text = "    Editar";
            btn_EditarClientes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label2Clientes);
            panel2.Controls.Add(pictureBox1Clientes);
            panel2.Controls.Add(btn_CerrarClientes);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 75);
            panel2.TabIndex = 42;
            // 
            // label2Clientes
            // 
            label2Clientes.AutoSize = true;
            label2Clientes.BackColor = Color.DarkBlue;
            label2Clientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2Clientes.ForeColor = Color.AliceBlue;
            label2Clientes.Location = new Point(128, 23);
            label2Clientes.Name = "label2Clientes";
            label2Clientes.Size = new Size(81, 25);
            label2Clientes.TabIndex = 21;
            label2Clientes.Text = "Clientes";
            label2Clientes.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_GuardarClientes);
            panel1.Controls.Add(btn_AgregarClientes);
            panel1.Controls.Add(btn_EditarClientes);
            panel1.Controls.Add(btn_EliminarClientes);
            panel1.Controls.Add(btn_ActualizarClientes);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 67);
            panel1.TabIndex = 43;
            // 
            // btn_GuardarClientes
            // 
            btn_GuardarClientes.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarClientes.Location = new Point(155, 13);
            btn_GuardarClientes.Margin = new Padding(3, 4, 3, 4);
            btn_GuardarClientes.Name = "btn_GuardarClientes";
            btn_GuardarClientes.Size = new Size(101, 40);
            btn_GuardarClientes.TabIndex = 1;
            btn_GuardarClientes.Text = "      Guardar";
            btn_GuardarClientes.UseVisualStyleBackColor = true;
            // 
            // label1Clientes
            // 
            label1Clientes.AutoSize = true;
            label1Clientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1Clientes.Location = new Point(26, 380);
            label1Clientes.Name = "label1Clientes";
            label1Clientes.Size = new Size(61, 17);
            label1Clientes.TabIndex = 44;
            label1Clientes.Text = "Telefono:";
            // 
            // frm_clientes
            // 
            ClientSize = new Size(914, 583);
            Controls.Add(label1Clientes);
            Controls.Add(txt_RFCClientes);
            Controls.Add(label11Clientes);
            Controls.Add(txt_CorreoClientes);
            Controls.Add(txt_TelefonoClientes);
            Controls.Add(txt_NombreClientes);
            Controls.Add(txt_ClaveClientes);
            Controls.Add(label10Clientes);
            Controls.Add(txt_NodeCliente);
            Controls.Add(label8Clientes);
            Controls.Add(label7Clientes);
            Controls.Add(label6Clientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1Clientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_EliminarC;
        private Label label2Clientes;
        private Button btn_EliminarClientes;


        #endregion

        private Button btn_EliminarClienteliente;
        private Button btn_AgregarClientes;
        private TextBox txt_RFCClientes;
       
        private Label label11Clientes;
        private TextBox txt_CorreoClientes;
    
        private TextBox txt_TelefonoClientes;
        
        private TextBox txt_NombreClientes;
        
        private TextBox txt_ClaveClientes;
        private TextBox txt_NodeCliente;
      
        private TextBox txt_NumeroDeCliente;
        private Label label10Clientes;
        private Label label9;
        private Label label8Clientes;
        private Label label7Clientes;
        private Label label6Clientes;
 
        private Button btn_CerrarCliente;
        private Button btn_EditarClientes;
        private Panel panel2;
        private Label label15;

        private PictureBox pictureBox1Clientes;
        private Button btn_ActualizarCliente;
        private Button btn_ActualizarClientes;
       
      
        private Button btn_CerrarProduc;
        private Label label1Clientes;
        private Panel panel1;
        private Button btn_GuardarClientes;
        private Button btn_CerrarClientes;
        private Button button1;
    }
}