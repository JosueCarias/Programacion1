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
    public partial class FRMModificarCurso : Form
    {
        public FRMModificarCurso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gestor = new csCurso();
            string[] curso = gestor.BuscarCursoPorId(id);

            if (curso != null)
            {
                txtNombre.Text = curso[1];
                txtDescripcion.Text = curso[2];
            }
            else
            {
                MessageBox.Show("Curso no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gestor = new csCurso();
            bool exito = gestor.ModificarCurso(
                id,
                txtNombre.Text,
                txtDescripcion.Text
            );

            if (exito)
            {
                MessageBox.Show("Curso modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
