using System;
using System.Windows.Forms;

namespace Secuenciales
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtAltura.Text);
            int radio = int.Parse(txtRadio.Text);

            double areaBase = Math.PI * Math.Pow(radio, 2);
            double areaLateral = 2 * Math.PI * radio * altura;
            double areaTotal = 2 * areaBase + areaLateral;

            txtAreaL.Text = areaLateral.ToString("F2");
            txtAreaB.Text = areaBase.ToString("F2");
            txtAreaT.Text = areaTotal.ToString("F2");
        }

        private void frm08_Load(object sender, EventArgs e)
        {

        }
    }
}
