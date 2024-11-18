namespace Condicionales
{
    partial class frm22
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUniA;
        private TextBox txtUniB;
        private Label lblImpBruto;
        private Label lblDesc;
        private Label lblTotal;
        private Label lblProductoA;
        private Label lblProductoB;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtUniA = new TextBox();
            this.txtUniB = new TextBox();
            this.lblImpBruto = new Label();
            this.lblDesc = new Label();
            this.lblTotal = new Label();
            this.lblProductoA = new Label();
            this.lblProductoB = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // lblProductoA
            this.lblProductoA.AutoSize = true;
            this.lblProductoA.Location = new System.Drawing.Point(50, 30);
            this.lblProductoA.Name = "lblProductoA";
            this.lblProductoA.Size = new System.Drawing.Size(128, 13);
            this.lblProductoA.TabIndex = 0;
            this.lblProductoA.Text = "Unidades Producto A:";

            // lblProductoB
            this.lblProductoB.AutoSize = true;
            this.lblProductoB.Location = new System.Drawing.Point(50, 70);
            this.lblProductoB.Name = "lblProductoB";
            this.lblProductoB.Size = new System.Drawing.Size(128, 13);
            this.lblProductoB.TabIndex = 1;
            this.lblProductoB.Text = "Unidades Producto B:";

            // txtUniA
            this.txtUniA.Location = new System.Drawing.Point(200, 30);
            this.txtUniA.Name = "txtUniA";
            this.txtUniA.Size = new System.Drawing.Size(100, 20);
            this.txtUniA.TabIndex = 2;

            // txtUniB
            this.txtUniB.Location = new System.Drawing.Point(200, 70);
            this.txtUniB.Name = "txtUniB";
            this.txtUniB.Size = new System.Drawing.Size(100, 20);
            this.txtUniB.TabIndex = 3;

            // lblImpBruto
            this.lblImpBruto.AutoSize = true;
            this.lblImpBruto.Location = new System.Drawing.Point(50, 160);
            this.lblImpBruto.Name = "lblImpBruto";
            this.lblImpBruto.Size = new System.Drawing.Size(97, 13);
            this.lblImpBruto.TabIndex = 4;
            this.lblImpBruto.Text = "Importe Bruto: S/.";

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(50, 190);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(84, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descuento: S/.";

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 220);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total a Pagar: S/.";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(140, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm22
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.txtUniA);
            this.Controls.Add(this.txtUniB);
            this.Controls.Add(this.lblImpBruto);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProductoA);
            this.Controls.Add(this.lblProductoB);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm22";
            this.Text = "Cálculo de Total";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
