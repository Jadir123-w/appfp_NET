namespace Repetitivos
{
    partial class frm09
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAltura;
        private Label lblResultado;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtAltura = new TextBox();
            this.lblResultado = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtAltura
            this.txtAltura.Location = new System.Drawing.Point(180, 30);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 30);
            this.txtAltura.TabIndex = 0;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(50, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 150);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(50, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Generar Rectángulo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // frm09
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm09";
            this.Text = "Generador de Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
