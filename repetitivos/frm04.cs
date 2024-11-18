using System;
using System.Text;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                StringBuilder resultado = new StringBuilder();

                for (int i = 1; i <= cantidad; i++)
                {
                    resultado.Append(numero * i).Append(" ");
                }

                txtResultado.Text = "Los primeros " + cantidad + " múltiplos de " + numero + " son: \n" + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
