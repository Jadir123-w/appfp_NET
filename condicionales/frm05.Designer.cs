namespace appfp_NET.condicionales
{
    partial class frm05
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNumero;
        private TextBox txtResultado;
        private Label lblNumero;
        private Button btnCalcular;

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
            this.lblNumero = new Label();
            this.txtNumero = new TextBox();
            this.txtResultado = new TextBox();
            this.btnCalcular = new Button();

            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(250, 15);
            this.lblNumero.Text = "Digita un número de 4 cifras:";

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(50, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TextAlign = HorizontalAlignment.Right;

            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 110);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(300, 50);
            this.txtResultado.Multiline = true;
            this.txtResultado.ReadOnly = true;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(160, 70);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 30);
            this.btnCalcular.Text = "Mayor número";
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // 
            // frm05
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frm05";
            this.Text = "Mayor número posible";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
