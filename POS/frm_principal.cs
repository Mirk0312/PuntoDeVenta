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
            frm_productos frm = new frm_productos();
            frm.TopLevel = false;
            panel_principal.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
