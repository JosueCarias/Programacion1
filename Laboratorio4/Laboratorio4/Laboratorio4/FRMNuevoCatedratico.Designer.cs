namespace Laboratorio4
{
    partial class FRMNuevoCatedratico
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
            txtEspecializacion = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.Location = new Point(130, 132);
            txtEspecializacion.Margin = new Padding(3, 2, 3, 2);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.Size = new Size(243, 23);
            txtEspecializacion.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 130);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 32;
            label5.Text = "Especializacion:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(205, 159);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 34);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(53, 159);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(130, 103);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(243, 23);
            txtTelefono.TabIndex = 23;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 76);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(243, 23);
            txtDireccion.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 49);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(53, 105);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 30;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(46, 76);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 29;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 49);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 28;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 27;
            label1.Text = "Datos Catedraticos";
            // 
            // FRMNuevoCatedratico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 221);
            Controls.Add(txtEspecializacion);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMNuevoCatedratico";
            Text = "Nuevo Catedratico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEspecializacion;
        private Label label5;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}