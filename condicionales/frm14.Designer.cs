namespace Condicionales
{
    partial class frm14
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.TextBox txtMnCompra;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTPagar;
        private System.Windows.Forms.Label lblNumTarjeta;
        private System.Windows.Forms.Label lblMnCompra;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTPagar;
        private System.Windows.Forms.Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtMnCompra = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTPagar = new System.Windows.Forms.TextBox();
            this.lblNumTarjeta = new System.Windows.Forms.Label();
            this.lblMnCompra = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTPagar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.txtNumTarjeta.Location = new System.Drawing.Point(200, 50);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtNumTarjeta.TabIndex = 0;
            this.txtNumTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.txtMnCompra.Location = new System.Drawing.Point(200, 90);
            this.txtMnCompra.Name = "txtMnCompra";
            this.txtMnCompra.Size = new System.Drawing.Size(100, 20);
            this.txtMnCompra.TabIndex = 1;
            this.txtMnCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.txtDesc.Location = new System.Drawing.Point(200, 170);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.ReadOnly = true;

            this.txtTPagar.Location = new System.Drawing.Point(200, 210);
            this.txtTPagar.Name = "txtTPagar";
            this.txtTPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTPagar.TabIndex = 3;
            this.txtTPagar.ReadOnly = true;

            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.Location = new System.Drawing.Point(50, 50);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(150, 13);
            this.lblNumTarjeta.TabIndex = 4;
            this.lblNumTarjeta.Text = "Numero tarjeta:";

            this.lblMnCompra.AutoSize = true;
            this.lblMnCompra.Location = new System.Drawing.Point(50, 90);
            this.lblMnCompra.Name = "lblMnCompra";
            this.lblMnCompra.Size = new System.Drawing.Size(150, 13);
            this.lblMnCompra.TabIndex = 5;
            this.lblMnCompra.Text = "Monto de compra:";

            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(50, 170);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Descuento:";

            this.lblTPagar.AutoSize = true;
            this.lblTPagar.Location = new System.Drawing.Point(50, 210);
            this.lblTPagar.Name = "lblTPagar";
            this.lblTPagar.Size = new System.Drawing.Size(100, 13);
            this.lblTPagar.TabIndex = 7;
            this.lblTPagar.Text = "Total a pagar:";

            this.btnCalcular.Location = new System.Drawing.Point(200, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.txtMnCompra);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTPagar);
            this.Controls.Add(this.lblNumTarjeta);
            this.Controls.Add(this.lblMnCompra);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTPagar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm14";
            this.Text = "Cálculo del Total a Pagar";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
