using System;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int baseValue = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);
                int resultado = CalcularPotencia(baseValue, exponente);
                txtResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese números válidos.";
            }
        }

        private int CalcularPotencia(int baseValue, int exponente)
        {
            if (exponente == 0) return 1;
            return baseValue * CalcularPotencia(baseValue, exponente - 1);
        }
    }
}
