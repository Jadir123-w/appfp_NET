using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int gigabytes = int.Parse(txtGigabytes.Text);
            int megabytes = gigabytes * 1024;
            int kilobytes = megabytes * 1024;
            int bytes = kilobytes * 1024;

            txtMegabytes.Text = megabytes.ToString();
            txtKilobytes.Text = kilobytes.ToString();
            txtBytes.Text = bytes.ToString();
        }

        private void frm05_Load(object sender, EventArgs e)
        {

        }
    }
}
