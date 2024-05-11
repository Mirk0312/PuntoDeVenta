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
            btn_CerrarB = new Button();
            btn_BuscarB = new Button();
            txt_BuscarB = new TextBox();
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
            panel1.Controls.Add(btn_CerrarB);
            panel1.Controls.Add(btn_BuscarB);
            panel1.Controls.Add(txt_BuscarB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 0;
            // 
            // btn_CerrarB
            // 
            btn_CerrarB.Image = Properties.Resources.CerrarVentana;
            btn_CerrarB.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarB.Location = new Point(704, 6);
            btn_CerrarB.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarB.Name = "btn_CerrarB";
            btn_CerrarB.Size = new Size(83, 24);
            btn_CerrarB.TabIndex = 25;
            btn_CerrarB.Text = "        Cerrar";
            btn_CerrarB.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarB.UseVisualStyleBackColor = true;
            btn_CerrarB.Click += btn_CerrarCP_Click;
            // 
            // btn_BuscarB
            // 
            btn_BuscarB.Location = new Point(542, 44);
            btn_BuscarB.Name = "btn_BuscarB";
            btn_BuscarB.Size = new Size(75, 23);
            btn_BuscarB.TabIndex = 4;
            btn_BuscarB.Text = "Buscar";
            btn_BuscarB.UseVisualStyleBackColor = true;
            btn_BuscarB.Click += btn_buscar_Click;
            // 
            // txt_BuscarB
            // 
            txt_BuscarB.Location = new Point(212, 46);
            txt_BuscarB.Name = "txt_BuscarB";
            txt_BuscarB.Size = new Size(317, 23);
            txt_BuscarB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 52);
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
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 7);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
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
            dgV_datos.RowHeadersWidth = 51;
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
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btn_BuscarB;
        private TextBox txt_BuscarB;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgV_datos;
        private Button btn_CerrarB;
    }
}