namespace Controles
{
    partial class RgbMixer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            nmrB = new NumericUpDown();
            nmrG = new NumericUpDown();
            nmrR = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlRgb = new Panel();
            ((System.ComponentModel.ISupportInitialize)nmrB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrR).BeginInit();
            SuspendLayout();
            // 
            // nmrB
            // 
            nmrB.Location = new Point(42, 69);
            nmrB.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrB.Name = "nmrB";
            nmrB.Size = new Size(58, 27);
            nmrB.TabIndex = 0;
            nmrB.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nmrB.ValueChanged += nmrValueChanged;
            // 
            // nmrG
            // 
            nmrG.Location = new Point(42, 36);
            nmrG.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrG.Name = "nmrG";
            nmrG.Size = new Size(58, 27);
            nmrG.TabIndex = 0;
            nmrG.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nmrG.ValueChanged += nmrValueChanged;
            // 
            // nmrR
            // 
            nmrR.Location = new Point(42, 3);
            nmrR.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrR.Name = "nmrR";
            nmrR.Size = new Size(58, 27);
            nmrR.TabIndex = 0;
            nmrR.Value = new decimal(new int[] { 255, 0, 0, 0 });
            nmrR.ValueChanged += nmrValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 1;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 1;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 71);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 1;
            label3.Text = "B";
            // 
            // pnlRgb
            // 
            pnlRgb.BackColor = Color.White;
            pnlRgb.Location = new Point(106, 3);
            pnlRgb.Name = "pnlRgb";
            pnlRgb.Size = new Size(85, 88);
            pnlRgb.TabIndex = 2;
            // 
            // RgbMixer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRgb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrR);
            Controls.Add(nmrG);
            Controls.Add(nmrB);
            Name = "RgbMixer";
            Size = new Size(208, 109);
            ((System.ComponentModel.ISupportInitialize)nmrB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrG).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmrB;
        private NumericUpDown nmrG;
        private NumericUpDown nmrR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlRgb;
    }
}
