using System;
using System.Text;
using System.Windows.Forms;

namespace Repetitivos
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            GenerarRectangulo();
        }

        private void GenerarRectangulo()
        {
            try
            {
                int altura = int.Parse(txtAltura.Text);
                StringBuilder rectangulo = new StringBuilder();

                if (altura >= 4)
                {
                    for (int i = 0; i < altura; i++)
                    {
                        for (int j = 0; j < 2 * altura; j++)
                        {
                            rectangulo.Append("*");
                        }
                        rectangulo.AppendLine();
                    }
                }

                lblResultado.Text = rectangulo.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
