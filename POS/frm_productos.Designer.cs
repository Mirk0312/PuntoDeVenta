namespace POS
{
    partial class frm_productos
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
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            txt_ID = new TextBox();
            SuspendLayout();
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(55, 342);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(75, 23);
            btn_nuevo.TabIndex = 0;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(161, 342);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(260, 342);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 41);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(115, 38);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(100, 23);
            txt_ID.TabIndex = 4;
            // 
            // frm_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ID);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Name = "frm_productos";
            Text = "frm_productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Label label1;
        private TextBox txt_ID;
    }
}