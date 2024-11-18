namespace Condicionales
{
    partial class frm16
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtIngMen;
        private TextBox txtCtCasa;
        private TextBox txtCuoIni;
        private TextBox txtCuoMen;
        private Label lblIngMen;
        private Label lblCtCasa;
        private Label lblCuoIni;
        private Label lblCuoMen;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtIngMen = new TextBox();
            this.txtCtCasa = new TextBox();
            this.txtCuoIni = new TextBox();
            this.txtCuoMen = new TextBox();
            this.lblIngMen = new Label();
            this.lblCtCasa = new Label();
            this.lblCuoIni = new Label();
            this.lblCuoMen = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtIngMen
            this.txtIngMen.Location = new System.Drawing.Point(180, 50);
            this.txtIngMen.Name = "txtIngMen";
            this.txtIngMen.Size = new System.Drawing.Size(100, 20);
            this.txtIngMen.TabIndex = 0;

            // txtCtCasa
            this.txtCtCasa.Location = new System.Drawing.Point(180, 100);
            this.txtCtCasa.Name = "txtCtCasa";
            this.txtCtCasa.Size = new System.Drawing.Size(100, 20);
            this.txtCtCasa.TabIndex = 1;

            // txtCuoIni
            this.txtCuoIni.Location = new System.Drawing.Point(180, 150);
            this.txtCuoIni.Name = "txtCuoIni";
            this.txtCuoIni.Size = new System.Drawing.Size(100, 20);
            this.txtCuoIni.TabIndex = 2;
            this.txtCuoIni.ReadOnly = true;

            // txtCuoMen
            this.txtCuoMen.Location = new System.Drawing.Point(180, 200);
            this.txtCuoMen.Name = "txtCuoMen";
            this.txtCuoMen.Size = new System.Drawing.Size(100, 20);
            this.txtCuoMen.TabIndex = 3;
            this.txtCuoMen.ReadOnly = true;

            // lblIngMen
            this.lblIngMen.AutoSize = true;
            this.lblIngMen.Location = new System.Drawing.Point(50, 50);
            this.lblIngMen.Name = "lblIngMen";
            this.lblIngMen.Size = new System.Drawing.Size(94, 13);
            this.lblIngMen.TabIndex = 4;
            this.lblIngMen.Text = "Ingreso Mensual:";

            // lblCtCasa
            this.lblCtCasa.AutoSize = true;
            this.lblCtCasa.Location = new System.Drawing.Point(50, 100);
            this.lblCtCasa.Name = "lblCtCasa";
            this.lblCtCasa.Size = new System.Drawing.Size(93, 13);
            this.lblCtCasa.TabIndex = 5;
            this.lblCtCasa.Text = "Costo de la Casa:";

            // lblCuoIni
            this.lblCuoIni.AutoSize = true;
            this.lblCuoIni.Location = new System.Drawing.Point(50, 150);
            this.lblCuoIni.Name = "lblCuoIni";
            this.lblCuoIni.Size = new System.Drawing.Size(70, 13);
            this.lblCuoIni.TabIndex = 6;
            this.lblCuoIni.Text = "Cuota Inicial:";

            // lblCuoMen
            this.lblCuoMen.AutoSize = true;
            this.lblCuoMen.Location = new System.Drawing.Point(50, 200);
            this.lblCuoMen.Name = "lblCuoMen";
            this.lblCuoMen.Size = new System.Drawing.Size(85, 13);
            this.lblCuoMen.TabIndex = 7;
            this.lblCuoMen.Text = "Cuota Mensual:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(180, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm16
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtIngMen);
            this.Controls.Add(this.txtCtCasa);
            this.Controls.Add(this.txtCuoIni);
            this.Controls.Add(this.txtCuoMen);
            this.Controls.Add(this.lblIngMen);
            this.Controls.Add(this.lblCtCasa);
            this.Controls.Add(this.lblCuoIni);
            this.Controls.Add(this.lblCuoMen);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm16";
            this.Text = "Cálculo de Cuotas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
