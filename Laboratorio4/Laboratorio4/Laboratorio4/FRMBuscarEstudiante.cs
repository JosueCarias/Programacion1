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
    public partial class FRMBuscarEstudiante : Form
    {
        public FRMBuscarEstudiante()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int carne = int.Parse(txtId.Text);
            var gestor = new csEstudiante();
            string[] estudiante = gestor.BuscarEstudiantePorCarne(carne);

            if (estudiante != null)
            {
                txtNombre.Text = estudiante[1];
                txtDireccion.Text = estudiante[2];
                txtTelefono.Text = estudiante[3];
                txtFecha.Text = estudiante[4];
                txtSexo.Text = estudiante[5];
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
