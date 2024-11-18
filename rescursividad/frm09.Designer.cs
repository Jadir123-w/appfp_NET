namespace Recursividad
{
    partial class frm09
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAltura;
        private TextBox txtResultado;
        private Button btnGenerar;
        private Label lblAltura;

        private void InitializeComponent()
        {
            this.txtAltura = new TextBox();
            this.txtResultado = new TextBox();
            this.btnGenerar = new Button();
            this.lblAltura = new Label();

            this.SuspendLayout();

            // lblAltura
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(50, 30);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(100, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura (n):";

            // txtAltura
            this.txtAltura.Location = new System.Drawing.Point(150, 30);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;

            // btnGenerar
            this.btnGenerar.Location = new System.Drawing.Point(150, 80);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(50, 130);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 100);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.ReadOnly = true;

            // frm09
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblAltura);
            this.Name = "frm09";
            this.Text = "Generar Rectángulo de Asteriscos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
