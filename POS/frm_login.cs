namespace POS
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Validar usuario y contrase�a
            if (CapaNegocio.Utilerias.validaVacio(txt_usuario.Text))
            {
                //Llamar a la BD

                this.Close();


            }
            else
            {
                MessageBox.Show("Es obligatorio ingresar el usuario");
            }

        }
    }
}
                
        
   
