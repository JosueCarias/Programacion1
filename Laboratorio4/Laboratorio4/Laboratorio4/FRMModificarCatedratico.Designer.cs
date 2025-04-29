namespace Laboratorio4
{
    partial class FRMModificarCatedratico
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
            txtModificar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 54);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(243, 23);
            txtId.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(96, 54);
            label6.Name = "label6";
            label6.Size = new Size(26, 21);
            label6.TabIndex = 58;
            label6.Text = "Id:";
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.Location = new Point(128, 164);
            txtEspecializacion.Margin = new Padding(3, 2, 3, 2);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.Size = new Size(243, 23);
            txtEspecializacion.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 57;
            label5.Text = "Especializacion:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(203, 191);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 51;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(51, 191);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(128, 135);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(243, 23);
            txtTelefono.TabIndex = 49;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 108);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(243, 23);
            txtDireccion.TabIndex = 48;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 81);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(51, 137);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 55;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(44, 108);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 54;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(51, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 53;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 52;
            label1.Text = "Datos Catedraticos";
            // 
            // txtModificar
            // 
            txtModificar.Font = new Font("Segoe UI", 12F);
            txtModificar.Location = new Point(128, 229);
            txtModificar.Margin = new Padding(3, 2, 3, 2);
            txtModificar.Name = "txtModificar";
            txtModificar.Size = new Size(108, 34);
            txtModificar.TabIndex = 59;
            txtModificar.Text = "Modificar";
            txtModificar.UseVisualStyleBackColor = true;
            txtModificar.Click += txtEliminar_Click;
            // 
            // FRMModificarCatedratico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 273);
            Controls.Add(txtModificar);
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
            Name = "FRMModificarCatedratico";
            Text = "Modificar Catedratico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button txtModificar;
    }
}