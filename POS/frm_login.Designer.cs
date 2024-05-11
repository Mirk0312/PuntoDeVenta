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
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_ingresar = new Button();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_cerrar = new Button();
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
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.STARK50_removebg_preview;
            pictureBox3.Location = new Point(321, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 125);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_candado_30;
            pictureBox2.Location = new Point(81, 271);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_30;
            pictureBox1.Location = new Point(81, 218);
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
            btn_ingresar.Location = new Point(321, 348);
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
            txt_password.Location = new Point(287, 278);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(282, 27);
            txt_password.TabIndex = 3;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(287, 221);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(282, 27);
            txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 278);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingrese contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 220);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese usuario:";
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Gray;
            btn_cerrar.ForeColor = SystemColors.ControlLightLight;
            btn_cerrar.Image = Properties.Resources.CerrarVentana;
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(627, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(115, 44);
            btn_cerrar.TabIndex = 11;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btn_cerrar;
    }
}
