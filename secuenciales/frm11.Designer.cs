namespace Secuenciales
{
    partial class frm11
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
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtInvertido = new System.Windows.Forms.TextBox();
            this.txtInvertido2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(170, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(110, 20);
            this.txtNumero.TabIndex = 0;

            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(170, 100);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(110, 20);
            this.txtNumero2.TabIndex = 1;

            // 
            // txtInvertido
            // 
            this.txtInvertido.Location = new System.Drawing.Point(170, 150);
            this.txtInvertido.Name = "txtInvertido";
            this.txtInvertido.ReadOnly = true;
            this.txtInvertido.Size = new System.Drawing.Size(110, 20);
            this.txtInvertido.TabIndex = 2;

            // 
            // txtInvertido2
            // 
            this.txtInvertido2.Location = new System.Drawing.Point(170, 200);
            this.txtInvertido2.Name = "txtInvertido2";
            this.txtInvertido2.ReadOnly = true;
            this.txtInvertido2.Size = new System.Drawing.Size(110, 20);
            this.txtInvertido2.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(110, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm11
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInvertido2);
            this.Controls.Add(this.txtInvertido);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero);
            this.Name = "frm11";
            this.Text = "Intercambio de Dígitos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtInvertido;
        private System.Windows.Forms.TextBox txtInvertido2;
        private System.Windows.Forms.Button btnCalcular;
    }
}
