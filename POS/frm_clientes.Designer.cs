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
            btn_CerrarC = new Button();
            label1 = new Label();
            btn_cerrarsesionclientes = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_CerrarC);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 38);
            panel1.TabIndex = 1;
            // 
            // btn_CerrarC
            // 
            btn_CerrarC.Image = Properties.Resources.CerrarVentana;
            btn_CerrarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarC.Location = new Point(698, 11);
            btn_CerrarC.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarC.Name = "btn_CerrarC";
            btn_CerrarC.Size = new Size(83, 24);
            btn_CerrarC.TabIndex = 24;
            btn_CerrarC.Text = "        Cerrar";
            btn_CerrarC.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarC.UseVisualStyleBackColor = true;
            btn_CerrarC.Click += btn_CerrarCP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(344, -9);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_cerrarsesionclientes
            // 
            btn_cerrarsesionclientes.Image = Properties.Resources.cerrar;
            btn_cerrarsesionclientes.Location = new Point(694, 86);
            btn_cerrarsesionclientes.Margin = new Padding(3, 2, 3, 2);
            btn_cerrarsesionclientes.Name = "btn_cerrarsesionclientes";
            btn_cerrarsesionclientes.Size = new Size(67, 38);
            btn_cerrarsesionclientes.TabIndex = 1;
            btn_cerrarsesionclientes.UseVisualStyleBackColor = true;
            btn_cerrarsesionclientes.Click += btn_cerrarsesionclientes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.DarkCyan;
            panel2.Location = new Point(-1, 44);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 38);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(637, 8);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 4;
            label5.Text = "* Complementos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(440, 8);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "* Huella Digital";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(203, 8);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "* Datos Facturacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 0;
            label2.Text = "* Datos Basicos";
            // 
            // btn_EliminarC
            // 
            btn_EliminarC.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarC.Location = new Point(512, 340);
            btn_EliminarC.Margin = new Padding(3, 2, 3, 2);
            btn_EliminarC.Name = "btn_EliminarC";
            btn_EliminarC.Size = new Size(104, 39);
            btn_EliminarC.TabIndex = 31;
            btn_EliminarC.Text = "  Eliminar";
            btn_EliminarC.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarC
            // 
            btn_AgregarC.Image = Properties.Resources.icons8_add_24;
            btn_AgregarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarC.Location = new Point(239, 340);
            btn_AgregarC.Margin = new Padding(3, 2, 3, 2);
            btn_AgregarC.Name = "btn_AgregarC";
            btn_AgregarC.Size = new Size(104, 39);
            btn_AgregarC.TabIndex = 30;
            btn_AgregarC.Text = "  Agregar";
            btn_AgregarC.UseVisualStyleBackColor = true;
            // 
            // txt_RFCC
            // 
            txt_RFCC.Location = new Point(610, 218);
            txt_RFCC.Margin = new Padding(3, 2, 3, 2);
            txt_RFCC.Name = "txt_RFCC";
            txt_RFCC.Size = new Size(151, 23);
            txt_RFCC.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(667, 192);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 27;
            label11.Text = "* RFC";
            // 
            // txt_CorreoC
            // 
            txt_CorreoC.Location = new Point(610, 286);
            txt_CorreoC.Margin = new Padding(3, 2, 3, 2);
            txt_CorreoC.Name = "txt_CorreoC";
            txt_CorreoC.Size = new Size(151, 23);
            txt_CorreoC.TabIndex = 26;
            // 
            // txt_TelefonoC
            // 
            txt_TelefonoC.Location = new Point(344, 285);
            txt_TelefonoC.Margin = new Padding(3, 2, 3, 2);
            txt_TelefonoC.Name = "txt_TelefonoC";
            txt_TelefonoC.Size = new Size(152, 23);
            txt_TelefonoC.TabIndex = 25;
            // 
            // txt_NombreC
            // 
            txt_NombreC.Location = new Point(42, 285);
            txt_NombreC.Margin = new Padding(3, 2, 3, 2);
            txt_NombreC.Name = "txt_NombreC";
            txt_NombreC.Size = new Size(152, 23);
            txt_NombreC.TabIndex = 24;
            // 
            // txt_ClaveC
            // 
            txt_ClaveC.Location = new Point(344, 218);
            txt_ClaveC.Margin = new Padding(3, 2, 3, 2);
            txt_ClaveC.Name = "txt_ClaveC";
            txt_ClaveC.Size = new Size(152, 23);
            txt_ClaveC.TabIndex = 23;
            // 
            // txt_NumeroclienteC
            // 
            txt_NumeroclienteC.Location = new Point(42, 218);
            txt_NumeroclienteC.Margin = new Padding(3, 2, 3, 2);
            txt_NumeroclienteC.Name = "txt_NumeroclienteC";
            txt_NumeroclienteC.Size = new Size(152, 23);
            txt_NumeroclienteC.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(657, 262);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 21;
            label10.Text = "* Correo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(374, 262);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 20;
            label9.Text = "* Teléfono: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(68, 262);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 19;
            label8.Text = "* Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(389, 192);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 18;
            label7.Text = "Clave:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(56, 192);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 17;
            label6.Text = "No. de Cliente:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_clientes_100;
            pictureBox1.Location = new Point(365, 86);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 102);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btn_ActualizarC
            // 
            btn_ActualizarC.Image = Properties.Resources.icons8_update_24;
            btn_ActualizarC.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActualizarC.Location = new Point(374, 341);
            btn_ActualizarC.Margin = new Padding(3, 2, 3, 2);
            btn_ActualizarC.Name = "btn_ActualizarC";
            btn_ActualizarC.Size = new Size(104, 38);
            btn_ActualizarC.TabIndex = 33;
            btn_ActualizarC.Text = "    Actualizar";
            btn_ActualizarC.UseVisualStyleBackColor = true;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 437);
            Controls.Add(btn_ActualizarC);
            Controls.Add(btn_cerrarsesionclientes);
            Controls.Add(pictureBox1);
            Controls.Add(btn_EliminarC);
            Controls.Add(btn_AgregarC);
            Controls.Add(txt_RFCC);
            Controls.Add(label11);
            Controls.Add(txt_CorreoC);
            Controls.Add(txt_TelefonoC);
            Controls.Add(txt_NombreC);
            Controls.Add(txt_ClaveC);
            Controls.Add(txt_NumeroclienteC);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_EliminarC;
        private Button btn_AgregarC;
        private TextBox txt_RFCC;
        private Label label11;
        private TextBox txt_CorreoC;
        private TextBox txt_TelefonoC;
        private TextBox txt_NombreC;
        private TextBox txt_ClaveC;
        private TextBox txt_NumeroclienteC;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btn_cerrarsesionclientes;
        private Button btn_ActualizarC;
        private Button btn_CerrarC;
    }
}