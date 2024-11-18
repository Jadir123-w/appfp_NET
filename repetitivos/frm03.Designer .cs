namespace Repetitivos
{
    partial class frm03
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnCalcular;
        private Label lblNumero;

        private void InitializeComponent()
        {
            this.txtNumero = new TextBox();
            this.lblResultado = new Label();
            this.btnCalcular = new Button();
            this.lblNumero = new Label();

            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 130);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(121, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Cantidad de divisores: 0";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(180, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(130, 80);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm03
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNumero);
            this.Name = "frm03";
            this.Text = "Cantidad de Divisores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
