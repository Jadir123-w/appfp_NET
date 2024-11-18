using System;
using System.Windows.Forms;

namespace appfp_NET.condicionales
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string numero = txtNumero.Text;

            if (numero.Length != 4 || !long.TryParse(numero, out _))
            {
                MessageBox.Show("Por favor, ingresa un número de 4 cifras.");
                return;
            }

            char cifraMayor = numero[0];
            char cifraMenor = numero[0];

            foreach (char cifra in numero)
            {
                if (cifra > cifraMayor)
                {
                    cifraMayor = cifra;
                }
                if (cifra < cifraMenor)
                {
                    cifraMenor = cifra;
                }
            }

            txtResultado.Text = "Mayor número posible: " + cifraMayor + cifraMenor;
        }
    }
}
