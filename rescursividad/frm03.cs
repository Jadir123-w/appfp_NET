using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm03 : Form
    {
        public frm03()
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
                    int sum = CalcularSumatoria(n);
                    txtResultado.Text = $"La sumatoria de los números hasta {n} es: {sum}";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private int CalcularSumatoria(int n)
        {
            if (n == 0) return 0;
            return n + CalcularSumatoria(n - 1);
        }
    }
}
