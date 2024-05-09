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
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_ingresar = new Button();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_ingresar);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 517);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 48);
            label3.Name = "label3";
            label3.Size = new Size(309, 41);
            label3.TabIndex = 7;
            label3.Text = "--Acceso al sistema--";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_candado_30;
            pictureBox2.Location = new Point(131, 231);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_30;
            pictureBox1.Location = new Point(131, 178);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.DarkGray;
            btn_ingresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.Image = Properties.Resources.Entrar;
            btn_ingresar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ingresar.Location = new Point(311, 298);
            btn_ingresar.Margin = new Padding(3, 4, 3, 4);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(132, 67);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "       Ingresar";
            btn_ingresar.TextAlign = ContentAlignment.MiddleRight;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(337, 238);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(282, 27);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(337, 181);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(282, 27);
            txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 238);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingrese contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 180);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese usuario:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LogoPantalon;
            pictureBox4.Location = new Point(549, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoCamisa;
            pictureBox3.Location = new Point(158, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 517);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frm_login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Label label2;
        private Label label1;
        private Button btn_ingresar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
