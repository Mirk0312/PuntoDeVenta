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
            
        
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_EliminarCliente
            // 
            btn_EliminarCliente.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarCliente.Location = new Point(505, 11);
            btn_EliminarCliente.Margin = new Padding(3, 2, 3, 2);
            btn_EliminarCliente.Name = "btn_EliminarCliente";
            btn_EliminarCliente.Size = new Size(92, 28);
            btn_EliminarCliente.TabIndex = 31;
            btn_EliminarCliente.Text = "  Eliminar";
            btn_EliminarCliente.UseVisualStyleBackColor = true;
            // 
            // txt_RFCClientes
            // 
          
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(22, 187);
            label11.Name = "label11";
            label11.Size = new Size(33, 17);
            label11.TabIndex = 27;
            label11.Text = "RFC:";
            // 
            // txt_CorreoClientes
            // 
          
            // 
            // txt_TelefonoClientes
            // 
            txt_TelefonoClientes.Location = new Point(192, 344);
            txt_TelefonoClientes.Margin = new Padding(3, 2, 3, 2);
            txt_TelefonoClientes.Name = "txt_TelefonoClientes";
            txt_TelefonoClientes.Size = new Size(261, 23);
            txt_TelefonoClientes.TabIndex = 25;
            // 
            // txt_NombreClientes
            // 
            
            // txt_ClaveClientes
            // 
         
            // 
            // txt_NumeroDeCliente
            // 
           
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(22, 292);
            label10.Name = "label10";
            label10.Size = new Size(52, 17);
            label10.TabIndex = 21;
            label10.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(22, 342);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 20;
            label9.Text = "Teléfono: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(22, 134);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 19;
            label8.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 240);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 18;
            label7.Text = "Clave:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 81);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 17;
            label6.Text = "No. de Cliente:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_clientes_100;
            pictureBox1.Location = new Point(22, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 49);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btn_ActualizarCliente
            // 
           
            // 
            // btn_EditarCliente
            // 
            btn_EditarCliente.Image = Properties.Resources.icons8_update_24;
            btn_EditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditarCliente.Location = new Point(258, 9);
            btn_EditarCliente.Margin = new Padding(3, 2, 3, 2);
            btn_EditarCliente.Name = "btn_EditarCliente";
            btn_EditarCliente.Size = new Size(88, 30);
            btn_EditarCliente.TabIndex = 34;
            btn_EditarCliente.Text = "    Editar";
            btn_EditarCliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 35;
            // 
            // btn_CerrarCliente
            // 
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 21;
            label1.Text = "Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_NuevoCliente);
            panel1.Controls.Add(btn_GuardarCliente);
            panel1.Controls.Add(btn_EliminarCliente);
            
            panel1.Controls.Add(btn_EditarCliente);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 387);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 36;
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
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 437);
            Controls.Add(panel1);
            Controls.Add(panel2);
            
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_clientes";
            Text = "frm_clientes";
            Load += frm_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Button btn_EliminarPerfil;
        private Button btn_NuevoCliente;
        private Button btn_GuardarCliente;
    }
}