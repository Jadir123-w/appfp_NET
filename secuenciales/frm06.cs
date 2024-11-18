using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtAltura.Text);
            int radio = int.Parse(txtRadio.Text);

            double area = 2 * Math.PI * radio * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            txtArea.Text = area.ToString("F2");
            txtVolumen.Text = volumen.ToString("F2");
        }

        private void frm06_Load(object sender, EventArgs e)
        {

        }
    }
}
