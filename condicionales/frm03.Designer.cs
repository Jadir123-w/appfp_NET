namespace Condicionales
{
    partial class frm03
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(250, 50);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo.TabIndex = 0;
            this.txtAngulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 100);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 150);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.ReadOnly = true;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(50, 50);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(150, 13);
            this.lblAngulo.TabIndex = 2;
            this.lblAngulo.Text = "Digite el ángulo (grados):";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frm03
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAngulo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtAngulo);
            this.Name = "frm03";
            this.Text = "Clasificación de Ángulos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Button btnCalcular;
    }
}
