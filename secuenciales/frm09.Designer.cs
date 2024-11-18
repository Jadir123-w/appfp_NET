namespace appfp_NET.secuenciales
{
    partial class frm09
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSuma = new TextBox();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            lblSumas = new Label();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // txtSuma
            // 
            txtSuma.AccessibleName = "txtSuma";
            txtSuma.Location = new Point(209, 105);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.AccessibleName = "txtNumero";
            txtNumero.Location = new Point(209, 62);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 14;
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(186, 169);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSumas
            // 
            lblSumas.AccessibleName = "lblSuma";
            lblSumas.AutoSize = true;
            lblSumas.Location = new Point(128, 113);
            lblSumas.Name = "lblSumas";
            lblSumas.Size = new Size(43, 15);
            lblSumas.TabIndex = 10;
            lblSumas.Tag = "Suma";
            lblSumas.Text = "Suma :";
            // 
            // lblNumero
            // 
            lblNumero.AccessibleName = " lblNumero";
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(96, 65);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(113, 15);
            lblNumero.TabIndex = 11;
            lblNumero.Tag = "numero";
            lblNumero.Text = "Numero de 4 cifras :";
            // 
            // frm09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 262);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lblSumas);
            Controls.Add(lblNumero);
            Name = "frm09";
            Text = "frm09";
            Load += frm09_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSuma;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblSumas;
        private Label lblNumero;
    }
}