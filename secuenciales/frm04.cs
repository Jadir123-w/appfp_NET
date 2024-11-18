using System;
using System.Windows.Forms;

namespace appfp_NET.secuenciales
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double metros = double.Parse(txtMetros.Text);

            double pulgadas = metros * 39.3701;
            double pies = metros * 3.28084;

            txtMetros.Text = metros.ToString("F2");
            txtPulgadas.Text = pulgadas.ToString("F2");
            txtPies.Text = pies.ToString("F2");
        }
    }
}
