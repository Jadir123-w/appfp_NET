using System;
using System.Windows.Forms;
using System.Globalization;

namespace Condicionales
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] notas = new double[5];
            notas[0] = double.Parse(txtN1.Text, CultureInfo.InvariantCulture);
            notas[1] = double.Parse(txtN2.Text, CultureInfo.InvariantCulture);
            notas[2] = double.Parse(txtN3.Text, CultureInfo.InvariantCulture);
            notas[3] = double.Parse(txtN4.Text, CultureInfo.InvariantCulture);
            notas[4] = double.Parse(txtN5.Text, CultureInfo.InvariantCulture);

            double nMayor = notas[0];
            double nMenor = notas[0];

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > nMayor)
                {
                    nMayor = notas[i];
                }
                if (notas[i] < nMenor)
                {
                    nMenor = notas[i];
                }
            }

            double suma = 0;
            int contador = 0;
            foreach (double nota in notas)
            {
                if (nota != nMayor && nota != nMenor)
                {
                    suma += nota;
                    contador++;
                }
            }

            double promedio = suma / contador;

            txtNeliminadaM.Text = nMayor.ToString("F2", CultureInfo.InvariantCulture);
            txtNeliminadaMe.Text = nMenor.ToString("F2", CultureInfo.InvariantCulture);
            txtProm.Text = promedio.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
