namespace POS
{
    partial class frm_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            btn_cerrarSesion = new Button();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_inicio = new Button();
            btn_usuario = new Button();
            btn_catalogos = new Button();
            btn_proveedor = new Button();
            btn_configuracion = new Button();
            btn_productos = new Button();
            btn_clientes = new Button();
            btn_inventario = new Button();
            btn_ventas = new Button();
            btn_operaciones = new Button();
            panel4 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            toolTip1 = new ToolTip(components);
            btn_cerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel_principal = new Panel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btn_cerrarSesion);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btn_inicio);
            panel2.Controls.Add(btn_usuario);
            panel2.Controls.Add(btn_catalogos);
            panel2.Controls.Add(btn_proveedor);
            panel2.Controls.Add(btn_configuracion);
            panel2.Controls.Add(btn_productos);
            panel2.Controls.Add(btn_clientes);
            panel2.Controls.Add(btn_inventario);
            panel2.Controls.Add(btn_ventas);
            panel2.Controls.Add(btn_operaciones);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 763);
            panel2.TabIndex = 1;
            // 
            // btn_cerrarSesion
            // 
            btn_cerrarSesion.BackColor = Color.LightGray;
            btn_cerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrarSesion.Location = new Point(3, 672);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Size = new Size(154, 59);
            btn_cerrarSesion.TabIndex = 14;
            btn_cerrarSesion.Text = "Cerrar Sesion";
            btn_cerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 160);
            panel5.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.icons8_pent_50;
            pictureBox4.Location = new Point(85, 45);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 80);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.icons8_camisa_50;
            pictureBox3.Location = new Point(14, 45);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 80);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.LightGray;
            btn_inicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio.Location = new Point(3, 167);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(153, 63);
            btn_inicio.TabIndex = 8;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // btn_usuario
            // 
            btn_usuario.BackColor = Color.DarkGray;
            btn_usuario.Location = new Point(14, 622);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(127, 29);
            btn_usuario.TabIndex = 13;
            btn_usuario.Text = "Usuarios";
            btn_usuario.UseVisualStyleBackColor = false;
            // 
            // btn_catalogos
            // 
            btn_catalogos.BackColor = Color.LightGray;
            btn_catalogos.Location = new Point(3, 243);
            btn_catalogos.Name = "btn_catalogos";
            btn_catalogos.Size = new Size(153, 39);
            btn_catalogos.TabIndex = 6;
            btn_catalogos.Text = "Catalogos";
            btn_catalogos.UseVisualStyleBackColor = false;
            // 
            // btn_proveedor
            // 
            btn_proveedor.BackColor = Color.DarkGray;
            btn_proveedor.Location = new Point(14, 343);
            btn_proveedor.Name = "btn_proveedor";
            btn_proveedor.Size = new Size(127, 33);
            btn_proveedor.TabIndex = 5;
            btn_proveedor.Text = "Proveedores";
            btn_proveedor.UseVisualStyleBackColor = false;
            btn_proveedor.Click += btn_proveedor_Click;
            // 
            // btn_configuracion
            // 
            btn_configuracion.BackColor = Color.LightGray;
            btn_configuracion.Location = new Point(3, 578);
            btn_configuracion.Name = "btn_configuracion";
            btn_configuracion.Size = new Size(153, 39);
            btn_configuracion.TabIndex = 12;
            btn_configuracion.Text = "Configuracion";
            btn_configuracion.UseVisualStyleBackColor = false;
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.DarkGray;
            btn_productos.Location = new Point(14, 382);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(127, 33);
            btn_productos.TabIndex = 4;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += btn_productos_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.DarkGray;
            btn_clientes.Location = new Point(14, 304);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(127, 33);
            btn_clientes.TabIndex = 7;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_inventario
            // 
            btn_inventario.BackColor = Color.DarkGray;
            btn_inventario.Location = new Point(14, 519);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(127, 33);
            btn_inventario.TabIndex = 11;
            btn_inventario.Text = "Inventario";
            btn_inventario.UseVisualStyleBackColor = false;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.DarkGray;
            btn_ventas.Location = new Point(14, 480);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(127, 33);
            btn_ventas.TabIndex = 10;
            btn_ventas.Text = "Ventas";
            btn_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_operaciones
            // 
            btn_operaciones.BackColor = Color.LightGray;
            btn_operaciones.Location = new Point(3, 436);
            btn_operaciones.Name = "btn_operaciones";
            btn_operaciones.Size = new Size(153, 39);
            btn_operaciones.TabIndex = 9;
            btn_operaciones.Text = "Operaciones";
            btn_operaciones.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(toolStrip1);
            panel4.Location = new Point(163, 672);
            panel4.Name = "panel4";
            panel4.Size = new Size(929, 91);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripLabel4, toolStripLabel5 });
            toolStrip1.Location = new Point(0, 66);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(67, 22);
            toolStripLabel1.Text = "Usuario:";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(51, 22);
            toolStripLabel2.Text = "xxxxxx";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(53, 22);
            toolStripLabel3.Text = "Fecha:";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(101, 22);
            toolStripLabel4.Text = "DD/MM/YYYY";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(65, 22);
            toolStripLabel5.Text = "Version:";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.Red;
            btn_cerrar.Location = new Point(984, 13);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(94, 44);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(631, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(631, 73);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 3;
            label2.Text = "Permiso:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_cerrar);
            panel1.Location = new Point(163, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 160);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(735, 73);
            label5.Name = "label5";
            label5.Size = new Size(102, 31);
            label5.TabIndex = 5;
            label5.Text = "xxxxxxxx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(735, 15);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 4;
            label4.Text = "xxxxxxxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Book Antiqua", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 20);
            label3.Name = "label3";
            label3.Size = new Size(336, 98);
            label3.TabIndex = 0;
            label3.Text = "Mclaren";
            // 
            // panel_principal
            // 
            panel_principal.Location = new Point(169, 167);
            panel_principal.Margin = new Padding(3, 4, 3, 4);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(910, 499);
            panel_principal.TabIndex = 4;
            panel_principal.Paint += panel_principal_Paint;
            // 
            // frm_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1093, 763);
            Controls.Add(panel_principal);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_principal";
            Load += frmprincipal_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_inicio;
        private Button btn_clientes;
        private Button btn_catalogos;
        private Button btn_proveedor;
        private Button btn_productos;
        private Panel panel4;

        private ToolStrip toolStrip1;
        private ToolTip toolTip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel5;
        private Button btn_cerrarSesion;
        private Button btn_usuario;
        private Button btn_configuracion;
        private Button btn_inventario;
        private Button btn_ventas;
        private Button btn_operaciones;
        private Panel panel5;
        private Button btn_cerrar;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel_principal;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label4;
    }
}
