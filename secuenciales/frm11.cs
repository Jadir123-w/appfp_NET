using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero1) && int.TryParse(txtNumero2.Text, out int numero2))
            {
                int centenas1 = numero1 / 100;
                int decenas1 = (numero1 / 10) % 10;
                int unidades1 = numero1 % 10;

                int centenas2 = numero2 / 100;
                int decenas2 = (numero2 / 10) % 10;
                int unidades2 = numero2 % 10;

                int nuevoNumero1 = centenas2 * 100 + decenas1 * 10 + unidades2;
                int nuevoNumero2 = centenas1 * 100 + decenas2 * 10 + unidades1;

                txtInvertido.Text = nuevoNumero1.ToString();
                txtInvertido2.Text = nuevoNumero2.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos de tres dígitos.");
            }
        }
    }
}
