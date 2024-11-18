namespace Repetitivos
{
    partial class frm07
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private TextBox txtResultado;
        private Button btnGenerar;
        private Label lblNumero;

        private void InitializeComponent()
        {
            this.txtNumero = new TextBox();
            this.txtResultado = new TextBox();
            this.btnGenerar = new Button();
            this.lblNumero = new Label();

            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(150, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 1;

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(30, 130);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(320, 200);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.ReadOnly = true;

            // btnGenerar
            this.btnGenerar.Location = new System.Drawing.Point(100, 100);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(180, 30);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);

            // frm07
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNumero);
            this.Name = "frm07";
            this.Text = "Cálculo de Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
