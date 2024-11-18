using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm22 : Form
    {
        public frm22()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int uniA = int.Parse(txtUniA.Text);
                int uniB = int.Parse(txtUniB.Text);

                double precioA = 25.0;
                double precioB = 30.0;

                double descA = uniA > 50 ? 0.15 : 0.0;
                double descB = uniB > 60 ? 0.10 : 0.0;


                double impBa = uniA * precioA;
                double impBb = uniB * precioB;
                double desctA = impBa * descA;
                double desctB = impBb * descB;
                double impBr = impBa + impBb;
                double descuento = desctA + desctB;
                double total = impBr - descuento;

                lblImpBruto.Text = $"El importe es de S/. {impBr:F2}";
                lblDesc.Text = $"El descuento es de S/. {descuento:F2}";
                lblTotal.Text = $"El total es S/. {total:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para las unidades.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
