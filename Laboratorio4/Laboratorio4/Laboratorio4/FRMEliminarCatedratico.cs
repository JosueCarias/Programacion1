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
    public partial class FRMEliminarCatedratico : Form
    {
        public FRMEliminarCatedratico()
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

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este catedrático?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                var gestor = new csCatedratico();
                bool exito = gestor.EliminarCatedratico(id);

                if (exito)
                {
                    MessageBox.Show("Catedrático eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEspecializacion.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró el catedrático.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
