using System;
using System.Globalization;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm15 : Form
    {
        public frm15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldoBase = 250;
            double montoVendido = double.Parse(txtMVendido.Text, CultureInfo.InvariantCulture);
            int categoria = int.Parse(txtCategoria.Text);

            double porcentajeComision;

            if (montoVendido <= 5000)
            {
                porcentajeComision = 0.05;
            }
            else if (montoVendido <= 10000)
            {
                porcentajeComision = 0.08;
            }
            else if (montoVendido <= 20000)
            {
                porcentajeComision = 0.10;
            }
            else
            {
                porcentajeComision = 0.15;
            }

            double comision = montoVendido * porcentajeComision;
            double sueldoBruto = sueldoBase + comision;
            double descuento = sueldoBruto > 3500 ? sueldoBruto * 0.15 : sueldoBruto * 0.08;
            double sueldoNeto = sueldoBruto - descuento;

            txtComision.Text = comision.ToString("F2");
            txtSBruto.Text = sueldoBruto.ToString("F2");
            txtDesc.Text = descuento.ToString("F2");
            txtSNeto.Text = sueldoNeto.ToString("F2");
        }
    }
}
