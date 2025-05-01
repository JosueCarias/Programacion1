namespace Laboratorio4
{
    partial class FRMEliminarPago
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
            txtIdPago = new TextBox();
            label2 = new Label();
            txtGradoAcademico = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
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
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(144, 225);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 34);
            btnEliminar.TabIndex = 84;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnModificar_Click;
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(144, 48);
            txtIdPago.Margin = new Padding(3, 2, 3, 2);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(243, 23);
            txtIdPago.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(78, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 83;
            label2.Text = "IdPago:";
            // 
            // txtGradoAcademico
            // 
            txtGradoAcademico.Location = new Point(144, 158);
            txtGradoAcademico.Margin = new Padding(3, 2, 3, 2);
            txtGradoAcademico.Name = "txtGradoAcademico";
            txtGradoAcademico.Size = new Size(243, 23);
            txtGradoAcademico.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 158);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 82;
            label5.Text = "Grado Academico:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(226, 187);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 76;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(53, 187);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(144, 129);
            dtpFechaPago.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(243, 23);
            dtpFechaPago.TabIndex = 74;
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(144, 102);
            txtIdEstudiante.Margin = new Padding(3, 2, 3, 2);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(243, 23);
            txtIdEstudiante.TabIndex = 73;
            // 
            // txtIdCentro
            // 
            txtIdCentro.Location = new Point(144, 75);
            txtIdCentro.Margin = new Padding(3, 2, 3, 2);
            txtIdCentro.Name = "txtIdCentro";
            txtIdCentro.Size = new Size(243, 23);
            txtIdCentro.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(47, 131);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 80;
            label4.Text = "Fecha Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 104);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 79;
            label3.Text = "IdEstudiante:";
            // 
            // IdCentro
            // 
            IdCentro.AutoSize = true;
            IdCentro.Font = new Font("Segoe UI", 12F);
            IdCentro.Location = new Point(65, 77);
            IdCentro.Name = "IdCentro";
            IdCentro.Size = new Size(73, 21);
            IdCentro.TabIndex = 78;
            IdCentro.Text = "IdCentro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 77;
            label1.Text = "Datos Pagos";
            // 
            // FRMEliminarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 271);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdPago);
            Controls.Add(label2);
            Controls.Add(txtGradoAcademico);
            Controls.Add(label5);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpFechaPago);
            Controls.Add(txtIdEstudiante);
            Controls.Add(txtIdCentro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(IdCentro);
            Controls.Add(label1);
            Name = "FRMEliminarPago";
            Text = "Eliminar Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private TextBox txtIdPago;
        private Label label2;
        private TextBox txtGradoAcademico;
        private Label label5;
        private Button btnBuscar;
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