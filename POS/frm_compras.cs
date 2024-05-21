using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_compras : Form
    {
        public frm_compras()
        {
            InitializeComponent();
        }

        private void btn_cerrarCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
