namespace Laboratorio4
{
    partial class FRMBuscarAsignacion
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
            btnBuscar = new Button();
            btnCerrar = new Button();
            txtDias = new TextBox();
            txtHorario = new TextBox();
            txtIdCurso = new TextBox();
            txtIdCatedratico = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(186, 212);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 36);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += txtBuscar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 11F);
            btnCerrar.Location = new Point(55, 212);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 36);
            btnCerrar.TabIndex = 56;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += txtCerrar_Click;
            // 
            // txtDias
            // 
            txtDias.Enabled = false;
            txtDias.Location = new Point(136, 174);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(202, 23);
            txtDias.TabIndex = 55;
            // 
            // txtHorario
            // 
            txtHorario.Enabled = false;
            txtHorario.Location = new Point(136, 145);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(202, 23);
            txtHorario.TabIndex = 54;
            // 
            // txtIdCurso
            // 
            txtIdCurso.Enabled = false;
            txtIdCurso.Location = new Point(136, 116);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(202, 23);
            txtIdCurso.TabIndex = 53;
            // 
            // txtIdCatedratico
            // 
            txtIdCatedratico.Enabled = false;
            txtIdCatedratico.Location = new Point(136, 87);
            txtIdCatedratico.Name = "txtIdCatedratico";
            txtIdCatedratico.Size = new Size(202, 23);
            txtIdCatedratico.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 172);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 51;
            label5.Text = "Dias Impartidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 87);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 50;
            label4.Text = "ID Catedratico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(64, 143);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 49;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(57, 116);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 48;
            label2.Text = "ID Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 47;
            label1.Text = "Datos Asignacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(55, 58);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 58;
            label6.Text = "ID Curso:";
            // 
            // txtId
            // 
            txtId.Location = new Point(136, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 23);
            txtId.TabIndex = 59;
            // 
            // FRMBuscarAsignacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 270);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar);
            Controls.Add(txtDias);
            Controls.Add(txtHorario);
            Controls.Add(txtIdCurso);
            Controls.Add(txtIdCatedratico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMBuscarAsignacion";
            Text = "Buscar Asignacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnCerrar;
        private TextBox txtDias;
        private TextBox txtHorario;
        private TextBox txtIdCurso;
        private TextBox txtIdCatedratico;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtId;
    }
}