namespace Laboratorio4
{
    partial class FRMNuevaAsignacion
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
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtIdCatedratico = new TextBox();
            txtIdCurso = new TextBox();
            txtHorario = new TextBox();
            txtDias = new TextBox();
            txtCerrar = new Button();
            txtAsignar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Datos Asignacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 62);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 39;
            label4.Text = "ID Catedratico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(66, 118);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 38;
            label3.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 91);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 37;
            label2.Text = "ID Curso:";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(10, 147);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 40;
            label5.Text = "Dias Impartidos:";
            // 
            // txtIdCatedratico
            // 
            txtIdCatedratico.Location = new Point(138, 62);
            txtIdCatedratico.Name = "txtIdCatedratico";
            txtIdCatedratico.Size = new Size(202, 23);
            txtIdCatedratico.TabIndex = 41;
            // 
            // txtIdCurso
            // 
            txtIdCurso.Location = new Point(138, 91);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(202, 23);
            txtIdCurso.TabIndex = 42;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(138, 120);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(202, 23);
            txtHorario.TabIndex = 43;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(138, 149);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(202, 23);
            txtDias.TabIndex = 44;
            // 
            // txtCerrar
            // 
            txtCerrar.Font = new Font("Segoe UI", 11F);
            txtCerrar.Location = new Point(57, 187);
            txtCerrar.Name = "txtCerrar";
            txtCerrar.Size = new Size(97, 36);
            txtCerrar.TabIndex = 45;
            txtCerrar.Text = "Cerrar";
            txtCerrar.UseVisualStyleBackColor = true;
            txtCerrar.Click += txtCerrar_Click;
            // 
            // txtAsignar
            // 
            txtAsignar.Font = new Font("Segoe UI", 11F);
            txtAsignar.Location = new Point(188, 187);
            txtAsignar.Name = "txtAsignar";
            txtAsignar.Size = new Size(97, 36);
            txtAsignar.TabIndex = 46;
            txtAsignar.Text = "Asignar";
            txtAsignar.UseVisualStyleBackColor = true;
            txtAsignar.Click += txtAsignar_Click;
            // 
            // FRMNuevaAsignacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 250);
            Controls.Add(txtAsignar);
            Controls.Add(txtCerrar);
            Controls.Add(txtDias);
            Controls.Add(txtHorario);
            Controls.Add(txtIdCurso);
            Controls.Add(txtIdCatedratico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMNuevaAsignacion";
            Text = "Nueva Asignacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtIdCatedratico;
        private TextBox txtIdCurso;
        private TextBox txtHorario;
        private TextBox txtDias;
        private Button txtCerrar;
        private Button txtAsignar;
    }
}