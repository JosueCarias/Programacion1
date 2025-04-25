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
    public partial class FRMNuevoCentro : Form
    {
        public FRMNuevoCentro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new csCentroEducativo();
            gestor.AgregarCentro(
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text
            );
            MessageBox.Show("Se ha guardado el centro");
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
