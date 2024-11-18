using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm24 : Form
    {
        public frm24()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ventas = double.Parse(txtVentas.Text);
                double sueldo = ventas * 0.10;

                if (ventas > 5000)
                {
                    double exceso = ventas - 5000;
                    int bonos = (int)(exceso / 500);
                    sueldo += bonos * 25;
                }

                lblSueldo.Text = $"Sueldo: S/. {sueldo:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un monto válido para las ventas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
