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
            pictureBox1 = new PictureBox();
            btn_ingresar = new Button();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox4);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 388);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_30;
            pictureBox1.Location = new Point(75, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.DarkGray;
            btn_ingresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.Location = new Point(512, 164);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(105, 50);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(236, 204);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(223, 23);
            txt_password.TabIndex = 3;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(236, 154);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(223, 23);
            txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 199);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 152);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_candado_30;
            pictureBox2.Location = new Point(75, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 34);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 25);
            label3.Name = "label3";
            label3.Size = new Size(254, 32);
            label3.TabIndex = 7;
            label3.Text = "--Acceso al sistema--";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_camisa_50;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 50);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_pent_50;
            pictureBox4.Location = new Point(604, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 50);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(668, 388);
            this.ControlBox = false;
            this.Controls.Add(panel1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            this.ResumeLayout(false);
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label3;
    }
}
