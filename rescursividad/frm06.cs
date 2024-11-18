using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                if (numero <= 0)
                {
                    txtResultado.Text = "Por favor, ingrese un número mayor a 0.";
                }
                else
                {
                    string resultado = "Secuencia Fibonacci:\n";
                    for (int i = 0; i < numero; i++)
                    {
                        resultado += CalcularFibonacci(i) + " ";
                    }
                    txtResultado.Text = resultado;
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private int CalcularFibonacci(int n)
        {
            if (n <= 1) return n;
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}
