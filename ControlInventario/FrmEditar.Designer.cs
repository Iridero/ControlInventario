namespace ControlInventario
{
    partial class FrmEditar
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
            btnGuardar = new Button();
            btnCerrar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtExistencia = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(381, 144);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(281, 144);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 17;
            label4.Text = "Existencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 69);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 16;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 42);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 15;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(109, 93);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(125, 27);
            txtExistencia.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 66);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(109, 39);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(333, 27);
            txtDescripcion.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 10;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 194);
            Controls.Add(btnGuardar);
            Controls.Add(btnCerrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Name = "FrmEditar";
            Text = "FrmEditar";
            Load += FrmEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCerrar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtExistencia;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtId;
    }
}