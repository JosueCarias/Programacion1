namespace Laboratorio4
{
    partial class FRMEliminarCurso
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
            txtEliminar = new Button();
            txtId = new TextBox();
            label4 = new Label();
            btnBuscar = new Button();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Segoe UI", 12F);
            txtEliminar.Location = new Point(125, 167);
            txtEliminar.Margin = new Padding(3, 2, 3, 2);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(108, 34);
            txtEliminar.TabIndex = 46;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = true;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(106, 51);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(243, 23);
            txtId.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(72, 51);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 45;
            label4.Text = "ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(215, 129);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 34);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(44, 129);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 102);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 23);
            txtDescripcion.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 78);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 23);
            txtNombre.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 41;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 40;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 38;
            label1.Text = "Datos Curso";
            // 
            // FRMEliminarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEliminar);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMEliminarCurso";
            Text = "Eliminar Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtEliminar;
        private TextBox txtId;
        private Label label4;
        private Button btnBuscar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}