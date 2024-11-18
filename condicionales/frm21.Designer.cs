namespace Condicionales
{
    partial class frm21
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNempleado;
        private Label lblEstadoCivil;
        private Label lblEdad;
        private Label lblSexo;
        private Label lblNempleado;
        private Button btnCalcular;

        private void InitializeComponent()
        {
            this.txtNempleado = new TextBox();
            this.lblEstadoCivil = new Label();
            this.lblEdad = new Label();
            this.lblSexo = new Label();
            this.lblNempleado = new Label();
            this.btnCalcular = new Button();

            this.SuspendLayout();

            // txtNempleado
            this.txtNempleado.Location = new System.Drawing.Point(180, 30);
            this.txtNempleado.Name = "txtNempleado";
            this.txtNempleado.Size = new System.Drawing.Size(100, 20);
            this.txtNempleado.TabIndex = 0;

            // lblEstadoCivil
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(50, 130);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(70, 13);
            this.lblEstadoCivil.TabIndex = 1;
            this.lblEstadoCivil.Text = "Estado Civil:";

            // lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(50, 170);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";

            // lblSexo
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(50, 210);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";

            // lblNempleado
            this.lblNempleado.AutoSize = true;
            this.lblNempleado.Location = new System.Drawing.Point(50, 30);
            this.lblNempleado.Name = "lblNempleado";
            this.lblNempleado.Size = new System.Drawing.Size(124, 13);
            this.lblNempleado.TabIndex = 4;
            this.lblNempleado.Text = "Número de empleado:";

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(120, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm21
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.txtNempleado);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNempleado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm21";
            this.Text = "Datos de Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
