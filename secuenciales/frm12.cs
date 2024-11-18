using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b) && double.TryParse(txtC.Text, out double c))
            {
                double discriminante = Math.Pow(b, 2) - 4 * a * c;

                if (discriminante < 0)
                {
                    txtRaizR.Text = "No hay soluciones reales";
                    return;
                }

                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                txtRaizR.Text = "Raíces: " + raiz1.ToString() + ", " + raiz2.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para A, B y C.");
            }
        }
    }
}
