namespace Laboratorio4
{
    partial class FRMModificarCurso
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
            label4 = new Label();
            btnBuscar = new Button();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtModificar = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 51);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(243, 23);
            txtId.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(71, 51);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 35;
            label4.Text = "ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(214, 129);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(43, 129);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(105, 102);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 23);
            txtDescripcion.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 78);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(5, 103);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 31;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 30;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 28;
            label1.Text = "Datos Curso";
            // 
            // txtModificar
            // 
            txtModificar.Font = new Font("Segoe UI", 12F);
            txtModificar.Location = new Point(124, 167);
            txtModificar.Margin = new Padding(3, 2, 3, 2);
            txtModificar.Name = "txtModificar";
            txtModificar.Size = new Size(108, 34);
            txtModificar.TabIndex = 36;
            txtModificar.Text = "Modificar";
            txtModificar.UseVisualStyleBackColor = true;
            txtModificar.Click += txtModificar_Click;
            // 
            // FRMModificarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 213);
            Controls.Add(txtModificar);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMModificarCurso";
            Text = "Modificar Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label4;
        private Button btnBuscar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtModificar;
    }
}