namespace Condicionales
{
    partial class frm17
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDoc;
        private TextBox txtMcompra;
        private TextBox txtDesc;
        private TextBox txtTPagar;
        private TextBox txtLapi;
        private Label lblDoc;
        private Label lblMcompra;
        private Label lblDesc;
        private Label lblTPagar;
        private Label lblLapi;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtDoc = new TextBox();
            this.txtMcompra = new TextBox();
            this.txtDesc = new TextBox();
            this.txtTPagar = new TextBox();
            this.txtLapi = new TextBox();
            this.lblDoc = new Label();
            this.lblMcompra = new Label();
            this.lblDesc = new Label();
            this.lblTPagar = new Label();
            this.lblLapi = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtDoc
            this.txtDoc.Location = new System.Drawing.Point(200, 50);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 20);
            this.txtDoc.TabIndex = 0;

            // txtMcompra
            this.txtMcompra.Location = new System.Drawing.Point(200, 100);
            this.txtMcompra.Name = "txtMcompra";
            this.txtMcompra.Size = new System.Drawing.Size(100, 20);
            this.txtMcompra.TabIndex = 1;
            this.txtMcompra.ReadOnly = true;

            // txtDesc
            this.txtDesc.Location = new System.Drawing.Point(200, 150);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.ReadOnly = true;

            // txtTPagar
            this.txtTPagar.Location = new System.Drawing.Point(200, 200);
            this.txtTPagar.Name = "txtTPagar";
            this.txtTPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTPagar.TabIndex = 3;
            this.txtTPagar.ReadOnly = true;

            // txtLapi
            this.txtLapi.Location = new System.Drawing.Point(200, 250);
            this.txtLapi.Name = "txtLapi";
            this.txtLapi.Size = new System.Drawing.Size(100, 20);
            this.txtLapi.TabIndex = 4;
            this.txtLapi.ReadOnly = true;

            // lblDoc
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(50, 50);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(123, 13);
            this.lblDoc.TabIndex = 5;
            this.lblDoc.Text = "Cantidad de Docenas:";

            // lblMcompra
            this.lblMcompra.AutoSize = true;
            this.lblMcompra.Location = new System.Drawing.Point(50, 100);
            this.lblMcompra.Name = "lblMcompra";
            this.lblMcompra.Size = new System.Drawing.Size(108, 13);
            this.lblMcompra.TabIndex = 6;
            this.lblMcompra.Text = "Monto de la Compra:";

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(50, 150);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Descuento:";

            // lblTPagar
            this.lblTPagar.AutoSize = true;
            this.lblTPagar.Location = new System.Drawing.Point(50, 200);
            this.lblTPagar.Name = "lblTPagar";
            this.lblTPagar.Size = new System.Drawing.Size(80, 13);
            this.lblTPagar.TabIndex = 8;
            this.lblTPagar.Text = "Total a Pagar:";

            // lblLapi
            this.lblLapi.AutoSize = true;
            this.lblLapi.Location = new System.Drawing.Point(50, 250);
            this.lblLapi.Name = "lblLapi";
            this.lblLapi.Size = new System.Drawing.Size(134, 13);
            this.lblLapi.TabIndex = 9;
            this.lblLapi.Text = "Lapiceros de Obsequio:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(200, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm17
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtMcompra);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTPagar);
            this.Controls.Add(this.txtLapi);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblMcompra);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTPagar);
            this.Controls.Add(this.lblLapi);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm17";
            this.Text = "Cálculo de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
