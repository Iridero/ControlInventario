namespace GaleriaDeImagenes
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
            txtRuta = new TextBox();
            btnCambiarRuta = new Button();
            flwImagenes = new FlowLayoutPanel();
            fldImagenes = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRuta.Location = new Point(12, 12);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(732, 27);
            txtRuta.TabIndex = 0;
            // 
            // btnCambiarRuta
            // 
            btnCambiarRuta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCambiarRuta.Location = new Point(750, 11);
            btnCambiarRuta.Name = "btnCambiarRuta";
            btnCambiarRuta.Size = new Size(38, 29);
            btnCambiarRuta.TabIndex = 1;
            btnCambiarRuta.Text = "...";
            btnCambiarRuta.UseVisualStyleBackColor = true;
            btnCambiarRuta.Click += btnCambiarRuta_Click;
            // 
            // flwImagenes
            // 
            flwImagenes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flwImagenes.Location = new Point(12, 45);
            flwImagenes.Name = "flwImagenes";
            flwImagenes.Size = new Size(776, 393);
            flwImagenes.TabIndex = 2;
            // 
            // fldImagenes
            // 
            fldImagenes.Description = "Selecciona una carpeta con imagenes";
            fldImagenes.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flwImagenes);
            Controls.Add(btnCambiarRuta);
            Controls.Add(txtRuta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRuta;
        private Button btnCambiarRuta;
        private FlowLayoutPanel flwImagenes;
        private FolderBrowserDialog fldImagenes;
    }
}
