using System;
using System.Text;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularNumeros();
        }

        private void CalcularNumeros()
        {
            StringBuilder resultado = new StringBuilder();
            int cantidad = 0;

            for (int num = 1000; num <= 9999; num++)
            {
                int dig1 = num / 1000;
                int dig2 = (num / 100) % 10;
                int dig3 = (num / 10) % 10;
                int dig4 = num % 10;

                int sumaPares = 0, sumaImpares = 0;

                if (dig1 % 2 == 0) sumaPares += dig1; else sumaImpares += dig1;
                if (dig2 % 2 == 0) sumaPares += dig2; else sumaImpares += dig2;
                if (dig3 % 2 == 0) sumaPares += dig3; else sumaImpares += dig3;
                if (dig4 % 2 == 0) sumaPares += dig4; else sumaImpares += dig4;

                if (sumaPares == sumaImpares)
                {
                    resultado.AppendLine(num.ToString());
                    cantidad++;
                }
            }

            if (cantidad > 0)
            {
                resultado.AppendLine($"\nCantidad de números encontrados: {cantidad}");
            }
            else
            {
                resultado.AppendLine("No se encontraron números que cumplan la condición.");
            }

            txtResultado.Text = resultado.ToString();
        }
    }
}
