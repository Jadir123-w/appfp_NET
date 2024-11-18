using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm15 : Form
    {
        public frm15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtJuan.Text, out double aporJuan) &&
                double.TryParse(txtRosa.Text, out double aporRosa) &&
                double.TryParse(txtDaniel.Text, out double aporDanielSoles))
            {
                double aporteDanielUSD = aporDanielSoles / 3.00;
                double totalCapitalUSD = aporJuan + aporRosa + aporteDanielUSD;
                double porcentajeJuan = (aporJuan / totalCapitalUSD) * 100;
                double porcentajeRosa = (aporRosa / totalCapitalUSD) * 100;
                double porcentajeDaniel = (aporteDanielUSD / totalCapitalUSD) * 100;

                txtTotalCapital.Text = totalCapitalUSD.ToString("F2");
                txtPorcentajeJuan.Text = porcentajeJuan.ToString("F2") + " %";
                txtPorcentajeRosa.Text = porcentajeRosa.ToString("F2") + " %";
                txtPorcentajeDaniel.Text = porcentajeDaniel.ToString("F2") + " %";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los aportes.");
            }
        }
    }
}
