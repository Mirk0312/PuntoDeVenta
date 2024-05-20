namespace POS
{
    partial class frm_clientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_idCliente = new TextBox();
            txt_nombre = new TextBox();
            txt_rfc = new TextBox();
            txt_correo = new TextBox();
            txt_telefono = new TextBox();
            txt_clave = new TextBox();
            btn_guardar = new Button();
            btn_nuevo = new Button();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(24, 72);
            label1.Name = "label1";
            label1.Size = new Size(36, 31);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(26, 132);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(26, 281);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(24, 408);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(26, 191);
            label5.Name = "label5";
            label5.Size = new Size(53, 31);
            label5.TabIndex = 4;
            label5.Text = "RFC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(26, 354);
            label6.Name = "label6";
            label6.Size = new Size(82, 31);
            label6.TabIndex = 5;
            label6.Text = "Correo";
            // 
            // txt_idCliente
            // 
            txt_idCliente.Location = new Point(253, 78);
            txt_idCliente.Name = "txt_idCliente";
            txt_idCliente.Size = new Size(192, 27);
            txt_idCliente.TabIndex = 6;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(253, 138);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(192, 27);
            txt_nombre.TabIndex = 7;
            // 
            // txt_rfc
            // 
            txt_rfc.Location = new Point(253, 207);
            txt_rfc.Name = "txt_rfc";
            txt_rfc.Size = new Size(192, 27);
            txt_rfc.TabIndex = 8;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(253, 354);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(192, 27);
            txt_correo.TabIndex = 9;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(253, 414);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(192, 27);
            txt_telefono.TabIndex = 10;
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(253, 297);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(192, 27);
            txt_clave.TabIndex = 11;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(640, 73);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(94, 29);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(640, 170);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(94, 29);
            btn_nuevo.TabIndex = 13;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(640, 281);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(94, 29);
            btn_actualizar.TabIndex = 14;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(640, 371);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 15;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(742, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 505);
            Controls.Add(button1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_nuevo);
            Controls.Add(btn_guardar);
            Controls.Add(txt_clave);
            Controls.Add(txt_telefono);
            Controls.Add(txt_correo);
            Controls.Add(txt_rfc);
            Controls.Add(txt_nombre);
            Controls.Add(txt_idCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_clientes";
            Text = "frm_clientes";
            Load += frm_clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_idCliente;
        private TextBox txt_nombre;
        private TextBox txt_rfc;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_clave;
        private Button btn_guardar;
        private Button btn_nuevo;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private Button button1;
    }
}