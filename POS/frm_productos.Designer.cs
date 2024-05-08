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
            btn_Buscar = new Button();
            SuspendLayout();
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(389, 226);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 23);
            btn_nuevo.TabIndex = 0;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(495, 226);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(594, 226);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 62);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(126, 59);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(100, 23);
            txt_ID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 94);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 169);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 203);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 8;
            label5.Text = "Unidad de medida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 270);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "Costo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 234);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 10;
            label7.Text = "Ubicacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 304);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 11;
            label8.Text = "Venta";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(126, 94);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(100, 23);
            txt_codigo.TabIndex = 12;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(126, 134);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 13;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(126, 169);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(100, 23);
            txt_descripcion.TabIndex = 14;
            // 
            // txt_costo
            // 
            txt_costo.Location = new Point(126, 270);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(100, 23);
            txt_costo.TabIndex = 17;
            // 
            // txt_venta
            // 
            txt_venta.Location = new Point(126, 304);
            txt_venta.Name = "txt_venta";
            txt_venta.Size = new Size(100, 23);
            txt_venta.TabIndex = 18;
            // 
            // cbx_unidad
            // 
            cbx_unidad.FormattingEnabled = true;
            cbx_unidad.Location = new Point(126, 203);
            cbx_unidad.Name = "cbx_unidad";
            cbx_unidad.Size = new Size(100, 23);
            cbx_unidad.TabIndex = 19;
            // 
            // cbx_ubicacion
            // 
            cbx_ubicacion.FormattingEnabled = true;
            cbx_ubicacion.Location = new Point(126, 234);
            cbx_ubicacion.Name = "cbx_ubicacion";
            cbx_ubicacion.Size = new Size(100, 23);
            cbx_ubicacion.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(418, 116);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 21;
            label9.Text = "Frm de productos";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(292, 65);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 22;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // frm_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Buscar);
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
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btn_Buscar;
    }
}