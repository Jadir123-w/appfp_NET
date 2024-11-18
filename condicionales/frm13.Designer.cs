namespace Condicionales
{
    partial class frm13
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.txtNumero.Location = new System.Drawing.Point(50, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.txtResultado.Location = new System.Drawing.Point(50, 110);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 50);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.ReadOnly = true;

            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(160, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero de 3 cifras :";

            this.btnCalcular.Location = new System.Drawing.Point(160, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm13";
            this.Text = "Orden de Cifras";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
