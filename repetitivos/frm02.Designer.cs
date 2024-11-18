namespace Repetitivos
{
    partial class frm02
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblResultado;
        private Button btnCalcular;
        private Label lblNumero1;
        private Label lblNumero2;

        private void InitializeComponent()
        {
            this.txtNumero1 = new TextBox();
            this.txtNumero2 = new TextBox();
            this.lblResultado = new Label();
            this.btnCalcular = new Button();
            this.lblNumero1 = new Label();
            this.lblNumero2 = new Label();

            this.SuspendLayout();

            // lblNumero1
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(50, 30);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(58, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1:";

            // lblNumero2
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(50, 70);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(58, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2:";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(74, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: 0";

            // txtNumero1
            this.txtNumero1.Location = new System.Drawing.Point(180, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 3;

            // txtNumero2
            this.txtNumero2.Location = new System.Drawing.Point(180, 70);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 4;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(130, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm02
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Name = "frm02";
            this.Text = "Multiplicación por Sumas Repetidas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
