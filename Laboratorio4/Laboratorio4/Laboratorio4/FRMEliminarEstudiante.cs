using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio4
{
    public partial class FRMEliminarEstudiante : Form
    {
        public FRMEliminarEstudiante()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int carne = int.Parse(txtId.Text);
            var gestor = new csEstudiante();
            string[] estudiante = gestor.BuscarEstudiantePorCarne(carne);

            if (estudiante != null)
            {
                txtNombre.Text = estudiante[1];
                txtDireccion.Text = estudiante[2];
                txtTelefono.Text = estudiante[3];
                txtFecha.Text = estudiante[4];
                txtSexo.Text = estudiante[5];
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int carne))
            {
                MessageBox.Show("Ingrese un carné válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este estudiante?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                var gestor = new csEstudiante();
                bool exito = gestor.EliminarEstudiante(carne);

                if (exito)
                {
                    MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtFecha.Clear();
                    txtSexo.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
