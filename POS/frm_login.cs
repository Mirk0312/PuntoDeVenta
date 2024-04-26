namespace POS
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(CapaNegocio.Utilerias.validaVacio(txt_usuario.Text))
            {
                //LLAMAR BD
                this.Close();
            }
            else
            {
                MessageBox.Show("Es obligatorio ingresar el usuario");
            }
        }
    }
}
