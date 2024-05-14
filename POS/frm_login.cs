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

            //Validar
            Boolean validado = false;
            String aviso = "Ninguno";
            String usuario, password;
            if (txt_UsuarioL.Text.Length == 0)
            {
                validado = false;
                aviso = "Obligatorio ingresar usuario \n ";

            }
            if (txt_passwordL.Text.Length == 0)
            {
                validado = false;
                aviso = "Obligatorio ingresar contraseña \n ";

            }
            //Recolectar campos en pantalla
            if (validado) 
            { 
            usuario = txt_UsuarioL.Text;
            password = txt_passwordL.Text;
                //Instanciar objeto
                Usuarios user = new Usuarios();
                user.setUsuario(usuario);
                user.setPassword(password);
                if (user.) 
                
                
                { 
                
                }
                //Consultar UsuarioValido()
                this.Close();
            }
            else
            {
                MessageBox.Show("Atender lo siguiente: \n" + aviso);
            }



            //Validar usuario y contrase�a
            if (CapaNegocio.Utilerias.validaVacio(txt_UsuarioL.Text))
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
                
        
   
