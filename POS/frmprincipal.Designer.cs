﻿namespace POS
{
    partial class frmprincipal
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
            panel2 = new Panel();
            panel3 = new Panel();
            btn_productos = new Button();
            btn_proveedor = new Button();
            btn_catalogos = new Button();
            btn_clientes = new Button();
            btn_inicio = new Button();
            btn_cerrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 146);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_inicio);
            panel2.Controls.Add(btn_clientes);
            panel2.Controls.Add(btn_catalogos);
            panel2.Controls.Add(btn_proveedor);
            panel2.Controls.Add(btn_productos);
            panel2.Location = new Point(1, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 478);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(253, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 478);
            panel3.TabIndex = 2;
            // 
            // btn_productos
            // 
            btn_productos.Location = new Point(32, 375);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(169, 85);
            btn_productos.TabIndex = 4;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_proveedor
            // 
            btn_proveedor.Location = new Point(32, 278);
            btn_proveedor.Name = "btn_proveedor";
            btn_proveedor.Size = new Size(169, 85);
            btn_proveedor.TabIndex = 5;
            btn_proveedor.Text = "Proveedores";
            btn_proveedor.UseVisualStyleBackColor = true;
            // 
            // btn_catalogos
            // 
            btn_catalogos.Location = new Point(32, 187);
            btn_catalogos.Name = "btn_catalogos";
            btn_catalogos.Size = new Size(169, 85);
            btn_catalogos.TabIndex = 6;
            btn_catalogos.Text = "Catalogos";
            btn_catalogos.UseVisualStyleBackColor = true;
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(32, 96);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(169, 85);
            btn_clientes.TabIndex = 7;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            // 
            // btn_inicio
            // 
            btn_inicio.Location = new Point(32, 3);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(169, 85);
            btn_inicio.TabIndex = 8;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(964, 11);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(94, 44);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 122);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(749, 14);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
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
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(1, 637);
            panel4.Name = "panel4";
            panel4.Size = new Size(1091, 85);
            panel4.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 729);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1081, 29);
            progressBar1.TabIndex = 4;
            // 
            // frmprincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1092, 762);
            Controls.Add(progressBar1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmprincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
