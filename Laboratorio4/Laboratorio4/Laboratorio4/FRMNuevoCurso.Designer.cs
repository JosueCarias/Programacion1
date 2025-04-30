namespace Laboratorio4
{
    partial class FRMNuevoCurso
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(219, 102);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(48, 102);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(110, 75);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 23);
            txtDescripcion.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 51);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(10, 76);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 12;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 9;
            label1.Text = "Datos Curso";
            // 
            // FRMNuevoCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 165);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMNuevoCurso";
            Text = "Nuevo Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}