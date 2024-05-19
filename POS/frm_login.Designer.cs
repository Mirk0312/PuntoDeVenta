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
            btn_cerrarLogin = new Button();
            pictureBox3Login = new PictureBox();
            label3 = new Label();
            pictureBox2Login = new PictureBox();
            pictureBox1Login = new PictureBox();
            btn_IngresarLogin = new Button();
            txt_passwordLogin = new TextBox();
            txt_UsuarioLogin = new TextBox();
            label2Login = new Label();
            label1Login = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3Login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Login).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btn_cerrarLogin);
            panel1.Controls.Add(pictureBox3Login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2Login);
            panel1.Controls.Add(pictureBox1Login);
            panel1.Controls.Add(btn_IngresarLogin);
            panel1.Controls.Add(txt_passwordLogin);
            panel1.Controls.Add(txt_UsuarioLogin);
            panel1.Controls.Add(label2Login);
            panel1.Controls.Add(label1Login);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 517);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_cerrarLogin
            // 
            btn_cerrarLogin.BackColor = Color.Gray;
            btn_cerrarLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrarLogin.ForeColor = SystemColors.ControlLightLight;
            btn_cerrarLogin.Image = Properties.Resources.CerrarVentana;
            btn_cerrarLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrarLogin.Location = new Point(627, 12);
            btn_cerrarLogin.Name = "btn_cerrarLogin";
            btn_cerrarLogin.Size = new Size(115, 44);
            btn_cerrarLogin.TabIndex = 11;
            btn_cerrarLogin.Text = "     Cerrar";
            btn_cerrarLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox3Login
            // 
            pictureBox3Login.Image = Properties.Resources.STARK50_removebg_preview;
            pictureBox3Login.Location = new Point(298, 48);
            pictureBox3Login.Name = "pictureBox3Login";
            pictureBox3Login.Size = new Size(170, 167);
            pictureBox3Login.TabIndex = 10;
            pictureBox3Login.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 48);
            label3.Name = "label3";
            label3.Size = new Size(0, 41);
            label3.TabIndex = 7;
            // 
            // pictureBox2Login
            // 
            pictureBox2Login.Image = Properties.Resources.icons8_candado_30;
            pictureBox2Login.Location = new Point(58, 273);
            pictureBox2Login.Margin = new Padding(3, 4, 3, 4);
            pictureBox2Login.Name = "pictureBox2Login";
            pictureBox2Login.Size = new Size(34, 40);
            pictureBox2Login.TabIndex = 6;
            pictureBox2Login.TabStop = false;
            // 
            // pictureBox1Login
            // 
            pictureBox1Login.Image = Properties.Resources.icons8_usuario_30;
            pictureBox1Login.Location = new Point(58, 225);
            pictureBox1Login.Margin = new Padding(3, 4, 3, 4);
            pictureBox1Login.Name = "pictureBox1Login";
            pictureBox1Login.Size = new Size(34, 40);
            pictureBox1Login.TabIndex = 5;
            pictureBox1Login.TabStop = false;
            // 
            // btn_IngresarLogin
            // 
            btn_IngresarLogin.BackColor = Color.DarkGray;
            btn_IngresarLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_IngresarLogin.Image = Properties.Resources.Entrar;
            btn_IngresarLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IngresarLogin.Location = new Point(312, 321);
            btn_IngresarLogin.Margin = new Padding(3, 4, 3, 4);
            btn_IngresarLogin.Name = "btn_IngresarLogin";
            btn_IngresarLogin.Size = new Size(133, 67);
            btn_IngresarLogin.TabIndex = 4;
            btn_IngresarLogin.Text = "       Ingresar";
            btn_IngresarLogin.TextAlign = ContentAlignment.MiddleRight;
            btn_IngresarLogin.UseVisualStyleBackColor = false;
            btn_IngresarLogin.Click += btn_ingresar_Click;
            // 
            // txt_passwordLogin
            // 
            txt_passwordLogin.Location = new Point(287, 277);
            txt_passwordLogin.Margin = new Padding(3, 4, 3, 4);
            txt_passwordLogin.Name = "txt_passwordLogin";
            txt_passwordLogin.PasswordChar = '*';
            txt_passwordLogin.Size = new Size(266, 27);
            txt_passwordLogin.TabIndex = 3;
            // 
            // txt_UsuarioLogin
            // 
            txt_UsuarioLogin.Location = new Point(287, 231);
            txt_UsuarioLogin.Margin = new Padding(3, 4, 3, 4);
            txt_UsuarioLogin.Name = "txt_UsuarioLogin";
            txt_UsuarioLogin.Size = new Size(266, 27);
            txt_UsuarioLogin.TabIndex = 2;
            // 
            // label2Login
            // 
            label2Login.AutoSize = true;
            label2Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2Login.Location = new Point(94, 280);
            label2Login.Name = "label2Login";
            label2Login.Size = new Size(196, 28);
            label2Login.TabIndex = 1;
            label2Login.Text = "Ingrese contraseña:";
            // 
            // label1Login
            // 
            label1Login.AutoSize = true;
            label1Login.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Login.Location = new Point(96, 235);
            label1Login.Name = "label1Login";
            label1Login.Size = new Size(148, 25);
            label1Login.TabIndex = 0;
            label1Login.Text = "Ingrese usuario:";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3Login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Login).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Login).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_passwordLogin;
        private TextBox txt_UsuarioLogin;
        private Label label2Login;
        private Label label1Login;
        private Button btn_IngresarLogin;
        private PictureBox pictureBox1Login;
        private PictureBox pictureBox2Login;
        private Label label3;
        private PictureBox pictureBox3Login;
        private Button btn_cerrarLogin;
    }
}
