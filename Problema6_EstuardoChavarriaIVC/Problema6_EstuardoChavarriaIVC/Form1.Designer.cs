namespace Problema6_EstuardoChavarriaIVC
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
            lblPantalla = new Label();
            btnSubirVolumen = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblPantalla
            // 
            lblPantalla.AutoSize = true;
            lblPantalla.Location = new Point(329, 75);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(77, 15);
            lblPantalla.TabIndex = 0;
            lblPantalla.Text = "TV APAGADA";
            lblPantalla.Click += label1_Click;
            // 
            // btnSubirVolumen
            // 
            btnSubirVolumen.Location = new Point(254, 149);
            btnSubirVolumen.Name = "btnSubirVolumen";
            btnSubirVolumen.Size = new Size(75, 23);
            btnSubirVolumen.TabIndex = 1;
            btnSubirVolumen.Text = "+Volumen";
            btnSubirVolumen.UseVisualStyleBackColor = true;
            btnSubirVolumen.Click += btnSubirVolumen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(311, 104);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 2;
            button1.Text = "Encender/Apagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(441, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "+ Canal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(441, 197);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "- Canal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(254, 197);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "- Volumen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(352, 308);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSubirVolumen);
            Controls.Add(lblPantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPantalla;
        private Button btnSubirVolumen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
