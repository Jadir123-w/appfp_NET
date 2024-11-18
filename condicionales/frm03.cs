using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAngulo.Text, out double angulo))
            {
                string clasificacion;
                if (angulo == 0)
                {
                    clasificacion = "Nulo 0°";
                }
                else if (angulo > 0 && angulo < 90)
                {
                    clasificacion = "Agudo 0° a 90°";
                }
                else if (angulo == 90)
                {
                    clasificacion = "Recto 90°";
                }
                else if (angulo > 90 && angulo < 180)
                {
                    clasificacion = "Obtuso 90° a 180°";
                }
                else if (angulo == 180)
                {
                    clasificacion = "Llano 180°";
                }
                else if (angulo > 180 && angulo < 360)
                {
                    clasificacion = "Cóncavo 180° a 360°";
                }
                else if (angulo == 360)
                {
                    clasificacion = "Completo 360°";
                }
                else
                {
                    clasificacion = "No se puede clasificar mayor a 360°";
                }

                txtResultado.Text = "Tipo de ángulo: " + clasificacion;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
        }
    }
}
