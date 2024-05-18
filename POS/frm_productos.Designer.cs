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
            btn_NuevoProducto = new Button();
            btn_GuardarProducto = new Button();
            btn_CancelarProducto = new Button();
            label1Producto = new Label();
            txt_IDProducto = new TextBox();
            label2Producto = new Label();
            label3Producto = new Label();
            label4Producto = new Label();
            label5Producto = new Label();
            label6Producto = new Label();
            label7Producto = new Label();
            label8Producto = new Label();
            txt_CodigoProducto = new TextBox();
            txt_NombreProducto = new TextBox();
            txt_DescripcionProducto = new TextBox();
            txt_CostoProducto = new TextBox();
            txt_VentaProducto = new TextBox();
            cbx_UnidadProducto = new ComboBox();
            cbx_UbicacionProducto = new ComboBox();
            label9Producto = new Label();
            btn_BuscarProducto = new Button();
            panel1 = new Panel();
            btn_EliminarProducto = new Button();
            panel2 = new Panel();
            btn_CerrarProducto = new Button();
            pictureBox1Producto = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Producto).BeginInit();
            SuspendLayout();
            // 
            // btn_NuevoProducto
            // 
            btn_NuevoProducto.Image = Properties.Resources.NuevoArchivo;
            btn_NuevoProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NuevoProducto.Location = new Point(20, 10);
            btn_NuevoProducto.Name = "btn_NuevoProducto";
            btn_NuevoProducto.Size = new Size(88, 30);
            btn_NuevoProducto.TabIndex = 0;
            btn_NuevoProducto.Text = "      Nuevo";
            btn_NuevoProducto.UseVisualStyleBackColor = true;
            btn_NuevoProducto.Click += btn_nuevo_Click;
            // 
            // btn_GuardarProducto
            // 
            btn_GuardarProducto.Image = Properties.Resources.GuardarArchivo;
            btn_GuardarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GuardarProducto.Location = new Point(136, 10);
            btn_GuardarProducto.Name = "btn_GuardarProducto";
            btn_GuardarProducto.Size = new Size(88, 30);
            btn_GuardarProducto.TabIndex = 1;
            btn_GuardarProducto.Text = "      Guardar";
            btn_GuardarProducto.UseVisualStyleBackColor = true;
            btn_GuardarProducto.Click += btn_guardar_Click;
            // 
            // btn_CancelarProducto
            // 
            btn_CancelarProducto.Image = Properties.Resources.CancelarArchivo;
            btn_CancelarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CancelarProducto.Location = new Point(365, 10);
            btn_CancelarProducto.Name = "btn_CancelarProducto";
            btn_CancelarProducto.Size = new Size(88, 30);
            btn_CancelarProducto.TabIndex = 2;
            btn_CancelarProducto.Text = "      Cancelar";
            btn_CancelarProducto.UseVisualStyleBackColor = true;
            // 
            // label1Producto
            // 
            label1Producto.AutoSize = true;
            label1Producto.Location = new Point(43, 76);
            label1Producto.Name = "label1Producto";
            label1Producto.Size = new Size(18, 15);
            label1Producto.TabIndex = 3;
            label1Producto.Text = "ID";
            // 
            // txt_IDProducto
            // 
            txt_IDProducto.Location = new Point(171, 74);
            txt_IDProducto.Name = "txt_IDProducto";
            txt_IDProducto.Size = new Size(100, 23);
            txt_IDProducto.TabIndex = 4;
            // 
            // label2Producto
            // 
            label2Producto.AutoSize = true;
            label2Producto.Location = new Point(43, 110);
            label2Producto.Name = "label2Producto";
            label2Producto.Size = new Size(46, 15);
            label2Producto.TabIndex = 5;
            label2Producto.Text = "Codigo";
            // 
            // label3Producto
            // 
            label3Producto.AutoSize = true;
            label3Producto.Location = new Point(43, 153);
            label3Producto.Name = "label3Producto";
            label3Producto.Size = new Size(51, 15);
            label3Producto.TabIndex = 6;
            label3Producto.Text = "Nombre";
            // 
            // label4Producto
            // 
            label4Producto.AutoSize = true;
            label4Producto.Location = new Point(43, 188);
            label4Producto.Name = "label4Producto";
            label4Producto.Size = new Size(69, 15);
            label4Producto.TabIndex = 7;
            label4Producto.Text = "Descripcion";
            // 
            // label5Producto
            // 
            label5Producto.AutoSize = true;
            label5Producto.Location = new Point(43, 219);
            label5Producto.Name = "label5Producto";
            label5Producto.Size = new Size(104, 15);
            label5Producto.TabIndex = 8;
            label5Producto.Text = "Unidad de medida";
            // 
            // label6Producto
            // 
            label6Producto.AutoSize = true;
            label6Producto.Location = new Point(43, 289);
            label6Producto.Name = "label6Producto";
            label6Producto.Size = new Size(38, 15);
            label6Producto.TabIndex = 9;
            label6Producto.Text = "Costo";
            // 
            // label7Producto
            // 
            label7Producto.AutoSize = true;
            label7Producto.Location = new Point(43, 254);
            label7Producto.Name = "label7Producto";
            label7Producto.Size = new Size(60, 15);
            label7Producto.TabIndex = 10;
            label7Producto.Text = "Ubicacion";
            // 
            // label8Producto
            // 
            label8Producto.AutoSize = true;
            label8Producto.Location = new Point(43, 322);
            label8Producto.Name = "label8Producto";
            label8Producto.Size = new Size(36, 15);
            label8Producto.TabIndex = 11;
            label8Producto.Text = "Venta";
            // 
            // txt_CodigoProducto
            // 
            txt_CodigoProducto.Location = new Point(171, 108);
            txt_CodigoProducto.Name = "txt_CodigoProducto";
            txt_CodigoProducto.Size = new Size(232, 23);
            txt_CodigoProducto.TabIndex = 12;
            // 
            // txt_NombreProducto
            // 
            txt_NombreProducto.Location = new Point(171, 148);
            txt_NombreProducto.Name = "txt_NombreProducto";
            txt_NombreProducto.Size = new Size(232, 23);
            txt_NombreProducto.TabIndex = 13;
            // 
            // txt_DescripcionProducto
            // 
            txt_DescripcionProducto.Location = new Point(171, 183);
            txt_DescripcionProducto.Name = "txt_DescripcionProducto";
            txt_DescripcionProducto.Size = new Size(232, 23);
            txt_DescripcionProducto.TabIndex = 14;
            // 
            // txt_CostoProducto
            // 
            txt_CostoProducto.Location = new Point(171, 284);
            txt_CostoProducto.Name = "txt_CostoProducto";
            txt_CostoProducto.Size = new Size(232, 23);
            txt_CostoProducto.TabIndex = 17;
            // 
            // txt_VentaProducto
            // 
            txt_VentaProducto.Location = new Point(171, 318);
            txt_VentaProducto.Name = "txt_VentaProducto";
            txt_VentaProducto.Size = new Size(232, 23);
            txt_VentaProducto.TabIndex = 18;
            // 
            // cbx_UnidadProducto
            // 
            cbx_UnidadProducto.FormattingEnabled = true;
            cbx_UnidadProducto.Location = new Point(171, 218);
            cbx_UnidadProducto.Name = "cbx_UnidadProducto";
            cbx_UnidadProducto.Size = new Size(134, 23);
            cbx_UnidadProducto.TabIndex = 19;
            // 
            // cbx_UbicacionProducto
            // 
            cbx_UbicacionProducto.FormattingEnabled = true;
            cbx_UbicacionProducto.Location = new Point(171, 248);
            cbx_UbicacionProducto.Name = "cbx_UbicacionProducto";
            cbx_UbicacionProducto.Size = new Size(134, 23);
            cbx_UbicacionProducto.TabIndex = 20;
            // 
            // label9Producto
            // 
            label9Producto.AutoSize = true;
            label9Producto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9Producto.ForeColor = Color.LightCyan;
            label9Producto.Location = new Point(99, 16);
            label9Producto.Name = "label9Producto";
            label9Producto.Size = new Size(216, 25);
            label9Producto.TabIndex = 21;
            label9Producto.Text = "Catalogo de productos";
            // 
            // btn_BuscarProducto
            // 
            btn_BuscarProducto.Image = Properties.Resources.Buscar;
            btn_BuscarProducto.Location = new Point(276, 74);
            btn_BuscarProducto.Name = "btn_BuscarProducto";
            btn_BuscarProducto.Size = new Size(28, 23);
            btn_BuscarProducto.TabIndex = 22;
            btn_BuscarProducto.UseVisualStyleBackColor = true;
            btn_BuscarProducto.Click += btn_Buscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btn_EliminarProducto);
            panel1.Controls.Add(btn_NuevoProducto);
            panel1.Controls.Add(btn_CancelarProducto);
            panel1.Controls.Add(btn_GuardarProducto);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 23;
            // 
            // btn_EliminarProducto
            // 
            btn_EliminarProducto.Image = Properties.Resources.EliminarArchivo;
            btn_EliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EliminarProducto.Location = new Point(249, 10);
            btn_EliminarProducto.Name = "btn_EliminarProducto";
            btn_EliminarProducto.Size = new Size(88, 30);
            btn_EliminarProducto.TabIndex = 3;
            btn_EliminarProducto.Text = "      Eliminar";
            btn_EliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btn_EliminarProducto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(btn_CerrarProducto);
            panel2.Controls.Add(pictureBox1Producto);
            panel2.Controls.Add(label9Producto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 24;
            // 
            // btn_CerrarProducto
            // 
            btn_CerrarProducto.Image = Properties.Resources.CerrarVentana;
            btn_CerrarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarProducto.Location = new Point(705, 16);
            btn_CerrarProducto.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarProducto.Name = "btn_CerrarProducto";
            btn_CerrarProducto.Size = new Size(83, 22);
            btn_CerrarProducto.TabIndex = 23;
            btn_CerrarProducto.Text = "        Cerrar";
            btn_CerrarProducto.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarProducto.UseVisualStyleBackColor = true;
            btn_CerrarProducto.Click += btn_CerrarCP_Click;
            // 
            // pictureBox1Producto
            // 
            pictureBox1Producto.Image = Properties.Resources.CatalogoProductos;
            pictureBox1Producto.Location = new Point(52, 9);
            pictureBox1Producto.Margin = new Padding(3, 2, 3, 2);
            pictureBox1Producto.Name = "pictureBox1Producto";
            pictureBox1Producto.Size = new Size(42, 36);
            pictureBox1Producto.TabIndex = 22;
            pictureBox1Producto.TabStop = false;
            // 
            // frm_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_BuscarProducto);
            Controls.Add(cbx_UbicacionProducto);
            Controls.Add(cbx_UnidadProducto);
            Controls.Add(txt_VentaProducto);
            Controls.Add(txt_CostoProducto);
            Controls.Add(txt_DescripcionProducto);
            Controls.Add(txt_NombreProducto);
            Controls.Add(txt_CodigoProducto);
            Controls.Add(label8Producto);
            Controls.Add(label7Producto);
            Controls.Add(label6Producto);
            Controls.Add(label5Producto);
            Controls.Add(label4Producto);
            Controls.Add(label3Producto);
            Controls.Add(label2Producto);
            Controls.Add(txt_IDProducto);
            Controls.Add(label1Producto);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1Producto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_NuevoProducto;
        private Button btn_GuardarProducto;
        private Button btn_CancelarProducto;
        private Label label1Producto;
        private TextBox txt_IDProducto;
        private Label label2Producto;
        private Label label3Producto;
        private Label label4Producto;
        private Label label5Producto;
        private Label label6Producto;
        private Label label7Producto;
        private Label label8Producto;
        private TextBox txt_CodigoProducto;
        private TextBox txt_NombreProducto;
        private TextBox txt_DescripcionProducto;
        private TextBox txt_CostoProducto;
        private TextBox txt_VentaProducto;
        private ComboBox cbx_UnidadProducto;
        private ComboBox cbx_UbicacionProducto;
        private Label label9Producto;
        private Button btn_BuscarProducto;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1Producto;
        private Button btn_CerrarProducto;
        private Button btn_EliminarProducto;
    }
}