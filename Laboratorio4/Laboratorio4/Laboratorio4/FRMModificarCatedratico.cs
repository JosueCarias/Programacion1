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
    public partial class FRMModificarCatedratico : Form
    {
        public FRMModificarCatedratico()
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

            var gestor = new csCatedratico();
            string[] catedratico = gestor.BuscarCatedraticoPorId(id);

            if (catedratico != null)
            {
                txtNombre.Text = catedratico[1];
                txtDireccion.Text = catedratico[2];
                txtTelefono.Text = catedratico[3];
                txtEspecializacion.Text = catedratico[4];
            }
            else
            {
                MessageBox.Show("Catedrático no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gestor = new csCatedratico();
            bool exito = gestor.ModificarCatedratico(
                id,
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtEspecializacion.Text
            );

            if (exito)
            {
                MessageBox.Show("Catedrático modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el catedrático.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
