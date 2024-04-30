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
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            txt_ID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_codigo = new TextBox();
            txt_nombre = new TextBox();
            txt_descripcion = new TextBox();
            txt_costo = new TextBox();
            txt_venta = new TextBox();
            cbx_unidad = new ComboBox();
            cbx_ubicacion = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(445, 301);
            btn_nuevo.Margin = new Padding(3, 4, 3, 4);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(86, 31);
            btn_nuevo.TabIndex = 0;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(566, 301);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(86, 31);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(679, 301);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(86, 31);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 83);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(144, 79);
            txt_ID.Margin = new Padding(3, 4, 3, 4);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(114, 27);
            txt_ID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 125);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 179);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 225);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 271);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 8;
            label5.Text = "Unidad de medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 360);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 9;
            label6.Text = "Costo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 312);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Ubicacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 405);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 11;
            label8.Text = "Venta";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(144, 125);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(114, 27);
            txt_codigo.TabIndex = 12;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(144, 179);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(114, 27);
            txt_nombre.TabIndex = 13;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(144, 225);
            txt_descripcion.Margin = new Padding(3, 4, 3, 4);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(114, 27);
            txt_descripcion.TabIndex = 14;
            // 
            // txt_costo
            // 
            txt_costo.Location = new Point(144, 360);
            txt_costo.Margin = new Padding(3, 4, 3, 4);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(114, 27);
            txt_costo.TabIndex = 17;
            // 
            // txt_venta
            // 
            txt_venta.Location = new Point(144, 405);
            txt_venta.Margin = new Padding(3, 4, 3, 4);
            txt_venta.Name = "txt_venta";
            txt_venta.Size = new Size(114, 27);
            txt_venta.TabIndex = 18;
            // 
            // cbx_unidad
            // 
            cbx_unidad.FormattingEnabled = true;
            cbx_unidad.Location = new Point(144, 271);
            cbx_unidad.Margin = new Padding(3, 4, 3, 4);
            cbx_unidad.Name = "cbx_unidad";
            cbx_unidad.Size = new Size(114, 28);
            cbx_unidad.TabIndex = 19;
            // 
            // cbx_ubicacion
            // 
            cbx_ubicacion.FormattingEnabled = true;
            cbx_ubicacion.Location = new Point(144, 312);
            cbx_ubicacion.Margin = new Padding(3, 4, 3, 4);
            cbx_ubicacion.Name = "cbx_ubicacion";
            cbx_ubicacion.Size = new Size(114, 28);
            cbx_ubicacion.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(478, 155);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 21;
            label9.Text = "Frm de productos";
            // 
            // frm_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label9);
            Controls.Add(cbx_ubicacion);
            Controls.Add(cbx_unidad);
            Controls.Add(txt_venta);
            Controls.Add(txt_costo);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_nombre);
            Controls.Add(txt_codigo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_ID);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frm_productos";
            Text = "frm_productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Label label1;
        private TextBox txt_ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_codigo;
        private TextBox txt_nombre;
        private TextBox txt_descripcion;
        private TextBox txt_costo;
        private TextBox txt_venta;
        private ComboBox cbx_unidad;
        private ComboBox cbx_ubicacion;
        private Label label9;
    }
}