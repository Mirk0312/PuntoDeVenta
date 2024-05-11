namespace POS
{
    partial class frm_proveedores
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
            btn_Buscar = new Button();
            txt_CostoP = new TextBox();
            txt_VentaP = new TextBox();
            txt_EncargadoP = new TextBox();
            txt_EmpresaP = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_IDP = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            btn_ELiminarP = new Button();
            btn_NuevoP = new Button();
            btn_CancelarP = new Button();
            btn_GuardarP = new Button();
            panel2 = new Panel();
            btn_CerrarP = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_ProductoP = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Image = Properties.Resources.Buscar;
            btn_Buscar.Location = new Point(265, 86);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(28, 23);
            btn_Buscar.TabIndex = 39;
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_CostoP
            // 
            txt_CostoP.Location = new Point(160, 244);
            txt_CostoP.Name = "txt_CostoP";
            txt_CostoP.Size = new Size(232, 23);
            txt_CostoP.TabIndex = 36;
            // 
            // txt_VentaP
            // 
            txt_VentaP.Location = new Point(160, 290);
            txt_VentaP.Name = "txt_VentaP";
            txt_VentaP.Size = new Size(232, 23);
            txt_VentaP.TabIndex = 35;
            // 
            // txt_EncargadoP
            // 
            txt_EncargadoP.Location = new Point(160, 162);
            txt_EncargadoP.Name = "txt_EncargadoP";
            txt_EncargadoP.Size = new Size(232, 23);
            txt_EncargadoP.TabIndex = 33;
            // 
            // txt_EmpresaP
            // 
            txt_EmpresaP.Location = new Point(160, 121);
            txt_EmpresaP.Name = "txt_EmpresaP";
            txt_EmpresaP.Size = new Size(232, 23);
            txt_EmpresaP.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(20, 296);
            label8.Name = "label8";
            label8.Size = new Size(120, 17);
            label8.TabIndex = 31;
            label8.Text = "Venta del producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(20, 250);
            label7.Name = "label7";
            label7.Size = new Size(122, 17);
            label7.TabIndex = 30;
            label7.Text = "Costo del producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(20, 208);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 29;
            label6.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(20, 127);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 27;
            label4.Text = "Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(20, 168);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 26;
            label3.Text = "Encargado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 121);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 25;
            // 
            // txt_IDP
            // 
            txt_IDP.Location = new Point(160, 87);
            txt_IDP.Name = "txt_IDP";
            txt_IDP.Size = new Size(100, 23);
            txt_IDP.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(20, 93);
            label9.Name = "label9";
            label9.Size = new Size(20, 17);
            label9.TabIndex = 23;
            label9.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_ELiminarP);
            panel1.Controls.Add(btn_NuevoP);
            panel1.Controls.Add(btn_CancelarP);
            panel1.Controls.Add(btn_GuardarP);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 40;
            // 
            // btn_ELiminarP
            // 
            btn_ELiminarP.Image = Properties.Resources.EliminarArchivo;
            btn_ELiminarP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ELiminarP.Location = new Point(250, 10);
            btn_ELiminarP.Name = "btn_ELiminarP";
            btn_ELiminarP.Size = new Size(88, 30);
            btn_ELiminarP.TabIndex = 4;
            btn_ELiminarP.Text = "      Eliminar";
            btn_ELiminarP.TextAlign = ContentAlignment.MiddleRight;
            btn_ELiminarP.UseVisualStyleBackColor = true;
            // 
            // btn_NuevoP
            // 
            btn_NuevoP.Image = Properties.Resources.NuevoArchivo;
            btn_NuevoP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NuevoP.Location = new Point(20, 10);
            btn_NuevoP.Name = "btn_NuevoP";
            btn_NuevoP.Size = new Size(88, 30);
            btn_NuevoP.TabIndex = 0;
            btn_NuevoP.Text = "      Nuevo";
            btn_NuevoP.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarP
            // 
            btn_CancelarP.Image = Properties.Resources.CancelarArchivo;
            btn_CancelarP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CancelarP.Location = new Point(368, 10);
            btn_CancelarP.Name = "btn_CancelarP";
            btn_CancelarP.Size = new Size(88, 30);
            btn_CancelarP.TabIndex = 2;
            btn_CancelarP.Text = "      Cancelar";
            btn_CancelarP.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarP
            // 
            btn_GuardarP.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarP.Location = new Point(136, 10);
            btn_GuardarP.Name = "btn_GuardarP";
            btn_GuardarP.Size = new Size(88, 30);
            btn_GuardarP.TabIndex = 1;
            btn_GuardarP.Text = "      Guardar";
            btn_GuardarP.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btn_CerrarP);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 41;
            // 
            // btn_CerrarP
            // 
            btn_CerrarP.Image = Properties.Resources.CerrarVentana;
            btn_CerrarP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarP.Location = new Point(707, 19);
            btn_CerrarP.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarP.Name = "btn_CerrarP";
            btn_CerrarP.Size = new Size(83, 22);
            btn_CerrarP.TabIndex = 23;
            btn_CerrarP.Text = "        Cerrar";
            btn_CerrarP.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarP.UseVisualStyleBackColor = true;
            btn_CerrarP.Click += btn_CerrarCP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CatalogoProveedor;
            pictureBox1.Location = new Point(43, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 16);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 21;
            label1.Text = "Catalogo de proveedores";
            // 
            // txt_ProductoP
            // 
            txt_ProductoP.Location = new Point(160, 202);
            txt_ProductoP.Name = "txt_ProductoP";
            txt_ProductoP.Size = new Size(232, 23);
            txt_ProductoP.TabIndex = 42;
            // 
            // frm_proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ProductoP);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_CostoP);
            Controls.Add(txt_VentaP);
            Controls.Add(txt_EncargadoP);
            Controls.Add(txt_EmpresaP);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_IDP);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frm_proveedores";
            Text = "v";
            Load += frm_proveedores_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private TextBox txt_CostoP;
        private TextBox txt_VentaP;
        private TextBox txt_EncargadoP;
        private TextBox txt_EmpresaP;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_IDP;
        private Label label9;
        private Panel panel1;
        private Button btn_NuevoP;
        private Button btn_CancelarP;
        private Button btn_GuardarP;
        private Panel panel2;
        private Button btn_CerrarP;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_ELiminarP;
        private TextBox txt_ProductoP;
    }
}