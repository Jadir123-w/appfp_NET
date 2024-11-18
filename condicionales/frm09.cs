using System;
using System.Windows.Forms;
using System.Globalization;

namespace Condicionales
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int codigo) &&
                int.TryParse(txtCantidad.Text, out int cantidad))
            {
                double precioU = 0;
                double porDesc = 0;

                // Determinar el precio según el código
                switch (codigo)
                {
                    case 101:
                        precioU = 17;
                        break;
                    case 102:
                        precioU = 25;
                        break;
                    case 103:
                        precioU = 16;
                        break;
                    case 104:
                        precioU = 27;
                        break;
                    default:
                        txtImpCompra.Text = "Código no reconocido";
                        return;
                }

                // Calcular el importe de compra
                double impCom = precioU * cantidad;

                // Determinar el porcentaje de descuento según la cantidad
                if (cantidad >= 1 && cantidad <= 10)
                {
                    porDesc = 5;
                }
                else if (cantidad >= 11 && cantidad <= 20)
                {
                    porDesc = 8;
                }
                else if (cantidad >= 21 && cantidad <= 30)
                {
                    porDesc = 10;
                }
                else if (cantidad >= 31)
                {
                    porDesc = 13;
                }

                // Calcular descuento y total a pagar
                double desc = impCom * porDesc / 100;
                double tPagar = impCom - desc;

                // Mostrar los resultados con formato
                txtImpCompra.Text = impCom.ToString("F2", CultureInfo.InvariantCulture);
                txtDescuento.Text = desc.ToString("F2", CultureInfo.InvariantCulture);
                txtTPagar.Text = tPagar.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
