namespace appfp_NET.secuenciales
{
    partial class frm02
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtMetros;
        private TextBox txtCentimetros;
        private TextBox txtPulgadas;
        private TextBox txtPies;
        private TextBox txtYardas;
        private Label lblMetros;
        private Label lblCentimetros;
        private Label lblPulgadas;
        private Label lblPies;
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
            this.lblMetros = new Label();
            this.lblCentimetros = new Label();
            this.lblPulgadas = new Label();
            this.lblPies = new Label();
            this.lblYardas = new Label();
            this.txtMetros = new TextBox();
            this.txtCentimetros = new TextBox();
            this.txtPulgadas = new TextBox();
            this.txtPies = new TextBox();
            this.txtYardas = new TextBox();
            this.btnCalcular = new Button();

            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(50, 50);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(50, 15);
            this.lblMetros.Text = "Metros :";

            // 
            // lblCentimetros
            // 
            this.lblCentimetros.AutoSize = true;
            this.lblCentimetros.Location = new System.Drawing.Point(50, 90);
            this.lblCentimetros.Name = "lblCentimetros";
            this.lblCentimetros.Size = new System.Drawing.Size(80, 15);
            this.lblCentimetros.Text = "Centimetros :";

            // 
            // lblPulgadas
            // 
            this.lblPulgadas.AutoSize = true;
            this.lblPulgadas.Location = new System.Drawing.Point(50, 130);
            this.lblPulgadas.Name = "lblPulgadas";
            this.lblPulgadas.Size = new System.Drawing.Size(70, 15);
            this.lblPulgadas.Text = "Pulgadas :";

            // 
            // lblPies
            // 
            this.lblPies.AutoSize = true;
            this.lblPies.Location = new System.Drawing.Point(50, 170);
            this.lblPies.Name = "lblPies";
            this.lblPies.Size = new System.Drawing.Size(40, 15);
            this.lblPies.Text = "Pies :";

            // 
            // lblYardas
            // 
            this.lblYardas.AutoSize = true;
            this.lblYardas.Location = new System.Drawing.Point(50, 210);
            this.lblYardas.Name = "lblYardas";
            this.lblYardas.Size = new System.Drawing.Size(60, 15);
            this.lblYardas.Text = "Yardas :";

            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(130, 47);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 23);

            // 
            // txtCentimetros
            // 
            this.txtCentimetros.Location = new System.Drawing.Point(130, 87);
            this.txtCentimetros.Name = "txtCentimetros";
            this.txtCentimetros.ReadOnly = true;
            this.txtCentimetros.Size = new System.Drawing.Size(100, 23);

            // 
            // txtPulgadas
            // 
            this.txtPulgadas.Location = new System.Drawing.Point(130, 127);
            this.txtPulgadas.Name = "txtPulgadas";
            this.txtPulgadas.ReadOnly = true;
            this.txtPulgadas.Size = new System.Drawing.Size(100, 23);

            // 
            // txtPies
            // 
            this.txtPies.Location = new System.Drawing.Point(130, 167);
            this.txtPies.Name = "txtPies";
            this.txtPies.ReadOnly = true;
            this.txtPies.Size = new System.Drawing.Size(100, 23);

            // 
            // txtYardas
            // 
            this.txtYardas.Location = new System.Drawing.Point(130, 207);
            this.txtYardas.Name = "txtYardas";
            this.txtYardas.ReadOnly = true;
            this.txtYardas.Size = new System.Drawing.Size(100, 23);

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // frm02
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblCentimetros);
            this.Controls.Add(this.lblPulgadas);
            this.Controls.Add(this.lblPies);
            this.Controls.Add(this.lblYardas);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtCentimetros);
            this.Controls.Add(this.txtPulgadas);
            this.Controls.Add(this.txtPies);
            this.Controls.Add(this.txtYardas);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm02";
            this.Text = "Conversión de Unidades";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
