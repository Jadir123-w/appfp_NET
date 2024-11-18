using System;
using System.Text;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                StringBuilder resultado = new StringBuilder();

                for (int i = 1; i <= 12; i++)
                {
                    resultado.Append(numero).Append(" x ").Append(i).Append(" = ").Append(numero * i).Append("\n");
                }

                txtResultado.Text = "Tabla de multiplicar del " + numero + ":\n" + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
