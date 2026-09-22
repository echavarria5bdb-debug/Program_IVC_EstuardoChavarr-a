namespace Problema8_EstuardoChavarriaIVC
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
            grpAporteFamiliar = new GroupBox();
            grpAportaciones = new GroupBox();
            SuspendLayout();
            // 
            // grpAporteFamiliar
            // 
            grpAporteFamiliar.Location = new Point(88, 189);
            grpAporteFamiliar.Name = "grpAporteFamiliar";
            grpAporteFamiliar.Size = new Size(260, 131);
            grpAporteFamiliar.TabIndex = 0;
            grpAporteFamiliar.TabStop = false;
            grpAporteFamiliar.Text = "Aporte familiar";
            // 
            // grpAportaciones
            // 
            grpAportaciones.Location = new Point(410, 190);
            grpAportaciones.Name = "grpAportaciones";
            grpAportaciones.Size = new Size(269, 129);
            grpAportaciones.TabIndex = 1;
            grpAportaciones.TabStop = false;
            grpAportaciones.Text = "Aportaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAportaciones);
            Controls.Add(grpAporteFamiliar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAporteFamiliar;
        private GroupBox grpAportaciones;
    }
}
