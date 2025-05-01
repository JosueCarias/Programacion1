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
    public partial class FRMModificarAsignacion : Form
    {
        public FRMModificarAsignacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int idDetalle) ||
                !int.TryParse(txtIdCatedratico.Text, out int idCatedratico) ||
                !int.TryParse(txtIdCurso.Text, out int idCurso))
            {
                MessageBox.Show("Los IDs deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHorario.Text) || string.IsNullOrWhiteSpace(txtDias.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var gestor = new csDetalleAsignacion();
            bool exito = gestor.ModificarAsignacion(
                idDetalle,
                idCatedratico,
                idCurso,
                txtHorario.Text,
                txtDias.Text
            );

            if (exito)
            {
                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
