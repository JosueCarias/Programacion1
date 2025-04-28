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
    public partial class FRMModificarEstudiante : Form
    {
        public FRMModificarEstudiante()
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

        private void btnModicar_Click(object sender, EventArgs e)
        {
            try
            {
                int carne = int.Parse(txtId.Text);
                var gestor = new csEstudiante();

                bool exito = gestor.ModificarEstudiante(
                    carne,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtFecha.Text, // Formato ISO
                    txtSexo.Text
                );

                if (exito)
                {
                    MessageBox.Show("¡Estudiante modificado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario si es necesario
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
