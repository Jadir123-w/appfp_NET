namespace Repetitivos
{
    partial class frm08
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtBase;
        private TextBox txtExponente;
        private Label lblResultado;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtBase = new TextBox();
            this.txtExponente = new TextBox();
            this.lblResultado = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtBase
            this.txtBase.Location = new System.Drawing.Point(150, 30);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 30);
            this.txtBase.TabIndex = 0;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // txtExponente
            this.txtExponente.Location = new System.Drawing.Point(150, 70);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(100, 30);
            this.txtExponente.TabIndex = 1;
            this.txtExponente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(50, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(300, 30);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: ";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(130, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // frm08
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm08";
            this.Text = "Cálculo de Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
