namespace Condicionales
{
    partial class frm04
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
            this.txtPrac1 = new System.Windows.Forms.TextBox();
            this.txtPrac2 = new System.Windows.Forms.TextBox();
            this.txtPrac3 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblPrac1 = new System.Windows.Forms.Label();
            this.lblPrac2 = new System.Windows.Forms.Label();
            this.lblPrac3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrac1
            // 
            this.txtPrac1.Location = new System.Drawing.Point(150, 50);
            this.txtPrac1.Name = "txtPrac1";
            this.txtPrac1.Size = new System.Drawing.Size(80, 20);
            this.txtPrac1.TabIndex = 0;
            this.txtPrac1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrac2
            // 
            this.txtPrac2.Location = new System.Drawing.Point(150, 90);
            this.txtPrac2.Name = "txtPrac2";
            this.txtPrac2.Size = new System.Drawing.Size(80, 20);
            this.txtPrac2.TabIndex = 1;
            this.txtPrac2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrac3
            // 
            this.txtPrac3.Location = new System.Drawing.Point(150, 130);
            this.txtPrac3.Name = "txtPrac3";
            this.txtPrac3.Size = new System.Drawing.Size(80, 20);
            this.txtPrac3.TabIndex = 2;
            this.txtPrac3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 180);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 70);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.ReadOnly = true;
            // 
            // lblPrac1
            // 
            this.lblPrac1.AutoSize = true;
            this.lblPrac1.Location = new System.Drawing.Point(50, 50);
            this.lblPrac1.Name = "lblPrac1";
            this.lblPrac1.Size = new System.Drawing.Size(42, 13);
            this.lblPrac1.TabIndex = 4;
            this.lblPrac1.Text = "Nota 1:";
            // 
            // lblPrac2
            // 
            this.lblPrac2.AutoSize = true;
            this.lblPrac2.Location = new System.Drawing.Point(50, 90);
            this.lblPrac2.Name = "lblPrac2";
            this.lblPrac2.Size = new System.Drawing.Size(42, 13);
            this.lblPrac2.TabIndex = 5;
            this.lblPrac2.Text = "Nota 2:";
            // 
            // lblPrac3
            // 
            this.lblPrac3.AutoSize = true;
            this.lblPrac3.Location = new System.Drawing.Point(50, 130);
            this.lblPrac3.Name = "lblPrac3";
            this.lblPrac3.Size = new System.Drawing.Size(42, 13);
            this.lblPrac3.TabIndex = 6;
            this.lblPrac3.Text = "Nota 3:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 260);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frm04
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPrac3);
            this.Controls.Add(this.lblPrac2);
            this.Controls.Add(this.lblPrac1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtPrac3);
            this.Controls.Add(this.txtPrac2);
            this.Controls.Add(this.txtPrac1);
            this.Name = "frm04";
            this.Text = "Calificación Promedio Final";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPrac1;
        private System.Windows.Forms.TextBox txtPrac2;
        private System.Windows.Forms.TextBox txtPrac3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblPrac1;
        private System.Windows.Forms.Label lblPrac2;
        private System.Windows.Forms.Label lblPrac3;
        private System.Windows.Forms.Button btnCalcular;
    }
}
