using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrac1.Text, out double p1) &&
                double.TryParse(txtPrac2.Text, out double p2) &&
                double.TryParse(txtPrac3.Text, out double p3))
            {
                if (p3 >= 10)
                {
                    p3 += 2;
                }

                double promedio = (p1 + p2 + p3) / 3;
                txtResultado.Text = "Promedio Final: " + promedio.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
