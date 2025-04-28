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
    public partial class FRMNuevoEstudiante : Form
    {
        public FRMNuevoEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new csEstudiante();
            gestor.AgregarEstudiante(
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtFecha.Text, // Formato fecha
                txtSexo.Text
            );
            MessageBox.Show("Estudiante guardado.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
