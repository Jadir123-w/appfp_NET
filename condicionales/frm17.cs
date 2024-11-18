using System;
using System.Globalization;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm17 : Form
    {
        public frm17()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int docenas = int.Parse(txtDoc.Text);
            double precioPorDocena = 100.0;
            double montoCompra = docenas * precioPorDocena;
            double descuento = 0.0;
            int lapicerosObsequio = 0;

            if (docenas >= 6)
            {
                descuento = montoCompra * 0.15;
            }
            else
            {
                descuento = montoCompra * 0.10;
            }

            if (docenas >= 30)
            {
                lapicerosObsequio = (docenas / 3) * 2;
            }

            double totalPagar = montoCompra - descuento;

            txtMcompra.Text = montoCompra.ToString("F2", CultureInfo.InvariantCulture);
            txtDesc.Text = descuento.ToString("F2", CultureInfo.InvariantCulture);
            txtTPagar.Text = totalPagar.ToString("F2", CultureInfo.InvariantCulture);
            txtLapi.Text = lapicerosObsequio.ToString();
        }
    }
}
