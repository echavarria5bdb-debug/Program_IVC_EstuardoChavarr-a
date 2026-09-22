namespace Problema4_EstuardoChavarriaIVC
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
            label3 = new Label();
            label4 = new Label();
            this.txtNombre = new TextBox();
            this.txtApellidoPaterno = new TextBox();
            this.txtNombreCompleto = new TextBox();
            this.txtApellidoMaterno = new TextBox();
            btnConcatenar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 80);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 129);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 175);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 223);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new Point(276, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(185, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new Point(320, 121);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new Size(141, 23);
            this.txtApellidoPaterno.TabIndex = 5;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new Point(216, 250);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new Size(245, 23);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new Point(324, 172);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new Size(141, 23);
            this.txtApellidoMaterno.TabIndex = 7;
            // 
            // btnConcatenar
            // 
            btnConcatenar.Location = new Point(191, 314);
            btnConcatenar.Name = "btnConcatenar";
            btnConcatenar.Size = new Size(79, 51);
            btnConcatenar.TabIndex = 8;
            btnConcatenar.Text = "Concatenar Datos";
            btnConcatenar.UseVisualStyleBackColor = true;
            btnConcatenar.Click += btnConcatenar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 318);
            button2.Name = "button2";
            button2.Size = new Size(85, 43);
            button2.TabIndex = 9;
            button2.Text = "Nuevos Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(623, 224);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(507, 314);
            button4.Name = "button4";
            button4.Size = new Size(96, 47);
            button4.TabIndex = 11;
            button4.Text = "Salir del Programa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnConcatenar);
            Controls.Add(this.txtApellidoMaterno);
            Controls.Add(this.txtNombreCompleto);
            Controls.Add(this.txtApellidoPaterno);
            Controls.Add(this.txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnConcatenar;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
