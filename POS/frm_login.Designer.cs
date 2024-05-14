namespace POS
{
    partial class frm_login
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
            btn_cerrar = new Button();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_IngresarL = new Button();
            txt_passwordL = new TextBox();
            txt_UsuarioL = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_IngresarL);
            panel1.Controls.Add(txt_passwordL);
            panel1.Controls.Add(txt_UsuarioL);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 388);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Gray;
            btn_cerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = SystemColors.ControlLightLight;
            btn_cerrar.Image = Properties.Resources.CerrarVentana;
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(549, 9);
            btn_cerrar.Margin = new Padding(3, 2, 3, 2);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(101, 33);
            btn_cerrar.TabIndex = 11;
            btn_cerrar.Text = "     Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.STARK50_removebg_preview;
            pictureBox3.Location = new Point(261, 36);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 125);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_candado_30;
            pictureBox2.Location = new Point(51, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_30;
            pictureBox1.Location = new Point(51, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_IngresarL
            // 
            btn_IngresarL.BackColor = Color.DarkGray;
            btn_IngresarL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_IngresarL.Image = Properties.Resources.Entrar;
            btn_IngresarL.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IngresarL.Location = new Point(273, 241);
            btn_IngresarL.Name = "btn_IngresarL";
            btn_IngresarL.Size = new Size(116, 50);
            btn_IngresarL.TabIndex = 4;
            btn_IngresarL.Text = "       Ingresar";
            btn_IngresarL.TextAlign = ContentAlignment.MiddleRight;
            btn_IngresarL.UseVisualStyleBackColor = false;
            btn_IngresarL.Click += btn_ingresar_Click;
            // 
            // txt_passwordL
            // 
            txt_passwordL.Location = new Point(251, 208);
            txt_passwordL.Name = "txt_passwordL";
            txt_passwordL.PasswordChar = '*';
            txt_passwordL.Size = new Size(233, 23);
            txt_passwordL.TabIndex = 3;
            txt_passwordL.TextChanged += txt_password_TextChanged;
            // 
            // txt_UsuarioL
            // 
            txt_UsuarioL.Location = new Point(251, 173);
            txt_UsuarioL.Name = "txt_UsuarioL";
            txt_UsuarioL.Size = new Size(233, 23);
            txt_UsuarioL.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 210);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 176);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese usuario:";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 388);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frm_login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_passwordL;
        private TextBox txt_UsuarioL;
        private Label label2;
        private Label label1;
        private Button btn_IngresarL;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Button btn_cerrar;
    }
}
