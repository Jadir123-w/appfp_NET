using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                long resultado = CalcularFactorial(numero);
                txtResultado.Text = "Factorial: " + resultado;
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private long CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;
            return numero * CalcularFactorial(numero - 1);
        }
    }
}
