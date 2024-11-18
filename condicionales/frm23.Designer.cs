namespace Condicionales
{
    partial class frm23
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMatematicas;
        private TextBox txtFisica;
        private Label lblPropina;
        private Label lblReloj;
        private Label lblMatematicas;
        private Label lblFisica;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtMatematicas = new TextBox();
            this.txtFisica = new TextBox();
            this.lblPropina = new Label();
            this.lblReloj = new Label();
            this.lblMatematicas = new Label();
            this.lblFisica = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // lblMatematicas
            this.lblMatematicas.AutoSize = true;
            this.lblMatematicas.Location = new System.Drawing.Point(50, 30);
            this.lblMatematicas.Name = "lblMatematicas";
            this.lblMatematicas.Size = new System.Drawing.Size(101, 13);
            this.lblMatematicas.TabIndex = 0;
            this.lblMatematicas.Text = "Nota Matemáticas:";

            // lblFisica
            this.lblFisica.AutoSize = true;
            this.lblFisica.Location = new System.Drawing.Point(50, 70);
            this.lblFisica.Name = "lblFisica";
            this.lblFisica.Size = new System.Drawing.Size(66, 13);
            this.lblFisica.TabIndex = 1;
            this.lblFisica.Text = "Nota Física:";

            // txtMatematicas
            this.txtMatematicas.Location = new System.Drawing.Point(200, 30);
            this.txtMatematicas.Name = "txtMatematicas";
            this.txtMatematicas.Size = new System.Drawing.Size(100, 20);
            this.txtMatematicas.TabIndex = 2;

            // txtFisica
            this.txtFisica.Location = new System.Drawing.Point(200, 70);
            this.txtFisica.Name = "txtFisica";
            this.txtFisica.Size = new System.Drawing.Size(100, 20);
            this.txtFisica.TabIndex = 3;

            // lblPropina
            this.lblPropina.AutoSize = true;
            this.lblPropina.Location = new System.Drawing.Point(50, 160);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(68, 13);
            this.lblPropina.TabIndex = 4;
            this.lblPropina.Text = "Propina: S/.";

            // lblReloj
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(50, 190);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 13);
            this.lblReloj.TabIndex = 5;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(140, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm23
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.txtMatematicas);
            this.Controls.Add(this.txtFisica);
            this.Controls.Add(this.lblPropina);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblMatematicas);
            this.Controls.Add(this.lblFisica);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm23";
            this.Text = "Cálculo de Propina y Regalo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
