using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);

                BigInteger factorial = BigInteger.One;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                txtResultado.Text = "Resultado: " + factorial.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
