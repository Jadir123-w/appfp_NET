using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCatetoA.Text, out double catetoA) && double.TryParse(txtCatetoB.Text, out double catetoB))
            {
                double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
                txtHipotenusa.Text = hipotenusa.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los catetos.");
            }
        }
    }
}
