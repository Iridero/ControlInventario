namespace Controles
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
            sexoControl1 = new SexoControl();
            rgbMixer1 = new RgbMixer();
            SuspendLayout();
            // 
            // sexoControl1
            // 
            sexoControl1.Location = new Point(12, 12);
            sexoControl1.Name = "sexoControl1";
            sexoControl1.Size = new Size(139, 75);
            sexoControl1.TabIndex = 0;
            sexoControl1.SexoCambiado += sexoControl1_SexoCambiado;
            // 
            // rgbMixer1
            // 
            rgbMixer1.Color = Color.Empty;
            rgbMixer1.Location = new Point(144, 29);
            rgbMixer1.Name = "rgbMixer1";
            rgbMixer1.Size = new Size(260, 136);
            rgbMixer1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rgbMixer1);
            Controls.Add(sexoControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private SexoControl sexoControl1;
        private RgbMixer rgbMixer1;
    }
}
