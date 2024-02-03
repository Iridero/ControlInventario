namespace ControlInventario
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtExistencia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCerrar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(113, 45);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(333, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(113, 72);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(113, 99);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(125, 27);
            txtExistencia.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Existencia";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(285, 150);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(385, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAgregar
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCerrar;
            ClientSize = new Size(491, 191);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmAgregar";
            Text = "Nuevo artículo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtExistencia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCerrar;
        private Button btnAgregar;
    }
}