namespace Repetitivos
{
    partial class frm04
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private TextBox txtCantidad;
        private TextArea txtResultado;
        private Button btnCalcular;
        private Label lblNumero;
        private Label lblCantidad;

        private void InitializeComponent()
        {
            this.txtNumero = new TextBox();
            this.txtCantidad = new TextBox();
            this.txtResultado = new TextArea();
            this.btnCalcular = new Button();
            this.lblNumero = new Label();
            this.lblCantidad = new Label();

            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número (n):";

            // lblCantidad
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad (m):";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(140, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;

            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(140, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(30, 160);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(320, 80);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.ReadOnly = true;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(140, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // frm04
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCantidad);
            this.Name = "frm04";
            this.Text = "Primeros Múltiplos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
