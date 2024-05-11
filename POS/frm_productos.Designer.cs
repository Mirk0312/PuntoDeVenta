namespace POS
{
    partial class frm_productos
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
            btn_NuevoProduc = new Button();
            btn_GuardarProduc = new Button();
            btn_CancelarProduc = new Button();
            label1 = new Label();
            txt_IDProduc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_CodigoProduc = new TextBox();
            txt_NombreProduc = new TextBox();
            txt_DescripcionProduc = new TextBox();
            txt_CostoProduc = new TextBox();
            txt_VentaProduc = new TextBox();
            cbx_UnidadProduc = new ComboBox();
            cbx_UbicacionProduc = new ComboBox();
            label9 = new Label();
            btn_BuscarProduc = new Button();
            panel1 = new Panel();
            btn_EliminarProduc = new Button();
            panel2 = new Panel();
            btn_CerrarProduc = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_NuevoProduc
            // 
            btn_NuevoProduc.Image = Properties.Resources.NuevoArchivo;
            btn_NuevoProduc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NuevoProduc.Location = new Point(20, 10);
            btn_NuevoProduc.Name = "btn_NuevoProduc";
            btn_NuevoProduc.Size = new Size(88, 30);
            btn_NuevoProduc.TabIndex = 0;
            btn_NuevoProduc.Text = "      Nuevo";
            btn_NuevoProduc.UseVisualStyleBackColor = true;
            btn_NuevoProduc.Click += btn_nuevo_Click;
            // 
            // btn_GuardarProduc
            // 
            btn_GuardarProduc.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarProduc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarProduc.Location = new Point(136, 10);
            btn_GuardarProduc.Name = "btn_GuardarProduc";
            btn_GuardarProduc.Size = new Size(88, 30);
            btn_GuardarProduc.TabIndex = 1;
            btn_GuardarProduc.Text = "      Guardar";
            btn_GuardarProduc.UseVisualStyleBackColor = true;
            btn_GuardarProduc.Click += btn_guardar_Click;
            // 
            // btn_CancelarProduc
            // 
            btn_CancelarProduc.Image = Properties.Resources.CancelarArchivo;
            btn_CancelarProduc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CancelarProduc.Location = new Point(365, 10);
            btn_CancelarProduc.Name = "btn_CancelarProduc";
            btn_CancelarProduc.Size = new Size(88, 30);
            btn_CancelarProduc.TabIndex = 2;
            btn_CancelarProduc.Text = "      Cancelar";
            btn_CancelarProduc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 76);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txt_IDProduc
            // 
            txt_IDProduc.Location = new Point(171, 74);
            txt_IDProduc.Name = "txt_IDProduc";
            txt_IDProduc.Size = new Size(100, 23);
            txt_IDProduc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 110);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 188);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 219);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 8;
            label5.Text = "Unidad de medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 289);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "Costo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 254);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 10;
            label7.Text = "Ubicacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 322);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 11;
            label8.Text = "Venta";
            // 
            // txt_CodigoProduc
            // 
            txt_CodigoProduc.Location = new Point(171, 108);
            txt_CodigoProduc.Name = "txt_CodigoProduc";
            txt_CodigoProduc.Size = new Size(232, 23);
            txt_CodigoProduc.TabIndex = 12;
            // 
            // txt_NombreProduc
            // 
            txt_NombreProduc.Location = new Point(171, 148);
            txt_NombreProduc.Name = "txt_NombreProduc";
            txt_NombreProduc.Size = new Size(232, 23);
            txt_NombreProduc.TabIndex = 13;
            // 
            // txt_DescripcionProduc
            // 
            txt_DescripcionProduc.Location = new Point(171, 183);
            txt_DescripcionProduc.Name = "txt_DescripcionProduc";
            txt_DescripcionProduc.Size = new Size(232, 23);
            txt_DescripcionProduc.TabIndex = 14;
            // 
            // txt_CostoProduc
            // 
            txt_CostoProduc.Location = new Point(171, 284);
            txt_CostoProduc.Name = "txt_CostoProduc";
            txt_CostoProduc.Size = new Size(232, 23);
            txt_CostoProduc.TabIndex = 17;
            // 
            // txt_VentaProduc
            // 
            txt_VentaProduc.Location = new Point(171, 318);
            txt_VentaProduc.Name = "txt_VentaProduc";
            txt_VentaProduc.Size = new Size(232, 23);
            txt_VentaProduc.TabIndex = 18;
            // 
            // cbx_UnidadProduc
            // 
            cbx_UnidadProduc.FormattingEnabled = true;
            cbx_UnidadProduc.Location = new Point(171, 218);
            cbx_UnidadProduc.Name = "cbx_UnidadProduc";
            cbx_UnidadProduc.Size = new Size(134, 23);
            cbx_UnidadProduc.TabIndex = 19;
            // 
            // cbx_UbicacionProduc
            // 
            cbx_UbicacionProduc.FormattingEnabled = true;
            cbx_UbicacionProduc.Location = new Point(171, 248);
            cbx_UbicacionProduc.Name = "cbx_UbicacionProduc";
            cbx_UbicacionProduc.Size = new Size(134, 23);
            cbx_UbicacionProduc.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightCyan;
            label9.Location = new Point(99, 16);
            label9.Name = "label9";
            label9.Size = new Size(216, 25);
            label9.TabIndex = 21;
            label9.Text = "Catalogo de productos";
            // 
            // btn_BuscarProduc
            // 
            btn_BuscarProduc.Image = Properties.Resources.Buscar;
            btn_BuscarProduc.Location = new Point(276, 74);
            btn_BuscarProduc.Name = "btn_BuscarProduc";
            btn_BuscarProduc.Size = new Size(28, 23);
            btn_BuscarProduc.TabIndex = 22;
            btn_BuscarProduc.UseVisualStyleBackColor = true;
            btn_BuscarProduc.Click += btn_Buscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_EliminarProduc);
            panel1.Controls.Add(btn_NuevoProduc);
            panel1.Controls.Add(btn_CancelarProduc);
            panel1.Controls.Add(btn_GuardarProduc);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 23;
            // 
            // btn_EliminarProduc
            // 
            btn_EliminarProduc.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarProduc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarProduc.Location = new Point(249, 10);
            btn_EliminarProduc.Name = "btn_EliminarProduc";
            btn_EliminarProduc.Size = new Size(88, 30);
            btn_EliminarProduc.TabIndex = 3;
            btn_EliminarProduc.Text = "      Eliminar";
            btn_EliminarProduc.TextAlign = ContentAlignment.MiddleRight;
            btn_EliminarProduc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(btn_CerrarProduc);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 24;
            // 
            // btn_CerrarProduc
            // 
            btn_CerrarProduc.Image = Properties.Resources.CerrarVentana;
            btn_CerrarProduc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarProduc.Location = new Point(705, 16);
            btn_CerrarProduc.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarProduc.Name = "btn_CerrarProduc";
            btn_CerrarProduc.Size = new Size(83, 22);
            btn_CerrarProduc.TabIndex = 23;
            btn_CerrarProduc.Text = "        Cerrar";
            btn_CerrarProduc.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarProduc.UseVisualStyleBackColor = true;
            btn_CerrarProduc.Click += btn_CerrarCP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CatalogoProductos;
            pictureBox1.Location = new Point(52, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // frm_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_BuscarProduc);
            Controls.Add(cbx_UbicacionProduc);
            Controls.Add(cbx_UnidadProduc);
            Controls.Add(txt_VentaProduc);
            Controls.Add(txt_CostoProduc);
            Controls.Add(txt_DescripcionProduc);
            Controls.Add(txt_NombreProduc);
            Controls.Add(txt_CodigoProduc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_IDProduc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frm_productos";
            Text = "frm_productos";
            Load += frm_productos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_NuevoProduc;
        private Button btn_GuardarProduc;
        private Button btn_CancelarProduc;
        private Label label1;
        private TextBox txt_IDProduc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_CodigoProduc;
        private TextBox txt_NombreProduc;
        private TextBox txt_DescripcionProduc;
        private TextBox txt_CostoProduc;
        private TextBox txt_VentaProduc;
        private ComboBox cbx_UnidadProduc;
        private ComboBox cbx_UbicacionProduc;
        private Label label9;
        private Button btn_BuscarProduc;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_CerrarProduc;
        private Button btn_EliminarProduc;
    }
}