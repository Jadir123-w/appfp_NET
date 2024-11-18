using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtAltura.Text);
            int baseRectangulo = int.Parse(txtBase.Text);

            double area = altura * baseRectangulo;
            double perimetro = 2 * (baseRectangulo + altura);

            txtArea.Text = area.ToString("F2");
            txtPerimetro.Text = perimetro.ToString("F2");
        }

        private void frm07_Load(object sender, EventArgs e)
        {

        }
    }
}
