namespace appfp_NET.secuenciales
{
    partial class frm04
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtMetros;
        private TextBox txtPulgadas;
        private TextBox txtPies;
        private Label lblMetros;
        private Label lblPies;
        private Label lblPulgadas;
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
            this.lblPies = new Label();
            this.lblPulgadas = new Label();
            this.txtMetros = new TextBox();
            this.txtPulgadas = new TextBox();
            this.txtPies = new TextBox();
            this.btnCalcular = new Button();

            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(50, 50);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(60, 15);
            this.lblMetros.Text = "Metros :";

            // 
            // lblPies
            // 
            this.lblPies.AutoSize = true;
            this.lblPies.Location = new System.Drawing.Point(50, 130);
            this.lblPies.Name = "lblPies";
            this.lblPies.Size = new System.Drawing.Size(40, 15);
            this.lblPies.Text = "Pies :";

            // 
            // lblPulgadas
            // 
            this.lblPulgadas.AutoSize = true;
            this.lblPulgadas.Location = new System.Drawing.Point(50, 170);
            this.lblPulgadas.Name = "lblPulgadas";
            this.lblPulgadas.Size = new System.Drawing.Size(70, 15);
            this.lblPulgadas.Text = "Pulgadas :";

            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(130, 47);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(80, 23);
            this.txtMetros.TextAlign = HorizontalAlignment.Right;

            // 
            // txtPulgadas
            // 
            this.txtPulgadas.Location = new System.Drawing.Point(130, 167);
            this.txtPulgadas.Name = "txtPulgadas";
            this.txtPulgadas.ReadOnly = true;
            this.txtPulgadas.Size = new System.Drawing.Size(80, 23);
            this.txtPulgadas.TextAlign = HorizontalAlignment.Right;

            // 
            // txtPies
            // 
            this.txtPies.Location = new System.Drawing.Point(130, 127);
            this.txtPies.Name = "txtPies";
            this.txtPies.ReadOnly = true;
            this.txtPies.Size = new System.Drawing.Size(80, 23);
            this.txtPies.TextAlign = HorizontalAlignment.Right;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // frm04
            // 
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblPies);
            this.Controls.Add(this.lblPulgadas);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtPulgadas);
            this.Controls.Add(this.txtPies);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm04";
            this.Text = "Conversión de Distancias";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
