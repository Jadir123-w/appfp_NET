using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm01 : Form
    {
        public frm01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumero.Text);
                int suma = SumarNumeros(n);
                txtResultado.Text = $"La suma del 1 al {n} es: {suma}";
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private int SumarNumeros(int n)
        {
            if (n == 1)
                return 1;
            return n + SumarNumeros(n - 1);
        }
    }
}
