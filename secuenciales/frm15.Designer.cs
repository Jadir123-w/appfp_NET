namespace Secuenciales
{
    partial class frm15
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
            this.txtJuan = new System.Windows.Forms.TextBox();
            this.txtRosa = new System.Windows.Forms.TextBox();
            this.txtDaniel = new System.Windows.Forms.TextBox();
            this.txtTotalCapital = new System.Windows.Forms.TextBox();
            this.txtPorcentajeJuan = new System.Windows.Forms.TextBox();
            this.txtPorcentajeRosa = new System.Windows.Forms.TextBox();
            this.txtPorcentajeDaniel = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtJuan
            this.txtJuan.Location = new System.Drawing.Point(170, 50);
            this.txtJuan.Name = "txtJuan";
            this.txtJuan.Size = new System.Drawing.Size(130, 20);
            this.txtJuan.TabIndex = 0;

            // txtRosa
            this.txtRosa.Location = new System.Drawing.Point(170, 90);
            this.txtRosa.Name = "txtRosa";
            this.txtRosa.Size = new System.Drawing.Size(130, 20);
            this.txtRosa.TabIndex = 1;

            // txtDaniel
            this.txtDaniel.Location = new System.Drawing.Point(170, 130);
            this.txtDaniel.Name = "txtDaniel";
            this.txtDaniel.Size = new System.Drawing.Size(130, 20);
            this.txtDaniel.TabIndex = 2;

            // txtTotalCapital
            this.txtTotalCapital.Location = new System.Drawing.Point(170, 170);
            this.txtTotalCapital.Name = "txtTotalCapital";
            this.txtTotalCapital.ReadOnly = true;
            this.txtTotalCapital.Size = new System.Drawing.Size(130, 20);
            this.txtTotalCapital.TabIndex = 3;

            // txtPorcentajeJuan
            this.txtPorcentajeJuan.Location = new System.Drawing.Point(170, 210);
            this.txtPorcentajeJuan.Name = "txtPorcentajeJuan";
            this.txtPorcentajeJuan.ReadOnly = true;
            this.txtPorcentajeJuan.Size = new System.Drawing.Size(130, 20);
            this.txtPorcentajeJuan.TabIndex = 4;

            // txtPorcentajeRosa
            this.txtPorcentajeRosa.Location = new System.Drawing.Point(170, 250);
            this.txtPorcentajeRosa.Name = "txtPorcentajeRosa";
            this.txtPorcentajeRosa.ReadOnly = true;
            this.txtPorcentajeRosa.Size = new System.Drawing.Size(130, 20);
            this.txtPorcentajeRosa.TabIndex = 5;

            // txtPorcentajeDaniel
            this.txtPorcentajeDaniel.Location = new System.Drawing.Point(170, 290);
            this.txtPorcentajeDaniel.Name = "txtPorcentajeDaniel";
            this.txtPorcentajeDaniel.ReadOnly = true;
            this.txtPorcentajeDaniel.Size = new System.Drawing.Size(130, 20);
            this.txtPorcentajeDaniel.TabIndex = 6;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(130, 330);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // frm15
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPorcentajeDaniel);
            this.Controls.Add(this.txtPorcentajeRosa);
            this.Controls.Add(this.txtPorcentajeJuan);
            this.Controls.Add(this.txtTotalCapital);
            this.Controls.Add(this.txtDaniel);
            this.Controls.Add(this.txtRosa);
            this.Controls.Add(this.txtJuan);
            this.Name = "frm15";
            this.Text = "Cálculo de Participación en el Capital";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtJuan;
        private System.Windows.Forms.TextBox txtRosa;
        private System.Windows.Forms.TextBox txtDaniel;
        private System.Windows.Forms.TextBox txtTotalCapital;
        private System.Windows.Forms.TextBox txtPorcentajeJuan;
        private System.Windows.Forms.TextBox txtPorcentajeRosa;
        private System.Windows.Forms.TextBox txtPorcentajeDaniel;
        private System.Windows.Forms.Button btnCalcular;
    }
}
