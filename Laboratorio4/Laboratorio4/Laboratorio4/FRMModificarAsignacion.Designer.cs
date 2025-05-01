namespace Laboratorio4
{
    partial class FRMModificarAsignacion
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
            btnModificar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(137, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 23);
            txtId.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(56, 58);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 71;
            label6.Text = "ID Curso:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 11F);
            btnBuscar.Location = new Point(187, 212);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 36);
            btnBuscar.TabIndex = 70;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 11F);
            btnCerrar.Location = new Point(56, 212);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 36);
            btnCerrar.TabIndex = 69;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(137, 174);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(202, 23);
            txtDias.TabIndex = 68;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(137, 145);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(202, 23);
            txtHorario.TabIndex = 67;
            // 
            // txtIdCurso
            // 
            txtIdCurso.Location = new Point(137, 116);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(202, 23);
            txtIdCurso.TabIndex = 66;
            // 
            // txtIdCatedratico
            // 
            txtIdCatedratico.Location = new Point(137, 87);
            txtIdCatedratico.Name = "txtIdCatedratico";
            txtIdCatedratico.Size = new Size(202, 23);
            txtIdCatedratico.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 172);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 64;
            label5.Text = "Dias Impartidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(20, 87);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 63;
            label4.Text = "ID Catedratico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(65, 143);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 62;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(58, 116);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 61;
            label2.Text = "ID Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 60;
            label1.Text = "Datos Asignacion";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11F);
            btnModificar.Location = new Point(124, 254);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 36);
            btnModificar.TabIndex = 73;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // FRMModificarAsignacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 317);
            Controls.Add(btnModificar);
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
            Name = "FRMModificarAsignacion";
            Text = "Modificar Asignacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label6;
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
        private Button btnModificar;
    }
}