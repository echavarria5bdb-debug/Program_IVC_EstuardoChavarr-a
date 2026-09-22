namespace Problema7_EstuardoChavarriaIVC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblFecha = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtFecha = new TextBox();
            txtTelefono = new TextBox();
            chkJava = new CheckBox();
            chkSQLServer = new CheckBox();
            chkOracle = new CheckBox();
            chkCSharp = new CheckBox();
            this.lblResta = new Label();
            this.lblAPagar = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            txtAPagar = new TextBox();
            txtResta = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(173, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(111, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del cliente:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(173, 164);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(118, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha de inscripción:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(173, 226);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(110, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Número telefónico:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(287, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(297, 161);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(250, 23);
            txtFecha.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(287, 223);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 23);
            txtTelefono.TabIndex = 5;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(173, 278);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(51, 19);
            chkJava.TabIndex = 6;
            chkJava.Text = "JAVA";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkSQLServer
            // 
            chkSQLServer.AutoSize = true;
            chkSQLServer.Location = new Point(173, 353);
            chkSQLServer.Name = "chkSQLServer";
            chkSQLServer.Size = new Size(79, 19);
            chkSQLServer.TabIndex = 7;
            chkSQLServer.Text = "SQLServer";
            chkSQLServer.UseVisualStyleBackColor = true;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Location = new Point(173, 328);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(60, 19);
            chkOracle.TabIndex = 8;
            chkOracle.Text = "Oracle";
            chkOracle.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(173, 303);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(64, 19);
            chkCSharp.TabIndex = 9;
            chkCSharp.Text = "CSharp";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new Point(417, 354);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new Size(38, 15);
            this.lblResta.TabIndex = 10;
            this.lblResta.Text = "Resta:";
            // 
            // lblAPagar
            // 
            this.lblAPagar.AutoSize = true;
            this.lblAPagar.Location = new Point(417, 318);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.Size = new Size(51, 15);
            this.lblAPagar.TabIndex = 11;
            this.lblAPagar.Text = "A pagar:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(417, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total a Pagar:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(500, 274);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(172, 23);
            txtTotal.TabIndex = 13;
            // 
            // txtAPagar
            // 
            txtAPagar.Location = new Point(474, 310);
            txtAPagar.Name = "txtAPagar";
            txtAPagar.Size = new Size(198, 23);
            txtAPagar.TabIndex = 14;
            // 
            // txtResta
            // 
            txtResta.Location = new Point(461, 349);
            txtResta.Name = "txtResta";
            txtResta.Size = new Size(211, 23);
            txtResta.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(208, 398);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(434, 398);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtResta);
            Controls.Add(txtAPagar);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(this.lblAPagar);
            Controls.Add(this.lblResta);
            Controls.Add(chkCSharp);
            Controls.Add(chkOracle);
            Controls.Add(chkSQLServer);
            Controls.Add(chkJava);
            Controls.Add(txtTelefono);
            Controls.Add(txtFecha);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblFecha;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtFecha;
        private TextBox txtTelefono;
        private CheckBox chkJava;
        private CheckBox chkSQLServer;
        private CheckBox chkOracle;
        private CheckBox chkCSharp;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private TextBox txtTotal;
        private TextBox txtAPagar;
        private TextBox txtResta;
        private Button btnRegistrar;
        private Button btnLimpiar;
    }
}
