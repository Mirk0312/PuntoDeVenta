using System.Diagnostics.Eventing.Reader;

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

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (frm_principal.Abierto)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
                
        
   
