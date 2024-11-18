namespace Condicionales
{
    partial class frm18
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMdonacion;
        private TextBox txtCsalud;
        private TextBox txtComeN;
        private TextBox txtInbolsa;
        private Label lblMdonacion;
        private Label lblCsalud;
        private Label lblComeN;
        private Label lblInbolsa;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtMdonacion = new TextBox();
            this.txtCsalud = new TextBox();
            this.txtComeN = new TextBox();
            this.txtInbolsa = new TextBox();
            this.lblMdonacion = new Label();
            this.lblCsalud = new Label();
            this.lblComeN = new Label();
            this.lblInbolsa = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtMdonacion
            this.txtMdonacion.Location = new System.Drawing.Point(200, 50);
            this.txtMdonacion.Name = "txtMdonacion";
            this.txtMdonacion.Size = new System.Drawing.Size(100, 20);
            this.txtMdonacion.TabIndex = 0;

            // txtCsalud
            this.txtCsalud.Location = new System.Drawing.Point(200, 100);
            this.txtCsalud.Name = "txtCsalud";
            this.txtCsalud.Size = new System.Drawing.Size(100, 20);
            this.txtCsalud.TabIndex = 1;
            this.txtCsalud.ReadOnly = true;

            // txtComeN
            this.txtComeN.Location = new System.Drawing.Point(200, 150);
            this.txtComeN.Name = "txtComeN";
            this.txtComeN.Size = new System.Drawing.Size(100, 20);
            this.txtComeN.TabIndex = 2;
            this.txtComeN.ReadOnly = true;

            // txtInbolsa
            this.txtInbolsa.Location = new System.Drawing.Point(200, 200);
            this.txtInbolsa.Name = "txtInbolsa";
            this.txtInbolsa.Size = new System.Drawing.Size(100, 20);
            this.txtInbolsa.TabIndex = 3;
            this.txtInbolsa.ReadOnly = true;

            // lblMdonacion
            this.lblMdonacion.AutoSize = true;
            this.lblMdonacion.Location = new System.Drawing.Point(50, 50);
            this.lblMdonacion.Name = "lblMdonacion";
            this.lblMdonacion.Size = new System.Drawing.Size(123, 13);
            this.lblMdonacion.TabIndex = 4;
            this.lblMdonacion.Text = "Monto de la Donación:";

            // lblCsalud
            this.lblCsalud.AutoSize = true;
            this.lblCsalud.Location = new System.Drawing.Point(50, 100);
            this.lblCsalud.Name = "lblCsalud";
            this.lblCsalud.Size = new System.Drawing.Size(91, 13);
            this.lblCsalud.TabIndex = 5;
            this.lblCsalud.Text = "Centro de Salud:";

            // lblComeN
            this.lblComeN.AutoSize = true;
            this.lblComeN.Location = new System.Drawing.Point(50, 150);
            this.lblComeN.Name = "lblComeN";
            this.lblComeN.Size = new System.Drawing.Size(114, 13);
            this.lblComeN.TabIndex = 6;
            this.lblComeN.Text = "Comedor de Niños:";

            // lblInbolsa
            this.lblInbolsa.AutoSize = true;
            this.lblInbolsa.Location = new System.Drawing.Point(50, 200);
            this.lblInbolsa.Name = "lblInbolsa";
            this.lblInbolsa.Size = new System.Drawing.Size(108, 13);
            this.lblInbolsa.TabIndex = 7;
            this.lblInbolsa.Text = "Inversión en Bolsa:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(200, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm18
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtMdonacion);
            this.Controls.Add(this.txtCsalud);
            this.Controls.Add(this.txtComeN);
            this.Controls.Add(this.txtInbolsa);
            this.Controls.Add(this.lblMdonacion);
            this.Controls.Add(this.lblCsalud);
            this.Controls.Add(this.lblComeN);
            this.Controls.Add(this.lblInbolsa);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm18";
            this.Text = "Distribución de Donaciones";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
