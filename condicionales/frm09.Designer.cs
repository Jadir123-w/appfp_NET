namespace Condicionales
{
    partial class frm09
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtImpCompra = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTPagar = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblImpCompra = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTPagar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(200, 90);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpCompra
            // 
            this.txtImpCompra.Location = new System.Drawing.Point(200, 130);
            this.txtImpCompra.Name = "txtImpCompra";
            this.txtImpCompra.ReadOnly = true;
            this.txtImpCompra.Size = new System.Drawing.Size(140, 20);
            this.txtImpCompra.TabIndex = 2;
            this.txtImpCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(200, 170);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(140, 20);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTPagar
            // 
            this.txtTPagar.Location = new System.Drawing.Point(200, 210);
            this.txtTPagar.Name = "txtTPagar";
            this.txtTPagar.ReadOnly = true;
            this.txtTPagar.Size = new System.Drawing.Size(140, 20);
            this.txtTPagar.TabIndex = 4;
            this.txtTPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(50, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(50, 90);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(53, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblImpCompra
            // 
            this.lblImpCompra.AutoSize = true;
            this.lblImpCompra.Location = new System.Drawing.Point(50, 130);
            this.lblImpCompra.Name = "lblImpCompra";
            this.lblImpCompra.Size = new System.Drawing.Size(115, 13);
            this.lblImpCompra.TabIndex = 7;
            this.lblImpCompra.Text = "Importe de compra:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(50, 170);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(63, 13);
            this.lblDescuento.TabIndex = 8;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblTPagar
            // 
            this.lblTPagar.AutoSize = true;
            this.lblTPagar.Location = new System.Drawing.Point(50, 210);
            this.lblTPagar.Name = "lblTPagar";
            this.lblTPagar.Size = new System.Drawing.Size(79, 13);
            this.lblTPagar.TabIndex = 9;
            this.lblTPagar.Text = "Total a pagar:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 260);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frm09
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTPagar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImpCompra);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtTPagar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtImpCompra);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frm09";
            this.Text = "Cálculo de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtImpCompra;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTPagar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblImpCompra;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTPagar;
        private System.Windows.Forms.Button btnCalcular;
    }
}
