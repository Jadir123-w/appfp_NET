using System;
using System.Globalization;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm16 : Form
    {
        public frm16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ingresoMensual = double.Parse(txtIngMen.Text, CultureInfo.InvariantCulture);
            double costoCasa = double.Parse(txtCtCasa.Text, CultureInfo.InvariantCulture);
            double cuotaInicial;
            double cuotaMensual;

            if (ingresoMensual < 1250)
            {
                cuotaInicial = costoCasa * 0.15;
                cuotaMensual = (costoCasa - cuotaInicial) / 120;
            }
            else
            {
                cuotaInicial = costoCasa * 0.30;
                cuotaMensual = (costoCasa - cuotaInicial) / 75;
            }

            txtCuoIni.Text = cuotaInicial.ToString("F2");
            txtCuoMen.Text = cuotaMensual.ToString("F2");
        }
    }
}
