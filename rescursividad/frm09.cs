using System;
using System.Text;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtAltura.Text);
                if (n >= 4)
                {
                    string resultado = GenerarRectanguloAsteriscos(n);
                    txtResultado.Text = resultado;
                }
                else
                {
                    txtResultado.Text = "La altura debe ser mayor o igual a 4.";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private string GenerarRectanguloAsteriscos(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
