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
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
        }
        private void nuevo()
        {
            try {
                txt_ID.Enabled = false;
                txt_ID.Text = "NUEVO";


            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "nuevo".ToUpper()) 
            {
                //estrucutura para un "INSERT"
            }
            else
            {
                //estructura para un "UPDATE"
            }
        }
    }
}
