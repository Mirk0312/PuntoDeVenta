using System.Drawing.Drawing2D;

namespace POS
{
    public partial class frm_principal : Form
    {
        public static bool Abierto = false;
        public frm_principal()
        {
            InitializeComponent();
            Abierto = true;
          
        }


        private void frmprincipal_Load(object sender, EventArgs e)
        {
            //Cargar Login
            frm_login frm = new frm_login();

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            frm_productos frmproductos = new frm_productos();
            frmproductos.TopLevel = false;
            panel_principal.Controls.Add(frmproductos);
            frmproductos.Dock = DockStyle.Fill;
            frmproductos.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            frm_clientes frmclientes = new frm_clientes();
            frmclientes.TopLevel = false;
            panel_principal.Controls.Add(frmclientes);
            frmclientes.Dock = DockStyle.Fill;
            frmclientes.Show();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            frm_proveedores frmproveedor = new frm_proveedores();
            frmproveedor.TopLevel = false;
            panel_principal.Controls.Add(frmproveedor);
            frmproveedor.Dock = DockStyle.Fill;
            frmproveedor.Show();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CerrarCP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrarSesion_Click_1(object sender, EventArgs e)
        {
            
                if (this.Visible) // Si el formulario principal est� visible
                {
                    this.Hide(); // Oculta el formulario principal
                    frm_login loginForm = new frm_login();
                    loginForm.ShowDialog(); // Muestra el formulario de inicio de sesi�n
                    this.Close(); // Cierra el formulario principal despu�s de mostrar el formulario de inicio de sesi�n
                }
                else // Si el formulario de inicio de sesi�n est� visible
                {
                    // Cierra la aplicaci�n
                    Application.Exit();
                }
            }


        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
