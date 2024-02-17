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
            ipAddressInput1 = new IpAddressInput();
            lblIp = new Label();
            txtIp = new TextBox();
            btnAsignarIp = new Button();
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
            // ipAddressInput1
            // 
            ipAddressInput1.IpAddress = "0.0.0.0";
            ipAddressInput1.Location = new Point(368, 29);
            ipAddressInput1.Name = "ipAddressInput1";
            ipAddressInput1.Size = new Size(394, 36);
            ipAddressInput1.TabIndex = 2;
            ipAddressInput1.IpAddressChanged += ipAddressInput1_IpAddressChanged;
            // 
            // lblIp
            // 
            lblIp.Location = new Point(368, 67);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(311, 25);
            lblIp.TabIndex = 3;
            lblIp.Text = "label1";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(368, 95);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(205, 27);
            txtIp.TabIndex = 4;
            txtIp.Text = "192.168.0.254";
            // 
            // btnAsignarIp
            // 
            btnAsignarIp.Location = new Point(600, 93);
            btnAsignarIp.Name = "btnAsignarIp";
            btnAsignarIp.Size = new Size(94, 29);
            btnAsignarIp.TabIndex = 5;
            btnAsignarIp.Text = "Asignar IP";
            btnAsignarIp.UseVisualStyleBackColor = true;
            btnAsignarIp.Click += btnAsignarIp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAsignarIp);
            Controls.Add(txtIp);
            Controls.Add(lblIp);
            Controls.Add(ipAddressInput1);
            Controls.Add(rgbMixer1);
            Controls.Add(sexoControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SexoControl sexoControl1;
        private RgbMixer rgbMixer1;
        private IpAddressInput ipAddressInput1;
        private Label lblIp;
        private TextBox txtIp;
        private Button btnAsignarIp;
    }
}
