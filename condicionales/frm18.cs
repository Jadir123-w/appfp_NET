using System;
using System.Globalization;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm18 : Form
    {
        public frm18()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montoDonacion = double.Parse(txtMdonacion.Text);
            double centroSalud, comedorNinos, inversionBolsa;

            if (montoDonacion >= 10000)
            {
                centroSalud = montoDonacion * 0.30;
                comedorNinos = montoDonacion * 0.50;
            }
            else
            {
                centroSalud = montoDonacion * 0.25;
                comedorNinos = montoDonacion * 0.60;
            }

            inversionBolsa = montoDonacion - (centroSalud + comedorNinos);

            txtCsalud.Text = centroSalud.ToString("F2", CultureInfo.InvariantCulture);
            txtComeN.Text = comedorNinos.ToString("F2", CultureInfo.InvariantCulture);
            txtInbolsa.Text = inversionBolsa.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
