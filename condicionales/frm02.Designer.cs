namespace Condicionales
{
    partial class frm02
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
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtImpC = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPTotal = new System.Windows.Forms.TextBox();
            this.txtCaramelo = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblImpC = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPTotal = new System.Windows.Forms.Label();
            this.lblCaramelo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(140, 50);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 0;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpC
            // 
            this.txtImpC.Location = new System.Drawing.Point(140, 90);
            this.txtImpC.Name = "txtImpC";
            this.txtImpC.Size = new System.Drawing.Size(100, 20);
            this.txtImpC.TabIndex = 1;
            this.txtImpC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(140, 130);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPTotal
            // 
            this.txtPTotal.Location = new System.Drawing.Point(140, 170);
            this.txtPTotal.Name = "txtPTotal";
            this.txtPTotal.ReadOnly = true;
            this.txtPTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPTotal.TabIndex = 3;
            this.txtPTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaramelo
            // 
            this.txtCaramelo.Location = new System.Drawing.Point(140, 210);
            this.txtCaramelo.Name = "txtCaramelo";
            this.txtCaramelo.ReadOnly = true;
            this.txtCaramelo.Size = new System.Drawing.Size(100, 20);
            this.txtCaramelo.TabIndex = 4;
            this.txtCaramelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(50, 50);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(50, 13);
            this.lblCant.TabIndex = 5;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblImpC
            // 
            this.lblImpC.AutoSize = true;
            this.lblImpC.Location = new System.Drawing.Point(50, 90);
            this.lblImpC.Name = "lblImpC";
            this.lblImpC.Size = new System.Drawing.Size(47, 13);
            this.lblImpC.TabIndex = 6;
            this.lblImpC.Text = "Importe:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(50, 130);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Descuento:";
            // 
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.Location = new System.Drawing.Point(50, 170);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(82, 13);
            this.lblPTotal.TabIndex = 8;
            this.lblPTotal.Text = "Total a Pagar:";
            // 
            // lblCaramelo
            // 
            this.lblCaramelo.AutoSize = true;
            this.lblCaramelo.Location = new System.Drawing.Point(50, 210);
            this.lblCaramelo.Name = "lblCaramelo";
            this.lblCaramelo.Size = new System.Drawing.Size(56, 13);
            this.lblCaramelo.TabIndex = 9;
            this.lblCaramelo.Text = "Caramelo:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frm02
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCaramelo);
            this.Controls.Add(this.lblPTotal);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblImpC);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.txtCaramelo);
            this.Controls.Add(this.txtPTotal);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtImpC);
            this.Controls.Add(this.txtCant);
            this.Name = "frm02";
            this.Text = "Descuento y Caramelos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtImpC;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPTotal;
        private System.Windows.Forms.TextBox txtCaramelo;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblImpC;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPTotal;
        private S
