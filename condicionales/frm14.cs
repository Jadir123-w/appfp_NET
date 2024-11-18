using System;
using System.Windows.Forms;
using System.Globalization;

namespace Condicionales
{
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numT = int.Parse(txtNumTarjeta.Text);
            double mCompra = double.Parse(txtMnCompra.Text, CultureInfo.InvariantCulture);
            double desc;

            if (numT % 2 == 0 && numT >= 100)
            {
                desc = mCompra * 0.15;
            }
            else
            {
                desc = mCompra * 0.05;
            }

            double TPagar = mCompra - desc;

            txtDesc.Text = desc.ToString("F2");
            txtTPagar.Text = TPagar.ToString("F2");
        }
    }
}
