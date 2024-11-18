using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumero.Text);
                if (n < 0)
                {
                    txtResultado.Text = "Por favor, ingrese un número no negativo.";
                }
                else
                {
                    int fact = CalcularFactorial(n);
                    txtResultado.Text = $"El factorial de {n} es: {fact}";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private int CalcularFactorial(int n)
        {
            if (n == 0) return 1;
            return n * CalcularFactorial(n - 1);
        }
    }
}
