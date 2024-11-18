namespace Recursividad
{
    partial class frm01
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label lblNumero;

        private void InitializeComponent()
        {
            this.txtNumero = new TextBox();
            this.txtResultado = new TextBox();
            this.btnCalcular = new Button();
            this.lblNumero = new Label();

            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese N:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(150, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(50, 120);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 100);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.ReadOnly = true;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(150, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm01
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNumero);
            this.Name = "frm01";
            this.Text = "Suma Recursiva";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
