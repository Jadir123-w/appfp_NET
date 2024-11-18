namespace Secuenciales
{
    partial class frm06
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(130, 50);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;

            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(130, 90);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 1;

            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(130, 130);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 2;

            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(130, 170);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.ReadOnly = true;
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm06
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtAltura);
            this.Name = "frm06";
            this.Text = "Cálculo de Área y Volumen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Button btnCalcular;
    }
}
