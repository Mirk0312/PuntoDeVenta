using System.Diagnostics.Eventing.Reader;
using System.Text;
using CapaDatos;
using CapaNegocio;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace POS
{
    public partial class frm_login : Form
    {
        private string connectionString = "Server=LPKM\\SQLEXPRESS;Database=POS;Integrated Security=True;";
        ConexionSQL conn = new ConexionSQL();
        public frm_login()
        {
            InitializeComponent();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string Usuario = txt_UsuarioLogin.Text;
            string Password = txt_passwordLogin.Text;

            if (AutenticarUsuario(Usuario, Password))
            {
                MessageBox.Show("Ingresando al Sistema");
                // Continua con la siguiente parte de tu aplicación
                frm_principal principal = new frm_principal();
                principal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto.");
            }
        }

        private bool AutenticarUsuario(string usuario, string password)
        {
            bool Autenticado = false;

            string query = "SELECT COUNT(1) FROM Usuarios WHERE Usuario = @Usuario AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Password", password);  // En una aplicación real, usa contraseñas hasheadas

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    Autenticado = (count == 1);
                }
            }

            return Autenticado;
        }

        // Método para hashear la contraseña (opcional, recomendado para producción)
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        
     }

        private void btn_cerrarLogin_Click(object sender, EventArgs e)
        {
            if (frm_principal.Abierto)
            {
               
                this.Close();
            }
            else
            {
                conn.CerrarConexion();
               Application.Exit();
            }
        }
    }
}
                
        
   
