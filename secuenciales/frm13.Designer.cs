namespace Secuenciales
{
    partial class frm13
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
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtCatetoA
            // 
            this.txtCatetoA.Location = new System.Drawing.Point(170, 50);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(130, 20);
            this.txtCatetoA.TabIndex = 0;

            // 
            // txtCatetoB
            // 
            this.txtCatetoB.Location = new System.Drawing.Point(170, 90);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(130, 20);
            this.txtCatetoB.TabIndex = 1;

            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(170, 140);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.ReadOnly = true;
            this.txtHipotenusa.Size = new System.Drawing.Size(130, 20);
            this.txtHipotenusa.TabIndex = 2;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm13
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.txtCatetoB);
            this.Controls.Add(this.txtCatetoA);
            this.Name = "frm13";
            this.Text = "Teorema de Pitágoras";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.Button btnCalcular;
    }
}
