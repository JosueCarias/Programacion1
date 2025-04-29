namespace Laboratorio4
{
    partial class FRMEliminarCatedratico
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
            txtEliminar = new Button();
            txtId = new TextBox();
            label6 = new Label();
            txtEspecializacion = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
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
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Segoe UI", 12F);
            txtEliminar.Location = new Point(129, 229);
            txtEliminar.Margin = new Padding(3, 2, 3, 2);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(108, 34);
            txtEliminar.TabIndex = 73;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = true;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 54);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(243, 23);
            txtId.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(97, 54);
            label6.Name = "label6";
            label6.Size = new Size(26, 21);
            label6.TabIndex = 72;
            label6.Text = "Id:";
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.Location = new Point(129, 164);
            txtEspecializacion.Margin = new Padding(3, 2, 3, 2);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.Size = new Size(243, 23);
            txtEspecializacion.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(7, 162);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 71;
            label5.Text = "Especializacion:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(204, 191);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 65;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(52, 191);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(129, 135);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(243, 23);
            txtTelefono.TabIndex = 63;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(129, 108);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(243, 23);
            txtDireccion.TabIndex = 62;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 81);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(52, 137);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 69;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 108);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 68;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 67;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 66;
            label1.Text = "Datos Catedraticos";
            // 
            // FRMEliminarCatedratico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 278);
            Controls.Add(txtEliminar);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(txtEspecializacion);
            Controls.Add(label5);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMEliminarCatedratico";
            Text = "Eliminar Catedratico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtEliminar;
        private TextBox txtId;
        private Label label6;
        private TextBox txtEspecializacion;
        private Label label5;
        private Button btnBuscar;
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