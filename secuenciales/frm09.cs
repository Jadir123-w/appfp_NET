using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appfp_NET.secuenciales
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void frm09_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int c1 = numero / 1000; numero %= 1000;
            int c2 = numero / 100; numero %= 100;
            int c3 = numero / 10;
            int c4 = numero % 10;

            txtSuma.Text = "" + (c1 + c2 + c3 + c4);
        }
    }
}
