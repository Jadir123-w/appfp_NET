namespace Secuenciales
{
    partial class frm08
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
            this.txtAreaL = new System.Windows.Forms.TextBox();
            this.txtAreaB = new System.Windows.Forms.TextBox();
            this.txtAreaT = new System.Windows.Forms.TextBox();
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
            // txtAreaL
            // 
            this.txtAreaL.Location = new System.Drawing.Point(130, 130);
            this.txtAreaL.Name = "txtAreaL";
            this.txtAreaL.ReadOnly = true;
            this.txtAreaL.Size = new System.Drawing.Size(100, 20);
            this.txtAreaL.TabIndex = 2;

            // 
            // txtAreaB
            // 
            this.txtAreaB.Location = new System.Drawing.Point(130, 170);
            this.txtAreaB.Name = "txtAreaB";
            this.txtAreaB.ReadOnly = true;
            this.txtAreaB.Size = new System.Drawing.Size(100, 20);
            this.txtAreaB.TabIndex = 3;

            // 
            // txtAreaT
            // 
            this.txtAreaT.Location = new System.Drawing.Point(130, 210);
            this.txtAreaT.Name = "txtAreaT";
            this.txtAreaT.ReadOnly = true;
            this.txtAreaT.Size = new System.Drawing.Size(100, 20);
            this.txtAreaT.TabIndex = 4;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm08
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAreaT);
            this.Controls.Add(this.txtAreaB);
            this.Controls.Add(this.txtAreaL);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtAltura);
            this.Name = "frm08";
            this.Text = "Cálculo de Áreas de un Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtAreaL;
        private System.Windows.Forms.TextBox txtAreaB;
        private System.Windows.Forms.TextBox txtAreaT;
        private System.Windows.Forms.Button btnCalcular;
    }
}
