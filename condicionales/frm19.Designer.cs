namespace Condicionales
{
    partial class frm19
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSexo;
        private TextBox txtEdad;
        private TextBox txtCate;
        private Label lblSexo;
        private Label lblEdad;
        private Label lblCategoria;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtSexo = new TextBox();
            this.txtEdad = new TextBox();
            this.txtCate = new TextBox();
            this.lblSexo = new Label();
            this.lblEdad = new Label();
            this.lblCategoria = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtSexo
            this.txtSexo.Location = new System.Drawing.Point(150, 50);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 0;

            // txtEdad
            this.txtEdad.Location = new System.Drawing.Point(150, 100);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;

            // txtCate
            this.txtCate.Location = new System.Drawing.Point(150, 150);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(100, 20);
            this.txtCate.TabIndex = 2;
            this.txtCate.ReadOnly = true;

            // lblSexo
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(50, 50);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(64, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo (M/F):";

            // lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(50, 100);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(50, 150);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(150, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm19
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCate);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm19";
            this.Text = "Categoría por Sexo y Edad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}