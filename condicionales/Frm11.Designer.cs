namespace appfp_NET.secuenciales
{
    partial class Frm11
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
            txtSigno = new TextBox();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            lblSigno = new Label();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // txtSigno
            // 
            txtSigno.AccessibleName = "txtSuma";
            txtSigno.Location = new Point(185, 89);
            txtSigno.Name = "txtSigno";
            txtSigno.ReadOnly = true;
            txtSigno.Size = new Size(100, 23);
            txtSigno.TabIndex = 18;
            // 
            // txtNumero
            // 
            txtNumero.AccessibleName = "txtNumero";
            txtNumero.Location = new Point(185, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 19;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(162, 153);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSigno
            // 
            lblSigno.AccessibleName = "lblSuma";
            lblSigno.AutoSize = true;
            lblSigno.Location = new Point(104, 97);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(43, 15);
            lblSigno.TabIndex = 15;
            lblSigno.Tag = "Suma";
            lblSigno.Text = "Signo :";
            // 
            // lblNumero
            // 
            lblNumero.AccessibleName = " lblNumero";
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(90, 46);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Tag = "numero";
            lblNumero.Text = "Numero :";
            lblNumero.Click += lblNumero_Click;
            // 
            // Frm11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 224);
            Controls.Add(txtSigno);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lblSigno);
            Controls.Add(lblNumero);
            Name = "Frm11";
            Text = "Frm11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSigno;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblSigno;
        private Label lblNumero;
    }
}