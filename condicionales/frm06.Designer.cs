namespace appfp_NET.condicionales
{
    partial class frm06
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtEdad1;
        private TextBox txtEdad2;
        private TextBox txtEdad3;
        private TextBox txtResultado;
        private Label lblEdad1;
        private Label lblEdad2;
        private Label lblEdad3;
        private Button btnCalcular;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEdad1 = new Label();
            this.lblEdad2 = new Label();
            this.lblEdad3 = new Label();
            this.txtEdad1 = new TextBox();
            this.txtEdad2 = new TextBox();
            this.txtEdad3 = new TextBox();
            this.txtResultado = new TextBox();
            this.btnCalcular = new Button();

            // 
            // lblEdad1
            // 
            this.lblEdad1.AutoSize = true;
            this.lblEdad1.Location = new System.Drawing.Point(50, 50);
            this.lblEdad1.Name = "lblEdad1";
            this.lblEdad1.Size = new System.Drawing.Size(60, 15);
            this.lblEdad1.Text = "Edad 1:";

            // 
            // lblEdad2
            // 
            this.lblEdad2.AutoSize = true;
            this.lblEdad2.Location = new System.Drawing.Point(50, 90);
            this.lblEdad2.Name = "lblEdad2";
            this.lblEdad2.Size = new System.Drawing.Size(60, 15);
            this.lblEdad2.Text = "Edad 2:";

            // 
            // lblEdad3
            // 
            this.lblEdad3.AutoSize = true;
            this.lblEdad3.Location = new System.Drawing.Point(50, 130);
            this.lblEdad3.Name = "lblEdad3";
            this.lblEdad3.Size = new System.Drawing.Size(60, 15);
            this.lblEdad3.Text = "Edad 3:";

            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(150, 50);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(80, 23);
            this.txtEdad1.TextAlign = HorizontalAlignment.Right;

            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(150, 90);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(80, 23);
            this.txtEdad2.TextAlign = HorizontalAlignment.Right;

            // 
            // txtEdad3
            // 
            this.txtEdad3.Location = new System.Drawing.Point(150, 130);
            this.txtEdad3.Name = "txtEdad3";
            this.txtEdad3.Size = new System.Drawing.Size(80, 23);
            this.txtEdad3.TextAlign = HorizontalAlignment.Right;

            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 180);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 50);
            this.txtResultado.Multiline = true;
            this.txtResultado.ReadOnly = true;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // frm06
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblEdad1);
            this.Controls.Add(this.lblEdad2);
            this.Controls.Add(this.lblEdad3);
            this.Controls.Add(this.txtEdad1);
            this.Controls.Add(this.txtEdad2);
            this.Controls.Add(this.txtEdad3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm06";
            this.Text = "Calcular Edad Mayor y Menor";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
