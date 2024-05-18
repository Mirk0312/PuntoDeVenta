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
            btn_CerrarC = new Button();
            btn_EliminarC = new Button();
            btn_AgregarC = new Button();
            txt_RFCC = new TextBox();
            label11 = new Label();
            txt_CorreoC = new TextBox();
            txt_TelefonoC = new TextBox();
            txt_NombreC = new TextBox();
            txt_ClaveC = new TextBox();
            txt_NumeroclienteC = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btn_ActualizarC = new Button();
            btn_EditarC = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            btn_GuardarC = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            // btn_CerrarC
            // 
            btn_CerrarC.Image = Properties.Resources.CerrarVentana;
            btn_CerrarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarC.Location = new Point(807, 26);
            btn_CerrarC.Name = "btn_CerrarC";
            btn_CerrarC.Size = new Size(95, 32);
            btn_CerrarC.TabIndex = 24;
            btn_CerrarC.Text = "        Cerrar";
            btn_CerrarC.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarC.UseVisualStyleBackColor = true;
            btn_CerrarC.Click += btn_CerrarCP_Click;
            btn_CerrarC.UseVisualStyleBackColor = true;
            // btn_EliminarC
            // 
            btn_EliminarC.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarC.Location = new Point(286, 15);
            btn_EliminarC.Name = "btn_EliminarC";
            btn_EliminarC.Size = new Size(110, 40);
            btn_EliminarC.TabIndex = 31;
            btn_EliminarC.Text = "  Eliminar";
            btn_EliminarC.UseVisualStyleBackColor = true;
            btn_EliminarC.Text = "  Eliminar";
            btn_EliminarC.UseVisualStyleBackColor = true;
            // 
            btn_AgregarC.Image = Properties.Resources.icons8_add_24;
            btn_AgregarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarC.Location = new Point(25, 13);
            btn_AgregarC.Name = "btn_AgregarC";
            btn_AgregarC.Size = new Size(103, 40);
            btn_AgregarC.TabIndex = 30;
            btn_AgregarC.Text = "  Agregar";
            btn_AgregarC.UseVisualStyleBackColor = true;
            btn_AgregarC.Text = "  Agregar";
            btn_AgregarC.UseVisualStyleBackColor = true;
            // 
            txt_RFCC.Location = new Point(242, 214);
            txt_RFCC.Name = "txt_RFCC";
            txt_RFCC.Size = new Size(362, 27);
            txt_RFCC.TabIndex = 28;
            txt_RFCC.Size = new Size(151, 23);
            txt_RFCC.TabIndex = 28;
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 214);
            label11.Name = "label11";
            label11.Size = new Size(43, 23);
            label11.TabIndex = 27;
            label11.Text = "RFC:";
            label11.TabIndex = 27;
            label11.Text = "* RFC";
            // 
            txt_CorreoC.Location = new Point(242, 326);
            txt_CorreoC.Name = "txt_CorreoC";
            txt_CorreoC.Size = new Size(362, 27);
            txt_CorreoC.TabIndex = 26;
            txt_CorreoC.Size = new Size(151, 23);
            txt_CorreoC.TabIndex = 26;
            // 
            txt_TelefonoC.Location = new Point(242, 388);
            txt_TelefonoC.Name = "txt_TelefonoC";
            txt_TelefonoC.Size = new Size(362, 27);
            txt_TelefonoC.TabIndex = 25;
            txt_TelefonoC.Size = new Size(152, 23);
            txt_TelefonoC.TabIndex = 25;
            // 
            txt_NombreC.Location = new Point(242, 161);
            txt_NombreC.Name = "txt_NombreC";
            txt_NombreC.Size = new Size(362, 27);
            txt_NombreC.TabIndex = 24;
            txt_NombreC.Size = new Size(152, 23);
            txt_NombreC.TabIndex = 24;
            // 
            txt_ClaveC.Location = new Point(242, 265);
            txt_ClaveC.Name = "txt_ClaveC";
            txt_ClaveC.Size = new Size(362, 27);
            txt_ClaveC.TabIndex = 23;
            txt_ClaveC.Size = new Size(152, 23);
            txt_ClaveC.TabIndex = 23;
            // 
            txt_NumeroclienteC.Location = new Point(242, 113);
            txt_NumeroclienteC.Name = "txt_NumeroclienteC";
            txt_NumeroclienteC.Size = new Size(362, 27);
            txt_NumeroclienteC.TabIndex = 22;
            txt_NumeroclienteC.Size = new Size(152, 23);
            txt_NumeroclienteC.TabIndex = 22;
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 330);
            label10.Name = "label10";
            label10.Size = new Size(62, 23);
            label10.TabIndex = 21;
            label10.Text = "Correo";
            label10.TabIndex = 21;
            label10.Text = "* Correo";
            // 
            // label9
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 388);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Size = new Size(83, 23);
            label9.TabIndex = 20;
            label9.Text = "Teléfono: ";
            label9.TabIndex = 20;
            label9.Text = "* Teléfono: ";
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 162);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 19;
            label8.Text = "Nombre:";
            label8.TabIndex = 19;
            label8.Text = "* Nombre:";
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 265);
            label7.Name = "label7";
            label7.Size = new Size(55, 23);
            label7.TabIndex = 18;
            label7.Text = "Clave:";
            label7.Click += label7_Click;
            label7.Text = "Clave:";
            label7.Click += label7_Click;
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 113);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 17;
            label6.Text = "No. de Cliente:";
            label6.TabIndex = 17;
            label6.Text = "No. de Cliente:";
            // 
            pictureBox1.Image = Properties.Resources.icons8_clientes_100;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 136);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            btn_ActualizarC.Image = Properties.Resources.icons8_update_24;
            btn_ActualizarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActualizarC.Location = new Point(425, 13);
            btn_ActualizarC.Name = "btn_ActualizarC";
            btn_ActualizarC.Size = new Size(109, 38);
            btn_ActualizarC.TabIndex = 33;
            btn_ActualizarC.Text = "    Actualizar";
            btn_ActualizarC.UseVisualStyleBackColor = true;
            btn_ActualizarC.Text = "    Actualizar";
            // btn_EditarC
            // 
            btn_EditarC.Image = Properties.Resources.icons8_update_24;
            btn_EditarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditarC.Location = new Point(560, 10);
            btn_EditarC.Name = "btn_EditarC";
            btn_EditarC.Size = new Size(107, 41);
            btn_EditarC.TabIndex = 34;
            btn_EditarC.Text = "    Editar";
            btn_EditarC.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_CerrarC);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 75);
            panel2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkBlue;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(128, 23);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 21;
            label2.Text = "Clientes";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_GuardarC);
            panel1.Controls.Add(btn_AgregarC);
            panel1.Controls.Add(btn_EditarC);
            panel1.Controls.Add(btn_EliminarC);
            panel1.Controls.Add(btn_ActualizarC);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 67);
            panel1.TabIndex = 43;
            // 
            // btn_GuardarC
            // 
            btn_GuardarC.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarC.Location = new Point(155, 13);
            btn_GuardarC.Margin = new Padding(3, 4, 3, 4);
            btn_GuardarC.Name = "btn_GuardarC";
            btn_GuardarC.Size = new Size(101, 40);
            btn_GuardarC.TabIndex = 1;
            btn_GuardarC.Text = "      Guardar";
            btn_GuardarC.UseVisualStyleBackColor = true;
            button1.Text = "    Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frm_clientes
            // 
            ClientSize = new Size(914, 583);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txt_RFCC);
            Controls.Add(label11);
            Controls.Add(txt_CorreoC);
            Controls.Add(txt_TelefonoC);
            Controls.Add(txt_NombreC);
            Controls.Add(txt_ClaveC);
            Controls.Add(txt_NumeroclienteC);
            Controls.Add(label10);
            Controls.Add(txt_NumeroclienteC);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
main
        private Button btn_EliminarC;
        private Label label2;
        private Button btn_EliminarC;


        #endregion
        private Button btn_EliminarCliente;
        private TextBox txt_RFCClientes;

        private Button btn_AgregarC;
        private TextBox txt_RFCC;
        private Label label11;
        private TextBox txt_CorreoClientes;
        private TextBox txt_CorreoC;
        private TextBox txt_TelefonoClientes;
        private TextBox txt_NombreClientes;
        private TextBox txt_NombreC;
        private TextBox txt_ClaveC;
        private TextBox txt_NumeroclienteC;
        private TextBox txt_ClaveClientes;
        private TextBox txt_NumeroDeCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
 main
        private Button btn_CerrarC;
        private Button btn_EditarC;
        private Panel panel2;
        private Label label2;

        private PictureBox pictureBox1;
        private Button btn_ActualizarCliente;
        private Button btn_ActualizarC;
        private Button btn_EditarCliente;
        private Panel panel2;
        private Button btn_CerrarCliente;
        private Button btn_CerrarProduc;
        private Label label1;
        private Panel panel1;
        private Button btn_GuardarC;
        private Button btn_CerrarC;
        private Button button1;
    }
}