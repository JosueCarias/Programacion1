﻿namespace Laboratorio4
{
    partial class FRMEliminarEstudiante
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
            btnEliminar = new Button();
            txtId = new TextBox();
            label7 = new Label();
            txtSexo = new TextBox();
            label6 = new Label();
            txtFecha = new TextBox();
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
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(172, 250);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 34);
            btnEliminar.TabIndex = 67;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 48);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(243, 23);
            txtId.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(138, 46);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 66;
            label7.Text = "ID:";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(172, 185);
            txtSexo.Margin = new Padding(3, 2, 3, 2);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(243, 23);
            txtSexo.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(123, 183);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 65;
            label6.Text = "Sexo";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(172, 158);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(243, 23);
            txtFecha.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 156);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 64;
            label5.Text = "Fecha De Nacimiento:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(266, 212);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 58;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(88, 212);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 63;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(172, 129);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(243, 23);
            txtTelefono.TabIndex = 55;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(172, 102);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(243, 23);
            txtDireccion.TabIndex = 54;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 75);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(95, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 62;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(88, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 61;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(95, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 60;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 37);
            label1.TabIndex = 59;
            label1.Text = "Datos Estudiante";
            // 
            // FRMEliminarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 302);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(txtSexo);
            Controls.Add(label6);
            Controls.Add(txtFecha);
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
            Name = "FRMEliminarEstudiante";
            Text = "Eliminar Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private TextBox txtId;
        private Label label7;
        private TextBox txtSexo;
        private Label label6;
        private TextBox txtFecha;
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