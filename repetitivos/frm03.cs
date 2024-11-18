using System;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumero.Text);
                int cantidadDiv = 0;

                for (int i = 1; i <= Math.Abs(n); i++)
                {
                    if (n % i == 0)
                    {
                        cantidadDiv++;
                    }
                }

                lblResultado.Text = "Cantidad de divisores: " + cantidadDiv;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
