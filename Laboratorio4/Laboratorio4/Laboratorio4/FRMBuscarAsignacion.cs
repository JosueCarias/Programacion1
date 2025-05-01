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
    public partial class FRMBuscarAsignacion : Form
    {
        public FRMBuscarAsignacion()
        {
            InitializeComponent();
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
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
    }
}
