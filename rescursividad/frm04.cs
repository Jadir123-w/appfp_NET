using System;
using System.Windows.Forms;

namespace Recursividad
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
                int baseNum = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);
                if (exponente < 0)
                {
                    txtResultado.Text = "Por favor, ingrese un exponente no negativo.";
                }
                else
                {
                    int resultado = CalcularPotencia(baseNum, exponente);
                    txtResultado.Text = $"La potencia de {baseNum} elevado a {exponente} es: {resultado}";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese valores válidos.";
            }
        }

        private int CalcularPotencia(int baseNum, int exponente)
        {
            if (exponente == 0) return 1;
            return baseNum * CalcularPotencia(baseNum, exponente - 1);
        }
    }
}
