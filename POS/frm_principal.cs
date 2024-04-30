namespace POS
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
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
    }
}
