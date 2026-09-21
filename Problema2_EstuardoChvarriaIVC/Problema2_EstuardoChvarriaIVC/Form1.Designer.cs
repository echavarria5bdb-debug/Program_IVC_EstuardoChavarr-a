namespace Problema2_EstuardoChvarriaIVC
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            label3 = new Label();
            txtSueldo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 93);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 151);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Cargo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(258, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(241, 148);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(228, 23);
            txtCargo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(151, 250);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(283, 250);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(420, 250);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 347);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 7;
            label3.Text = "Sueldo Correspondiente:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(294, 344);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(141, 23);
            txtSueldo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSueldo);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnSalir;
        private Label label3;
        private TextBox txtSueldo;
    }
}
