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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_cerrar = new Button();
            panel2 = new Panel();
            btn_inicio = new Button();
            btn_clientes = new Button();
            btn_catalogos = new Button();
            btn_proveedor = new Button();
            btn_productos = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            toolStripLabel5 = new ToolStripLabel();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            panel_principal = new Panel();
            btn_operaciones = new Button();
            btn_ventas = new Button();
            btn_inventario = new Button();
            btn_configuracion = new Button();
            btn_usuario = new Button();
            btn_cerrarSesion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_cerrar);
            panel1.Location = new Point(170, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 147);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(749, 92);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 3;
            label2.Text = "Permiso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(749, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 123);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // panel2
            // 
            panel2.Controls.Add(btn_cerrarSesion);
            panel2.Controls.Add(btn_usuario);
            panel2.Controls.Add(btn_configuracion);
            panel2.Controls.Add(btn_inventario);
            panel2.Controls.Add(btn_ventas);
            panel2.Controls.Add(btn_operaciones);
            panel2.Controls.Add(btn_productos);
            panel2.Controls.Add(btn_proveedor);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_inicio);
            panel2.Controls.Add(btn_clientes);
            panel2.Controls.Add(btn_catalogos);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 629);
            panel2.TabIndex = 1;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = SystemColors.ActiveCaption;
            btn_inicio.Location = new Point(0, 152);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(169, 33);
            btn_inicio.TabIndex = 8;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(32, 230);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(104, 33);
            btn_clientes.TabIndex = 7;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_catalogos
            // 
            btn_catalogos.BackColor = SystemColors.ActiveCaption;
            btn_catalogos.Location = new Point(0, 191);
            btn_catalogos.Name = "btn_catalogos";
            btn_catalogos.Size = new Size(169, 33);
            btn_catalogos.TabIndex = 6;
            btn_catalogos.Text = "Catalogos";
            btn_catalogos.UseVisualStyleBackColor = false;
            // 
            // btn_proveedor
            // 
            btn_proveedor.Location = new Point(32, 269);
            btn_proveedor.Name = "btn_proveedor";
            btn_proveedor.Size = new Size(104, 33);
            btn_proveedor.TabIndex = 5;
            btn_proveedor.Text = "Proveedores";
            btn_proveedor.UseVisualStyleBackColor = true;
            btn_proveedor.Click += btn_proveedor_Click;
            // 
            // btn_productos
            // 
            btn_productos.Location = new Point(32, 308);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(104, 33);
            btn_productos.TabIndex = 4;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = true;
            btn_productos.Click += btn_productos_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(253, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 477);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(toolStrip1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 636);
            panel4.Name = "panel4";
            panel4.Size = new Size(1093, 127);
            panel4.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.PaleTurquoise;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripLabel4, toolStripLabel5 });
            toolStrip1.Location = new Point(0, 102);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1093, 25);
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
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 729);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1081, 29);
            progressBar1.TabIndex = 4;
            // 
            // panel_principal
            // 
            panel_principal.Location = new Point(170, 153);
            panel_principal.Margin = new Padding(3, 4, 3, 4);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(923, 477);
            panel_principal.TabIndex = 0;
            // 
            // btn_operaciones
            // 
            btn_operaciones.BackColor = SystemColors.ActiveCaption;
            btn_operaciones.Location = new Point(0, 347);
            btn_operaciones.Name = "btn_operaciones";
            btn_operaciones.Size = new Size(169, 33);
            btn_operaciones.TabIndex = 9;
            btn_operaciones.Text = "Operaciones";
            btn_operaciones.UseVisualStyleBackColor = false;
            // 
            // btn_ventas
            // 
            btn_ventas.Location = new Point(32, 386);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(104, 33);
            btn_ventas.TabIndex = 10;
            btn_ventas.Text = "Ventas";
            btn_ventas.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            btn_inventario.Location = new Point(32, 425);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(104, 33);
            btn_inventario.TabIndex = 11;
            btn_inventario.Text = "Inventario";
            btn_inventario.UseVisualStyleBackColor = true;
            // 
            // btn_configuracion
            // 
            btn_configuracion.BackColor = SystemColors.ActiveCaption;
            btn_configuracion.Location = new Point(3, 464);
            btn_configuracion.Name = "btn_configuracion";
            btn_configuracion.Size = new Size(169, 33);
            btn_configuracion.TabIndex = 12;
            btn_configuracion.Text = "Configuracion";
            btn_configuracion.UseVisualStyleBackColor = false;
            // 
            // btn_usuario
            // 
            btn_usuario.Location = new Point(32, 503);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(104, 33);
            btn_usuario.TabIndex = 13;
            btn_usuario.Text = "Usuarios";
            btn_usuario.UseVisualStyleBackColor = true;
            // 
            // btn_cerrarSesion
            // 
            btn_cerrarSesion.BackColor = SystemColors.ActiveCaption;
            btn_cerrarSesion.Location = new Point(0, 542);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Size = new Size(169, 51);
            btn_cerrarSesion.TabIndex = 14;
            btn_cerrarSesion.Text = "Cerrar Sesion";
            btn_cerrarSesion.UseVisualStyleBackColor = false;
            // 
            // frm_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1093, 763);
            Controls.Add(panel_principal);
            Controls.Add(progressBar1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_principal";
            Load += frmprincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_inicio;
        private Button btn_clientes;
        private Button btn_catalogos;
        private Button btn_proveedor;
        private Button btn_productos;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_cerrar;
        private Panel panel4;
        private ProgressBar progressBar1;

        private ToolStrip toolStrip1;
        private ToolTip toolTip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripLabel toolStripLabel5;
        private Panel panel_principal;
        private Button btn_cerrarSesion;
        private Button btn_usuario;
        private Button btn_configuracion;
        private Button btn_inventario;
        private Button btn_ventas;
        private Button btn_operaciones;
    }
}
