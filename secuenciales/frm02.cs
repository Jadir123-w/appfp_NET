namespace appfp_NET.secuenciales
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double pVarones = varones * 100.0 / total;
            double pMujeres = mujeres * 100.0 / total;

            lblPVarones.Text = string.Format("{0:0.00} %", pVarones);
            lblPMujeres.Text = string.Format("{0:0.00} %", pMujeres);
        }
    }
}
