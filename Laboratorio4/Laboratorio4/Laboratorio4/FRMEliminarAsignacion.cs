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
    public partial class FRMEliminarAsignacion : Form
    {
        public FRMEliminarAsignacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var gestor = new csDetalleAsignacion();
            string[] asignacion = gestor.BuscarAsignacionPorId(int.Parse(txtId.Text));

            if (asignacion != null)
            {
                txtIdCatedratico.Text = asignacion[1];
                txtIdCurso.Text = asignacion[2];
                txtHorario.Text = asignacion[3];
                txtDias.Text = asignacion[4];
            }
            else
            {
                MessageBox.Show("Asignación no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Eliminar esta asignación?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (respuesta == DialogResult.Yes)
            {
                var gestor = new csDetalleAsignacion();
                if (gestor.EliminarAsignacion(int.Parse(txtId.Text)))
                {
                    MessageBox.Show("Asignación eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró la asignación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
