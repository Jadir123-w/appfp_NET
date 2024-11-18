using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class frm21 : Form
    {
        public frm21()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNempleado.Text);

                if (numero < 1000 || numero > 9999)
                {
                    lblEstadoCivil.Text = "Estado Civil: Código inválido";
                    lblEdad.Text = "Edad: Número inválido";
                    lblSexo.Text = "Sexo: Número inválido";
                    return;
                }

                int estCivilCodigo = numero / 1000;
                int edad = (numero / 10) % 100;
                int sexoCodigo = numero % 10;

                string estadoCivil;
                switch (estCivilCodigo)
                {
                    case 1: estadoCivil = "Soltero"; break;
                    case 2: estadoCivil = "Casado"; break;
                    case 3: estadoCivil = "Divorciado"; break;
                    case 4: estadoCivil = "Viudo"; break;
                    default: estadoCivil = "Código inválido"; break;
                }

                string sexo;
                if (sexoCodigo == 1)
                {
                    sexo = "Masculino";
                }
                else if (sexoCodigo == 2)
                {
                    sexo = "Femenino";
                }
                else
                {
                    sexo = "Código inválido";
                }

                lblEstadoCivil.Text = "Estado Civil: " + estadoCivil;
                lblEdad.Text = "Edad: " + edad;
                lblSexo.Text = "Sexo: " + sexo;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido de empleado.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
