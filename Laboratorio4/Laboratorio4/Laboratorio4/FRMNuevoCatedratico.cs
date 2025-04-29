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
    public partial class FRMNuevoCatedratico : Form
    {
        public FRMNuevoCatedratico()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new csCatedratico();
            gestor.AgregarCatedratico(
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtEspecializacion.Text
            );
            this.Close();
        }
    }
}
