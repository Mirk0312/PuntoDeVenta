﻿namespace POS
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
            txt_venta = new TextBox();
            txt_costo = new TextBox();
            txt_nombre = new TextBox();
            txt_codigo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_ID = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btn_nuevo = new Button();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel2 = new Panel();
            btn_CerrarCP = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Image = Properties.Resources.Buscar;
            btn_Buscar.Location = new Point(275, 112);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(32, 31);
            btn_Buscar.TabIndex = 39;
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_venta
            // 
            txt_venta.Location = new Point(155, 323);
            txt_venta.Margin = new Padding(3, 4, 3, 4);
            txt_venta.Name = "txt_venta";
            txt_venta.Size = new Size(265, 27);
            txt_venta.TabIndex = 36;
            // 
            // txt_costo
            // 
            txt_costo.Location = new Point(155, 384);
            txt_costo.Margin = new Padding(3, 4, 3, 4);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(265, 27);
            txt_costo.TabIndex = 35;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(155, 213);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(265, 27);
            txt_nombre.TabIndex = 33;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(155, 159);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(265, 27);
            txt_codigo.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 384);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 31;
            label8.Text = "Venta del producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 324);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 30;
            label7.Text = "Costo del producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 270);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 29;
            label6.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 27;
            label4.Text = "Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 216);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 26;
            label3.Text = "Encargado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 25;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(155, 113);
            txt_ID.Margin = new Padding(3, 4, 3, 4);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(114, 27);
            txt_ID.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 120);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 23;
            label9.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_nuevo);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_guardar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 534);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 66);
            panel1.TabIndex = 40;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.EliminarArchivo;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(286, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "      Eliminar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Image = Properties.Resources.NuevoArchivo;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.Location = new Point(23, 13);
            btn_nuevo.Margin = new Padding(3, 4, 3, 4);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(100, 40);
            btn_nuevo.TabIndex = 0;
            btn_nuevo.Text = "      Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Image = Properties.Resources.CancelarArchivo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.Location = new Point(420, 13);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(100, 40);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "      Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            btn_guardar.Image = Properties.Resources.GuardarArchivo;
            btn_guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_guardar.Location = new Point(155, 13);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(100, 40);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "      Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btn_CerrarCP);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 75);
            panel2.TabIndex = 41;
            // 
            // btn_CerrarCP
            // 
            btn_CerrarCP.Image = Properties.Resources.CerrarVentana;
            btn_CerrarCP.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarCP.Location = new Point(808, 25);
            btn_CerrarCP.Name = "btn_CerrarCP";
            btn_CerrarCP.Size = new Size(95, 30);
            btn_CerrarCP.TabIndex = 23;
            btn_CerrarCP.Text = "        Cerrar";
            btn_CerrarCP.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarCP.UseVisualStyleBackColor = true;
            btn_CerrarCP.Click += btn_CerrarCP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CatalogoProveedor;
            pictureBox1.Location = new Point(49, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 21);
            label1.Name = "label1";
            label1.Size = new Size(280, 31);
            label1.TabIndex = 21;
            label1.Text = "Catalogo de proveedores";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 267);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 42;
            // 
            // frm_proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_venta);
            Controls.Add(txt_costo);
            Controls.Add(txt_nombre);
            Controls.Add(txt_codigo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_ID);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txt_venta;
        private TextBox txt_costo;
        private TextBox txt_nombre;
        private TextBox txt_codigo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_ID;
        private Label label9;
        private Panel panel1;
        private Button btn_nuevo;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Panel panel2;
        private Button btn_CerrarCP;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
    }
}