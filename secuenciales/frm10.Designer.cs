namespace Secuenciales
{
    partial class frm10
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtInvertido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(170, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;

            // 
            // txtInvertido
            // 
            this.txtInvertido.Location = new System.Drawing.Point(170, 90);
            this.txtInvertido.Name = "txtInvertido";
            this.txtInvertido.ReadOnly = true;
            this.txtInvertido.Size = new System.Drawing.Size(100, 20);
            this.txtInvertido.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm10
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInvertido);
            this.Controls.Add(this.txtNumero);
            this.Name = "frm10";
            this.Text = "Invertir Número";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtInvertido;
        private System.Windows.Forms.Button btnCalcular;
    }
}
