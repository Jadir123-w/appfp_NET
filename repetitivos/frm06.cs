using System;
using System.Text;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int inicio = int.Parse(txtInicio.Text);
                int fin = int.Parse(txtFin.Text);

                StringBuilder resultado = new StringBuilder();

                for (int i = inicio; i <= fin; i++)
                {
                    resultado.Append(numero).Append(" x ").Append(i).Append(" = ").Append(numero * i).Append("\n");
                }

                txtResultado.Text = "Tabla de multiplicar del " + numero + " desde " + inicio + " hasta " + fin + ":\n" + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
