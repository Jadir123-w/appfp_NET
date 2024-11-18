using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                if (numero < 0)
                {
                    txtResultado.Text = "Por favor, ingrese un número no negativo.";
                }
                else
                {
                    int resultado = CalcularSumatoria(numero);
                    txtResultado.Text = $"La sumatoria de 1 a {numero} es: {resultado}";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private int CalcularSumatoria(int numero)
        {
            if (numero == 0) return 0;
            return numero + CalcularSumatoria(numero - 1);
        }
    }
}
