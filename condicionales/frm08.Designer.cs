namespace Condicionales
{
    partial class frm08
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
            this.txtExamAp = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtExamAp
            // 
            this.txtExamAp.Location = new System.Drawing.Point(200, 30);
            this.txtExamAp.Name = "txtExamAp";
            this.txtExamAp.Size = new System.Drawing.Size(100, 20);
            this.txtExamAp.TabIndex = 0;

            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 80);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 100);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.ReadOnly = true;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Propina";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // frm08
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExamAp);
            this.Name = "frm08";
            this.Text = "Cálculo de Propina";
            this.Load += new System.EventHandler(this.frm08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtExamAp;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}
