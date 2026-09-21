namespace Problema3_EstuardoChavarriaIVC
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
            components = new System.ComponentModel.Container();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblDescripcion = new Label();
            button1 = new Button();
            txtDescripcion = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(59, 17);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(124, 14);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(203, 23);
            txtNombres.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(59, 66);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(101, 63);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(59, 118);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 4;
            lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(110, 110);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(91, 23);
            txtSalario.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(59, 172);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion:";
            // 
            // button1
            // 
            button1.Location = new Point(56, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(137, 158);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(190, 56);
            txtDescripcion.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblDescripcion);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(lblSalario);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(lblNombres);
            groupBox1.Location = new Point(135, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 306);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos";
            // 
            // button2
            // 
            button2.Location = new Point(338, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Enviar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblDescripcion;
        private Button button1;
        private TextBox txtDescripcion;
        private GroupBox groupBox1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}
