namespace Secuenciales
{
    partial class frm12
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtRaizR = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(130, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(300, 20);
            this.txtA.TabIndex = 0;

            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(130, 90);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(300, 20);
            this.txtB.TabIndex = 1;

            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(130, 130);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(300, 20);
            this.txtC.TabIndex = 2;

            // 
            // txtRaizR
            // 
            this.txtRaizR.Location = new System.Drawing.Point(130, 170);
            this.txtRaizR.Name = "txtRaizR";
            this.txtRaizR.ReadOnly = true;
            this.txtRaizR.Size = new System.Drawing.Size(300, 20);
            this.txtRaizR.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm12
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaizR);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "frm12";
            this.Text = "Ecuación Cuadrática";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtRaizR;
        private System.Windows.Forms.Button btnCalcular;
    }
}
