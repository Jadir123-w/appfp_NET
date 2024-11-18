using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm19 : Form
    {
        public frm19()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string sexo = txtSexo.Text.ToUpper();
            int edad;
            string categoria;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                if (sexo == "F")
                {
                    categoria = edad < 23 ? "FA" : "FB";
                }
                else if (sexo == "M")
                {
                    categoria = edad < 25 ? "MA" : "MB";
                }
                else
                {
                    categoria = "No válido (solo F o M)";
                }
            }
            else
            {
                categoria = "Edad no válida";
            }

            txtCate.Text = categoria;
        }
    }
}
