namespace POS
{
    partial class ventas
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
            btn_buscarV = new Button();
            txt_codigoV = new TextBox();
            Codigo = new Label();
            data = new DataGridView();
            Vender = new Button();
            btn_agregarV = new Button();
            btn_eliminarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // btn_buscarV
            // 
            btn_buscarV.Location = new Point(292, 40);
            btn_buscarV.Name = "btn_buscarV";
            btn_buscarV.Size = new Size(75, 23);
            btn_buscarV.TabIndex = 0;
            btn_buscarV.Text = "Buscar";
            btn_buscarV.UseVisualStyleBackColor = true;
            btn_buscarV.Click += btn_buscarV_Click;
            // 
            // txt_codigoV
            // 
            txt_codigoV.Location = new Point(109, 41);
            txt_codigoV.Name = "txt_codigoV";
            txt_codigoV.Size = new Size(155, 23);
            txt_codigoV.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Location = new Point(33, 44);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(49, 15);
            Codigo.TabIndex = 2;
            Codigo.Text = "Codigo:";
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(15, 101);
            data.Name = "data";
            data.Size = new Size(673, 333);
            data.TabIndex = 3;
            // 
            // Vender
            // 
            Vender.Location = new Point(694, 185);
            Vender.Name = "Vender";
            Vender.Size = new Size(94, 23);
            Vender.TabIndex = 4;
            Vender.Text = "Realizar venta";
            Vender.UseVisualStyleBackColor = true;
            Vender.Click += Vender_Click;
            // 
            // btn_agregarV
            // 
            btn_agregarV.Location = new Point(694, 101);
            btn_agregarV.Name = "btn_agregarV";
            btn_agregarV.Size = new Size(94, 23);
            btn_agregarV.TabIndex = 5;
            btn_agregarV.Text = "Agregar";
            btn_agregarV.UseVisualStyleBackColor = true;
            btn_agregarV.Click += btn_agregarV_Click;
            // 
            // btn_eliminarVenta
            // 
            btn_eliminarVenta.Location = new Point(694, 144);
            btn_eliminarVenta.Name = "btn_eliminarVenta";
            btn_eliminarVenta.Size = new Size(94, 23);
            btn_eliminarVenta.TabIndex = 6;
            btn_eliminarVenta.Text = "Eliminar";
            btn_eliminarVenta.UseVisualStyleBackColor = true;
            btn_eliminarVenta.Click += btn_eliminarVenta_Click;
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eliminarVenta);
            Controls.Add(btn_agregarV);
            Controls.Add(Vender);
            Controls.Add(data);
            Controls.Add(Codigo);
            Controls.Add(txt_codigoV);
            Controls.Add(btn_buscarV);
            Name = "ventas";
            Text = "ventas";
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscarV;
        private TextBox txt_codigoV;
        private Label Codigo;
        private DataGridView data;
        private Button Vender;
        private Button btn_agregarV;
        private Button btn_eliminarVenta;
    }
}