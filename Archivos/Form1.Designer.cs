namespace Archivos
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnBuscar = new Button();
            txtNombreBuscar = new TextBox();
            txtTelefonoBuscar = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(133, 45);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(133, 78);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(133, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(133, 147);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(125, 27);
            txtNombreBuscar.TabIndex = 4;
            // 
            // txtTelefonoBuscar
            // 
            txtTelefonoBuscar.Location = new Point(133, 215);
            txtTelefonoBuscar.Name = "txtTelefonoBuscar";
            txtTelefonoBuscar.Size = new Size(125, 27);
            txtTelefonoBuscar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefonoBuscar);
            Controls.Add(txtNombreBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtNombreBuscar;
        private TextBox txtTelefonoBuscar;
    }
}
