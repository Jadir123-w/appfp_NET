using System;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void CalcularResultado()
        {
            try
            {
                int baseNum = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);
                int resultado = 1;

                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNum;
                }

                lblResultado.Text = "Resultado: " + resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
