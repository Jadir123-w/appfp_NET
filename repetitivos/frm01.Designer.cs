namespace Repetitivos
{
    partial class frm01
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private Label lblCociente;
        private Label lblResto;
        private Button btnCalcular;
        private Label lblDividendo;
        private Label lblDivisor;

        private void InitializeComponent()
        {
            this.txtDividendo = new TextBox();
            this.txtDivisor = new TextBox();
            this.lblCociente = new Label();
            this.lblResto = new Label();
            this.btnCalcular = new Button();
            this.lblDividendo = new Label();
            this.lblDivisor = new Label();

            this.SuspendLayout();

            // lblDividendo
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(50, 30);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(60, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo:";

            // lblDivisor
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(50, 70);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor:";

            // lblCociente
            this.lblCociente.AutoSize = true;
            this.lblCociente.Location = new System.Drawing.Point(50, 160);
            this.lblCociente.Name = "lblCociente";
            this.lblCociente.Size = new System.Drawing.Size(58, 13);
            this.lblCociente.TabIndex = 2;
            this.lblCociente.Text = "Cociente: 0";

            // lblResto
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(50, 190);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(49, 13);
            this.lblResto.TabIndex = 3;
            this.lblResto.Text = "Resto: 0";

            // txtDividendo
            this.txtDividendo.Location = new System.Drawing.Point(180, 30);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 4;

            // txtDivisor
            this.txtDivisor.Location = new System.Drawing.Point(180, 70);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 5;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(130, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm01
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblCociente);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.lblDivisor);
            this.Name = "frm01";
            this.Text = "División con Resto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
