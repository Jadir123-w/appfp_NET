namespace appfp_NET.secuenciales
{
    partial class frm03
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtKilometros;
        private TextBox txtPies;
        private TextBox txtMillas;
        private TextBox txtMetros;
        private TextBox txtYardas;
        private Label lblKilometros;
        private Label lblPies;
        private Label lblMillas;
        private Label lblMetros;
        private Label lblYardas;
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
            this.lblKilometros = new Label();
            this.lblPies = new Label();
            this.lblMillas = new Label();
            this.lblMetros = new Label();
            this.lblYardas = new Label();
            this.txtKilometros = new TextBox();
            this.txtPies = new TextBox();
            this.txtMillas = new TextBox();
            this.txtMetros = new TextBox();
            this.txtYardas = new TextBox();
            this.btnCalcular = new Button();

            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(50, 50);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(80, 15);
            this.lblKilometros.Text = "Kilometros :";

            // 
            // lblPies
            // 
            this.lblPies.AutoSize = true;
            this.lblPies.Location = new System.Drawing.Point(50, 90);
            this.lblPies.Name = "lblPies";
            this.lblPies.Size = new System.Drawing.Size(40, 15);
            this.lblPies.Text = "Pies :";

            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.Location = new System.Drawing.Point(50, 130);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(50, 15);
            this.lblMillas.Text = "Millas :";

            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(50, 210);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(50, 15);
            this.lblMetros.Text = "Metros :";

            // 
            // lblYardas
            // 
            this.lblYardas.AutoSize = true;
            this.lblYardas.Location = new System.Drawing.Point(50, 250);
            this.lblYardas.Name = "lblYardas";
            this.lblYardas.Size = new System.Drawing.Size(100, 15);
            this.lblYardas.Text = "Yardas totales :";

            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(150, 47);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(100, 23);

            // 
            // txtPies
            // 
            this.txtPies.Location = new System.Drawing.Point(150, 87);
            this.txtPies.Name = "txtPies";
            this.txtPies.Size = new System.Drawing.Size(100, 23);

            // 
            // txtMillas
            // 
            this.txtMillas.Location = new System.Drawing.Point(150, 127);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(100, 23);

            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(150, 207);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.ReadOnly = true;
            this.txtMetros.Size = new System.Drawing.Size(100, 23);

            // 
            // txtYardas
            // 
            this.txtYardas.Location = new System.Drawing.Point(150, 247);
            this.txtYardas.Name = "txtYardas";
            this.txtYardas.ReadOnly = true;
            this.txtYardas.Size = new System.Drawing.Size(100, 23);

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // frm03
            // 
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.lblPies);
            this.Controls.Add(this.lblMillas);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblYardas);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.txtPies);
            this.Controls.Add(this.txtMillas);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtYardas);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm03";
            this.Text = "Conversión de Distancias";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
