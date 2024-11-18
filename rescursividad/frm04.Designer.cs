namespace Recursividad
{
    partial class frm04
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtBase;
        private TextBox txtExponente;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label lblBase;
        private Label lblExponente;

        private void InitializeComponent()
        {
            this.txtBase = new TextBox();
            this.txtExponente = new TextBox();
            this.txtResultado = new TextBox();
            this.btnCalcular = new Button();
            this.lblBase = new Label();
            this.lblExponente = new Label();

            this.SuspendLayout();

            // lblBase
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(50, 30);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(35, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base:";

            // txtBase
            this.txtBase.Location = new System.Drawing.Point(150, 30);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;

            // lblExponente
            this.lblExponente.AutoSize = true;
            this.lblExponente.Location = new System.Drawing.Point(50, 70);
            this.lblExponente.Name = "lblExponente";
            this.lblExponente.Size = new System.Drawing.Size(60, 13);
            this.lblExponente.TabIndex = 2;
            this.lblExponente.Text = "Exponente:";

            // txtExponente
            this.txtExponente.Location = new System.Drawing.Point(150, 70);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(100, 20);
            this.txtExponente.TabIndex = 3;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(150, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(50, 160);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 100);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.ReadOnly = true;

            // frm04
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblExponente);
            this.Name = "frm04";
            this.Text = "Calcular Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
