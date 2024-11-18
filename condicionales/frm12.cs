using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNum.Text);

            string[] aDias = { "lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            if (numero >= 1 && numero <= 7)
                txtDia.Text = aDias[numero - 1];
            else
                txtDia.Text = "Error";
        }
    }
}
