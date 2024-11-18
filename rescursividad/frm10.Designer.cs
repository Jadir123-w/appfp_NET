namespace Recursividad
{
    partial class frm10
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtResultado;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtResultado = new TextBox();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(50, 80);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 150);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.ReadOnly = true;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(150, 30);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // frm10
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm10";
            this.Text = "Calcular Números";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
