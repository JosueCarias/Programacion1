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
    public partial class FRMEliminarCentro : Form
    {
        public FRMEliminarCentro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var gestor = new csCentroEducativo();
            string[] centro = gestor.BuscarCentroPorId(id);
            if (centro != null)
            {
                txtNombre.Text = centro[1];
                txtDireccion.Text = centro[2];
                txtTelefono.Text = centro[3];
            }
            else
            {
                MessageBox.Show("No se encontró el centro con ese ID.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var gestor = new csCentroEducativo();
            bool exito = gestor.EliminarCentro(id);

            if (exito)
            {
                MessageBox.Show("Centro eliminado correctamente.");
                txtNombre.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
            }
            else
            {
                MessageBox.Show("No se encontró el centro con ese ID.");
            }
        }
    }
}
