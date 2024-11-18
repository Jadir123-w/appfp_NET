namespace Condicionales
{
    partial class frm12
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.txtDia.Location = new System.Drawing.Point(120, 50);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(60, 20);
            this.txtDia.TabIndex = 0;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDia.ReadOnly = true;

            this.txtNum.Location = new System.Drawing.Point(120, 90);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(60, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(50, 50);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(30, 13);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Dia :";

            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(50, 90);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(60, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Numero :";

            this.btnCalcular.Location = new System.Drawing.Point(100, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm12";
            this.Text = "Dia de la Semana";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
