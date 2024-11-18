using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm23 : Form
    {
        public frm23()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nMatematica = double.Parse(txtMatematicas.Text);
                double nFisica = double.Parse(txtFisica.Text);

                double proMatematica = nMatematica > 17 ? 3.0 : nMatematica;
                double proFisica = nFisica > 15 ? 2.0 : (nFisica * 0.5);
                double proTotal = proMatematica + proFisica;

                double promedio = (nMatematica + nFisica) / 2;

                bool rReloj = promedio > 16;

                lblPropina.Text = $"Propina S/. {proTotal:F2}";
                lblReloj.Text = rReloj ? "De regalo: Recibirá un reloj" : "De regalo: No recibirá nada";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para las notas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
