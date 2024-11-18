using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCant.Text, out int cantidad))
            {
                double precioUni = 20;
                double desc;
                double impCompra;
                double tPagar;
                int caramelo;

                impCompra = cantidad * precioUni;

                if (impCompra > 700)
                {
                    desc = impCompra * 0.16;
                }
                else if (impCompra >= 501)
                {
                    desc = impCompra * 0.14;
                }
                else
                {
                    desc = impCompra * 0.12;
                }

                tPagar = impCompra - desc;

                if (cantidad >= 1 && cantidad <= 50)
                {
                    caramelo = 5;
                }
                else if (cantidad >= 51 && cantidad <= 100)
                {
                    caramelo = 10;
                }
                else
                {
                    caramelo = 15;
                }

                txtImpC.Text = impCompra.ToString("F2");
                txtDesc.Text = desc.ToString("F2");
                txtPTotal.Text = tPagar.ToString("F2");
                txtCaramelo.Text = caramelo.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }
    }
}
