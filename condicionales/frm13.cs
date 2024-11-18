using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;

            if (numero.Length != 3 || !System.Text.RegularExpressions.Regex.IsMatch(numero, @"^\d+$"))
            {
                txtResultado.Text = "Error: Ingrese un número de 3 cifras.";
                return;
            }

            int c1 = int.Parse(numero[0].ToString());
            int c2 = int.Parse(numero[1].ToString());
            int c3 = int.Parse(numero[2].ToString());

            if (c1 + 1 == c2 && c2 + 1 == c3)
            {
                txtResultado.Text = "Las cifras estan en orden ascendente";
            }
            else if (c1 - 1 == c2 && c2 - 1 == c3)
            {
                txtResultado.Text = "Las cifras estan en orden descendente";
            }
            else
            {
                txtResultado.Text = "Las cifras no estan en ningun orden";
            }
        }
    }
}
