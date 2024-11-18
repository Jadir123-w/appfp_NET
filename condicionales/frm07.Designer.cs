namespace Condicionales
{
    partial class frm07
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(150, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(80, 20);
            this.txtNum1.TabIndex = 0;

            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(150, 90);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(80, 20);
            this.txtNum2.TabIndex = 1;

            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(150, 130);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(80, 20);
            this.txtNum3.TabIndex = 2;

            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 200);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 70);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.ReadOnly = true;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm07
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frm07";
            this.Text = "Numero Intermedio";
            this.Load += new System.EventHandler(this.frm07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}
