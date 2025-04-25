namespace Laboratorio4
{
    partial class FRMModificarCentro
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
            label5 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            btnCancelar = new Button();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(78, 68);
            label5.Name = "label5";
            label5.Size = new Size(35, 28);
            label5.TabIndex = 30;
            label5.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(277, 27);
            txtId.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(251, 199);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 46);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(45, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 46);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(119, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(277, 27);
            txtTelefono.TabIndex = 26;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(119, 133);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(277, 27);
            txtDireccion.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 27);
            txtNombre.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 166);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 23;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 133);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 22;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 21;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 46);
            label1.TabIndex = 20;
            label1.Text = "Datos Centro Educativo";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(146, 251);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 46);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FRMModificarCentro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 316);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMModificarCentro";
            Text = "Modificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtId;
        private Button btnBuscar;
        private Button btnCancelar;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
    }
}