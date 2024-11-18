using System;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtNumero1.Text);
                int n2 = int.Parse(txtNumero2.Text);

                int resultado = 0;
                int veces = Math.Abs(n2);

                for (int i = 0; i < veces; i++)
                {
                    resultado += n1;
                }

                if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
                {
                    resultado = -resultado;
                }

                lblResultado.Text = "Resultado: " + resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
