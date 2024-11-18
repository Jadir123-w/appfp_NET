using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int intermedio;

            if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
            {
                intermedio = num1;
            }
            else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
            {
                intermedio = num2;
            }
            else
            {
                intermedio = num3;
            }

            txtResultado.Text = "Numero intermedio es " + intermedio;
        }

        private void frm07_Load(object sender, EventArgs e)
        {

        }
    }
}
