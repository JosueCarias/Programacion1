namespace Laboratorio4
{
    partial class FRMBuscarPago
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
            btnBuscar = new Button();
            btnCancelar = new Button();
            dtpFechaPago = new TextBox();
            txtIdEstudiante = new TextBox();
            txtIdCentro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            IdCentro = new Label();
            label1 = new Label();
            txtIdPago = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtGradoAcademico
            // 
            txtGradoAcademico.Enabled = false;
            txtGradoAcademico.Location = new Point(140, 158);
            txtGradoAcademico.Margin = new Padding(3, 2, 3, 2);
            txtGradoAcademico.Name = "txtGradoAcademico";
            txtGradoAcademico.Size = new Size(243, 23);
            txtGradoAcademico.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(4, 158);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 54;
            label5.Text = "Grado Academico:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(201, 187);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 48;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(49, 187);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Enabled = false;
            dtpFechaPago.Location = new Point(140, 129);
            dtpFechaPago.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(243, 23);
            dtpFechaPago.TabIndex = 46;
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Enabled = false;
            txtIdEstudiante.Location = new Point(140, 102);
            txtIdEstudiante.Margin = new Padding(3, 2, 3, 2);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(243, 23);
            txtIdEstudiante.TabIndex = 45;
            // 
            // txtIdCentro
            // 
            txtIdCentro.Enabled = false;
            txtIdCentro.Location = new Point(140, 75);
            txtIdCentro.Margin = new Padding(3, 2, 3, 2);
            txtIdCentro.Name = "txtIdCentro";
            txtIdCentro.Size = new Size(243, 23);
            txtIdCentro.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(43, 131);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 52;
            label4.Text = "Fecha Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 104);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 51;
            label3.Text = "IdEstudiante:";
            // 
            // IdCentro
            // 
            IdCentro.AutoSize = true;
            IdCentro.Font = new Font("Segoe UI", 12F);
            IdCentro.Location = new Point(61, 77);
            IdCentro.Name = "IdCentro";
            IdCentro.Size = new Size(73, 21);
            IdCentro.TabIndex = 50;
            IdCentro.Text = "IdCentro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 49;
            label1.Text = "Datos Pagos";
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(140, 48);
            txtIdPago.Margin = new Padding(3, 2, 3, 2);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(243, 23);
            txtIdPago.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(74, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 56;
            label2.Text = "IdPago:";
            // 
            // FRMBuscarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 240);
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
            Name = "FRMBuscarPago";
            Text = "Buscar Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtIdPago;
        private Label label2;
    }
}