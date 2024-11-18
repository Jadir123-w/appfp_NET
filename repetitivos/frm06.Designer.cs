namespace Repetitivos
{
    partial class frm06
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNumero;
        private TextBox txtInicio;
        private TextBox txtFin;
        private TextBox txtResultado;
        private Button btnGenerar;
        private Label lblNumero;
        private Label lblInicio;
        private Label lblFin;

        private void InitializeComponent()
        {
            this.txtNumero = new TextBox();
            this.txtInicio = new TextBox();
            this.txtFin = new TextBox();
            this.txtResultado = new TextBox();
            this.btnGenerar = new Button();
            this.lblNumero = new Label();
            this.lblInicio = new Label();
            this.lblFin = new Label();

            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(140, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;

            // lblInicio
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(30, 70);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(60, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Inicio desde:";

            // txtInicio
            this.txtInicio.Location = new System.Drawing.Point(140, 70);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 3;

            // lblFin
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(30, 110);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(60, 13);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Fin hasta:";

            // txtFin
            this.txtFin.Location = new System.Drawing.Point(140, 110);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 5;

            // txtResultado
            this.txtResultado.Location = new System.Drawing.Point(30, 190);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(320, 200);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.ReadOnly = true;

            // btnGenerar
            this.btnGenerar.Location = new System.Drawing.Point(140, 150);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 30);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);

            // frm06
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblFin);
            this.Name = "frm06";
            this.Text = "Tabla de Multiplicar con Rango";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
