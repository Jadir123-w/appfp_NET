namespace appfp_NET.secuenciales
{
    partial class frm01
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
            lblVarones = new Label();
            lblMujeres = new Label();
            lblPVarones = new Label();
            lblPMujeres = new Label();
            btnCalcular = new Button();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            SuspendLayout();
            // 
            // lblVarones
            // 
            lblVarones.AccessibleName = "lblVarones";
            lblVarones.AutoSize = true;
            lblVarones.Location = new Point(50, 50);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(48, 15);
            lblVarones.TabIndex = 0;
            lblVarones.Text = "Varones";
            lblVarones.Click += label_Click;
            // 
            // lblMujeres
            // 
            lblMujeres.AccessibleName = "lblMujeres";
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(50, 93);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(49, 15);
            lblMujeres.TabIndex = 0;
            lblMujeres.Text = "Mujeres";
            lblMujeres.Click += label1_Click;
            // 
            // lblPVarones
            // 
            lblPVarones.AccessibleName = " lblPVarones";
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(231, 50);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(17, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "%";
            // 
            // lblPMujeres
            // 
            lblPMujeres.AccessibleName = "lblPMujeres";
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(231, 93);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(17, 15);
            lblPMujeres.TabIndex = 0;
            lblPMujeres.Text = "%";
            lblPMujeres.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(102, 154);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // txtVarones
            // 
            txtVarones.AccessibleName = "txtVarones";
            txtVarones.Location = new Point(125, 47);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(100, 23);
            txtVarones.TabIndex = 2;
            txtVarones.TextChanged += textBox1_TextChanged;
            // 
            // txtMujeres
            // 
            txtMujeres.AccessibleName = "txtMujeres";
            txtMujeres.Location = new Point(125, 90);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(100, 23);
            txtMujeres.TabIndex = 2;
            txtMujeres.TextChanged += textBox2_TextChanged;
            // 
            // frm01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(btnCalcular);
            Controls.Add(lblPMujeres);
            Controls.Add(lblPVarones);
            Controls.Add(lblMujeres);
            Controls.Add(lblVarones);
            Name = "frm01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVarones;
        private Label lblMujeres;
        private Label lblPVarones;
        private Label lblPMujeres;
        private Button btnCalcular;
        private TextBox txtVarones;
        private TextBox txtMujeres;
    }
}