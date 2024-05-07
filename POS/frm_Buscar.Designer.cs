namespace POS
{
    partial class frm_Buscar
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
            panel1 = new Panel();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgV_datos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgV_datos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(582, 51);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(212, 46);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(317, 23);
            txt_buscar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Dato a buscar:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 7);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "LABEL DE PRUEBA";
            // 
            // dgV_datos
            // 
            dgV_datos.AllowUserToAddRows = false;
            dgV_datos.AllowUserToDeleteRows = false;
            dgV_datos.BackgroundColor = Color.White;
            dgV_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgV_datos.Dock = DockStyle.Bottom;
            dgV_datos.GridColor = Color.White;
            dgV_datos.Location = new Point(0, 123);
            dgV_datos.Name = "dgV_datos";
            dgV_datos.ReadOnly = true;
            dgV_datos.Size = new Size(800, 327);
            dgV_datos.TabIndex = 1;
            // 
            // frm_Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgV_datos);
            Controls.Add(panel1);
            Name = "frm_Buscar";
            Text = "frm_Buscar";
            Load += frm_Buscar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgV_datos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgV_datos;
    }
}