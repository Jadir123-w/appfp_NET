using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm20 : Form
    {
        public frm20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                string resultado;

                if (a < b && b < c)
                {
                    resultado = "Ascendente";
                }
                else if (a > b && b > c)
                {
                    resultado = "Descendente";
                }
                else
                {
                    resultado = "Desordenado";
                }

                txtResul.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
