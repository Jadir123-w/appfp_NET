using System;
using System.Windows.Forms;

namespace appfp_NET.condicionales
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEdad1.Text, out int ed1) &&
                int.TryParse(txtEdad2.Text, out int ed2) &&
                int.TryParse(txtEdad3.Text, out int ed3))
            {
                int edadMayor = Math.Max(ed1, Math.Max(ed2, ed3));
                int edadMenor = Math.Min(ed1, Math.Min(ed2, ed3));

                txtResultado.Text = $"Edad mayor: {edadMayor}\nEdad menor: {edadMenor}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa edades válidas.");
            }
        }
    }
}
