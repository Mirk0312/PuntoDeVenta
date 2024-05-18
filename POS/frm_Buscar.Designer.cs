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
            btn_CerrarBuscar = new Button();
            btn_BuscarBuscar = new Button();
            txt_BuscarBuscar = new TextBox();
            label2Buscar = new Label();
            pictureBox1Buscar = new PictureBox();
            label1Buscar = new Label();
            dgV_datos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgV_datos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_CerrarBuscar);
            panel1.Controls.Add(btn_BuscarBuscar);
            panel1.Controls.Add(txt_BuscarBuscar);
            panel1.Controls.Add(label2Buscar);
            panel1.Controls.Add(pictureBox1Buscar);
            panel1.Controls.Add(label1Buscar);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 0;
            // 
            // btn_CerrarBuscar
            // 
            btn_CerrarBuscar.Image = Properties.Resources.CerrarVentana;
            btn_CerrarBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CerrarBuscar.Location = new Point(704, 6);
            btn_CerrarBuscar.Margin = new Padding(3, 2, 3, 2);
            btn_CerrarBuscar.Name = "btn_CerrarBuscar";
            btn_CerrarBuscar.Size = new Size(83, 24);
            btn_CerrarBuscar.TabIndex = 25;
            btn_CerrarBuscar.Text = "        Cerrar";
            btn_CerrarBuscar.TextAlign = ContentAlignment.MiddleRight;
            btn_CerrarBuscar.UseVisualStyleBackColor = true;
            btn_CerrarBuscar.Click += btn_CerrarCP_Click;
            // 
            // btn_BuscarBuscar
            // 
            btn_BuscarBuscar.Location = new Point(542, 44);
            btn_BuscarBuscar.Name = "btn_BuscarBuscar";
            btn_BuscarBuscar.Size = new Size(75, 23);
            btn_BuscarBuscar.TabIndex = 4;
            btn_BuscarBuscar.Text = "Buscar";
            btn_BuscarBuscar.UseVisualStyleBackColor = true;
            btn_BuscarBuscar.Click += btn_buscar_Click;
            // 
            // txt_BuscarBuscar
            // 
            txt_BuscarBuscar.Location = new Point(212, 46);
            txt_BuscarBuscar.Name = "txt_BuscarBuscar";
            txt_BuscarBuscar.Size = new Size(317, 23);
            txt_BuscarBuscar.TabIndex = 3;
            // 
            // label2Buscar
            // 
            label2Buscar.AutoSize = true;
            label2Buscar.Location = new Point(104, 52);
            label2Buscar.Name = "label2Buscar";
            label2Buscar.Size = new Size(82, 15);
            label2Buscar.TabIndex = 2;
            label2Buscar.Text = "Dato a buscar:";
            // 
            // pictureBox1Buscar
            // 
            pictureBox1Buscar.Location = new Point(25, 23);
            pictureBox1Buscar.Name = "pictureBox1Buscar";
            pictureBox1Buscar.Size = new Size(48, 48);
            pictureBox1Buscar.TabIndex = 1;
            pictureBox1Buscar.TabStop = false;
            // 
            // label1Buscar
            // 
            label1Buscar.AutoSize = true;
            label1Buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Buscar.Location = new Point(104, 7);
            label1Buscar.Name = "label1Buscar";
            label1Buscar.Size = new Size(65, 20);
            label1Buscar.TabIndex = 0;
            label1Buscar.Text = "Buscar";
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
            dgV_datos.CellContentClick += dgV_datos_CellContentClick;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1Buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgV_datos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_BuscarBuscar;
        private TextBox txt_BuscarBuscar;
        private Label label2Buscar;
        private PictureBox pictureBox1Buscar;
        private Label label1Buscar;
        private DataGridView dgV_datos;
        private Button btn_CerrarBuscar;
    }
}