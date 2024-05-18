using System.Diagnostics.Eventing.Reader;
using CapaDatos;
using CapaNegocio;

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
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            string usuario = txt_UsuarioL.Text;
            string contraseña = txt_passwordL.Text;

            // Crear una instancia de la clase DataUsuarios para autenticar al usuario
            DataUsuarios dataUsuarios = new DataUsuarios();

            // Llamar al método Autenticar para verificar las credenciales
            bool credencialesValidas = dataUsuarios.Autenticar(usuario, contraseña);

            if (credencialesValidas)
            {
                // Si las credenciales son válidas, permitir que el usuario acceda a la aplicación principal
                frm_principal formPrincipal = new frm_principal();
                formPrincipal.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                // Si las credenciales no son válidas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
        
   
