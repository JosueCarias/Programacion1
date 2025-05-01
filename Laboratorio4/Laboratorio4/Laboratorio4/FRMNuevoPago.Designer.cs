namespace Laboratorio4
{
    partial class FRMNuevoPago
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
            txtGradoAcademico = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dtpFechaPago = new TextBox();
            txtIdEstudiante = new TextBox();
            txtIdCentro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            IdCentro = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtGradoAcademico
            // 
            txtGradoAcademico.Location = new Point(142, 130);
            txtGradoAcademico.Margin = new Padding(3, 2, 3, 2);
            txtGradoAcademico.Name = "txtGradoAcademico";
            txtGradoAcademico.Size = new Size(243, 23);
            txtGradoAcademico.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 130);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 43;
            label5.Text = "Grado Academico:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(203, 159);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 34);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(51, 159);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(142, 101);
            dtpFechaPago.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(243, 23);
            dtpFechaPago.TabIndex = 35;
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(142, 74);
            txtIdEstudiante.Margin = new Padding(3, 2, 3, 2);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(243, 23);
            txtIdEstudiante.TabIndex = 34;
            // 
            // txtIdCentro
            // 
            txtIdCentro.Location = new Point(142, 47);
            txtIdCentro.Margin = new Padding(3, 2, 3, 2);
            txtIdCentro.Name = "txtIdCentro";
            txtIdCentro.Size = new Size(243, 23);
            txtIdCentro.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(45, 103);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 41;
            label4.Text = "Fecha Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 40;
            label3.Text = "IdEstudiante:";
            // 
            // IdCentro
            // 
            IdCentro.AutoSize = true;
            IdCentro.Font = new Font("Segoe UI", 12F);
            IdCentro.Location = new Point(63, 49);
            IdCentro.Name = "IdCentro";
            IdCentro.Size = new Size(73, 21);
            IdCentro.TabIndex = 39;
            IdCentro.Text = "IdCentro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 38;
            label1.Text = "Datos Pagos";
            // 
            // FRMNuevoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 226);
            Controls.Add(txtGradoAcademico);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtIdEstudiante);
            Controls.Add(txtIdCentro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(IdCentro);
            Controls.Add(label1);
            Name = "FRMNuevoPago";
            Text = "Nuevo Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGradoAcademico;
        private Label label5;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox dtpFechaPago;
        private TextBox txtIdEstudiante;
        private TextBox txtIdCentro;
        private Label label4;
        private Label label3;
        private Label IdCentro;
        private Label label1;
    }
}