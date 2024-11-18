using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pMensual = 20.0;
            double pxExam = 5.0;

            int exAp = int.Parse(txtExamAp.Text);
            double totalP = pMensual + (exAp * pxExam);

            txtResultado.Text = "Monto de propina S/. " + totalP;
        }

        private void frm08_Load(object sender, EventArgs e)
        {

        }
    }
}
