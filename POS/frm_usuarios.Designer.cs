namespace POS
{
    partial class frm_usuarios
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_eliminar = new Button();
            btn_agregar = new Button();
            txt_direccion = new TextBox();
            txt_correo = new TextBox();
            txt_apellidoM = new TextBox();
            txt_apellidoP = new TextBox();
            txt_nombre = new TextBox();
            panel1 = new Panel();
            picturebox_prueba = new PictureBox();
            USUARIOS = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(7, 415);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 10;
            label5.Text = "* Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(7, 351);
            label6.Name = "label6";
            label6.Size = new Size(121, 38);
            label6.TabIndex = 9;
            label6.Text = "* Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F);
            label7.Location = new Point(7, 290);
            label7.Name = "label7";
            label7.Size = new Size(252, 38);
            label7.TabIndex = 8;
            label7.Text = "* Apellido Materno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F);
            label8.Location = new Point(7, 214);
            label8.Name = "label8";
            label8.Size = new Size(242, 38);
            label8.TabIndex = 7;
            label8.Text = "* Apellido Paterno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F);
            label9.Location = new Point(7, 143);
            label9.Name = "label9";
            label9.Size = new Size(139, 38);
            label9.TabIndex = 6;
            label9.Text = "* Nombre";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(717, 290);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 64);
            btn_eliminar.TabIndex = 19;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(717, 154);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(153, 64);
            btn_agregar.TabIndex = 18;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(275, 437);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(289, 27);
            txt_direccion.TabIndex = 17;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(275, 373);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(289, 27);
            txt_correo.TabIndex = 16;
            // 
            // txt_apellidoM
            // 
            txt_apellidoM.Location = new Point(275, 312);
            txt_apellidoM.Name = "txt_apellidoM";
            txt_apellidoM.Size = new Size(289, 27);
            txt_apellidoM.TabIndex = 15;
            // 
            // txt_apellidoP
            // 
            txt_apellidoP.Location = new Point(275, 236);
            txt_apellidoP.Name = "txt_apellidoP";
            txt_apellidoP.Size = new Size(289, 27);
            txt_apellidoP.TabIndex = 14;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(275, 154);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(289, 27);
            txt_nombre.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picturebox_prueba);
            panel1.Controls.Add(USUARIOS);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 124);
            panel1.TabIndex = 20;
            // 
            // picturebox_prueba
            // 
            picturebox_prueba.BackColor = Color.SlateGray;
            picturebox_prueba.Image = Properties.Resources.icons8_clientes_100;
            picturebox_prueba.Location = new Point(624, 13);
            picturebox_prueba.Name = "picturebox_prueba";
            picturebox_prueba.Size = new Size(100, 95);
            picturebox_prueba.TabIndex = 1;
            picturebox_prueba.TabStop = false;
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("Myanmar Text", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.ForeColor = SystemColors.ButtonFace;
            USUARIOS.Location = new Point(360, 0);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(214, 66);
            USUARIOS.TabIndex = 0;
            USUARIOS.Text = "USUARIOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Image = Properties.Resources.icons8_clientes_100;
            pictureBox1.Location = new Point(217, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 95);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frm_usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 530);
            Controls.Add(panel1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(txt_direccion);
            Controls.Add(txt_correo);
            Controls.Add(txt_apellidoM);
            Controls.Add(txt_apellidoP);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "frm_usuarios";
            Text = "frm_usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btn_eliminar;
        private Button btn_agregar;
        private TextBox txt_direccion;
        private TextBox txt_correo;
        private TextBox txt_apellidoM;
        private TextBox txt_apellidoP;
        private TextBox txt_nombre;
        private Panel panel1;
        private PictureBox picturebox_prueba;
        private Label USUARIOS;
        private PictureBox pictureBox1;
    }
}