namespace Condicionales
{
    partial class frm20
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtResul;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblResul;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.txtC = new TextBox();
            this.txtResul = new TextBox();
            this.lblA = new Label();
            this.lblB = new Label();
            this.lblC = new Label();
            this.lblResul = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtA
            this.txtA.Location = new System.Drawing.Point(150, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;

            // txtB
            this.txtB.Location = new System.Drawing.Point(150, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;

            // txtC
            this.txtC.Location = new System.Drawing.Point(150, 150);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 2;

            // txtResul
            this.txtResul.Location = new System.Drawing.Point(150, 200);
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(100, 20);
            this.txtResul.TabIndex = 3;

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(50, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(64, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Número A:";

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(50, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Número B:";

            // lblC
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(50, 150);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(64, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "Número C:";

            // lblResul
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(50, 200);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(58, 13);
            this.lblResul.TabIndex = 7;
            this.lblResul.Text = "Resultado:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(150, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm20
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm20";
            this.Text = "Verificador de Orden";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
