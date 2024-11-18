using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto = txtNumero.Text;
            if (int.TryParse(texto, out int numero) && numero >= 1000 && numero <= 9999)
            {
                int invertido = 0;
                int temp = numero;

                while (temp > 0)
                {
                    invertido = invertido * 10 + temp % 10;
                    temp /= 10;
                }

                txtInvertido.Text = invertido.ToString();
            }
            else
            {
                txtInvertido.Clear();
            }
        }

        private void frm10_Load(object sender, EventArgs e)
        {

        }
    }
}
