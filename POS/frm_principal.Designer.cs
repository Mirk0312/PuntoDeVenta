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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_cerrar = new Button();
            panel2 = new Panel();
            btn_catalogos = new Button();
            btn_inicio = new Button();
            btn_clientes = new Button();
            btn_proveedor = new Button();
            btn_productos = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_cerrar);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 110);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(655, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 3;
            label2.Text = "Permiso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(655, 10);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 92);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(844, 8);
            btn_cerrar.Margin = new Padding(3, 2, 3, 2);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(82, 33);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_inicio);
            panel2.Controls.Add(btn_catalogos);
            panel2.Controls.Add(btn_clientes);
            panel2.Controls.Add(btn_proveedor);
            panel2.Controls.Add(btn_productos);
            panel2.Location = new Point(1, 115);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 358);
            panel2.TabIndex = 1;
            // 
            // btn_catalogos
            // 
            btn_catalogos.Location = new Point(28, 276);
            btn_catalogos.Margin = new Padding(3, 2, 3, 2);
            btn_catalogos.Name = "btn_catalogos";
            btn_catalogos.Size = new Size(148, 64);
            btn_catalogos.TabIndex = 6;
            btn_catalogos.Text = "Catalogos";
            btn_catalogos.UseVisualStyleBackColor = true;
            // 
            // btn_inicio
            // 
            btn_inicio.Location = new Point(28, 4);
            btn_inicio.Margin = new Padding(3, 2, 3, 2);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(148, 64);
            btn_inicio.TabIndex = 8;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = true;
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(28, 72);
            btn_clientes.Margin = new Padding(3, 2, 3, 2);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(148, 64);
            btn_clientes.TabIndex = 7;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
        

            // 
            // btn_proveedor
            // 
            btn_proveedor.Location = new Point(28, 208);
            btn_proveedor.Margin = new Padding(3, 2, 3, 2);
            btn_proveedor.Name = "btn_proveedor";
            btn_proveedor.Size = new Size(148, 64);
            btn_proveedor.TabIndex = 5;
            btn_proveedor.Text = "Proveedores";
            btn_proveedor.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            btn_productos.Location = new Point(28, 140);
            btn_productos.Margin = new Padding(3, 2, 3, 2);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(148, 64);
            btn_productos.TabIndex = 4;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = true;
          
            // 
            // panel3
            // 
            panel3.Location = new Point(221, 115);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 358);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(1, 478);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(955, 64);
            panel4.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 547);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(946, 22);
            progressBar1.TabIndex = 4;
            // 
            // frm_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(956, 572);
            Controls.Add(progressBar1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_principal";
            Load += frmprincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
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
    }
}
