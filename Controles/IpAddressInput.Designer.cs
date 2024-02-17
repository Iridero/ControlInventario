namespace Controles
{
    partial class IpAddressInput
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
            nmrOcteto4 = new NumericUpDown();
            nmrOcteto3 = new NumericUpDown();
            nmrOcteto2 = new NumericUpDown();
            nmrOcteto1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto1).BeginInit();
            SuspendLayout();
            // 
            // nmrOcteto4
            // 
            nmrOcteto4.Location = new Point(253, 1);
            nmrOcteto4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrOcteto4.Name = "nmrOcteto4";
            nmrOcteto4.Size = new Size(60, 27);
            nmrOcteto4.TabIndex = 0;
            nmrOcteto4.ValueChanged += nmrOcteto_ValueChanged;
            // 
            // nmrOcteto3
            // 
            nmrOcteto3.Location = new Point(169, 1);
            nmrOcteto3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrOcteto3.Name = "nmrOcteto3";
            nmrOcteto3.Size = new Size(60, 27);
            nmrOcteto3.TabIndex = 0;
            nmrOcteto3.ValueChanged += nmrOcteto_ValueChanged;
            // 
            // nmrOcteto2
            // 
            nmrOcteto2.Location = new Point(85, 1);
            nmrOcteto2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrOcteto2.Name = "nmrOcteto2";
            nmrOcteto2.Size = new Size(60, 27);
            nmrOcteto2.TabIndex = 0;
            nmrOcteto2.ValueChanged += nmrOcteto_ValueChanged;
            // 
            // nmrOcteto1
            // 
            nmrOcteto1.Location = new Point(1, 1);
            nmrOcteto1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nmrOcteto1.Name = "nmrOcteto1";
            nmrOcteto1.Size = new Size(60, 27);
            nmrOcteto1.TabIndex = 0;
            nmrOcteto1.ValueChanged += nmrOcteto_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 8);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 1;
            label1.Text = ".";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 8);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 2;
            label2.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 8);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 3;
            label3.Text = ".";
            // 
            // IpAddressInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrOcteto1);
            Controls.Add(nmrOcteto2);
            Controls.Add(nmrOcteto3);
            Controls.Add(nmrOcteto4);
            Name = "IpAddressInput";
            Size = new Size(315, 29);
            ((System.ComponentModel.ISupportInitialize)nmrOcteto4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrOcteto1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmrOcteto4;
        private NumericUpDown nmrOcteto3;
        private NumericUpDown nmrOcteto2;
        private NumericUpDown nmrOcteto1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
