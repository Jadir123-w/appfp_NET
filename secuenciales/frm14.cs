using System;
using System.Linq;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) &&
                double.TryParse(txtNum2.Text, out double num2) &&
                double.TryParse(txtNum3.Text, out double num3) &&
                double.TryParse(txtNum4.Text, out double num4) &&
                double.TryParse(txtNum5.Text, out double num5))
            {
                // Crear un arreglo con los números
                double[] numeros = { num1, num2, num3, num4, num5 };

                // Ordenar el arreglo de mayor a menor
                var numerosOrdenados = numeros.OrderByDescending(n => n).ToArray();

                // Calcular el promedio de los tres números más grandes
                double promedio = (numerosOrdenados[0] + numerosOrdenados[1] + numerosOrdenados[2]) / 3;

                // Mostrar el promedio en el cuadro de texto
                txtprom.Text = promedio.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos para todos los campos.");
            }
        }
    }
}
