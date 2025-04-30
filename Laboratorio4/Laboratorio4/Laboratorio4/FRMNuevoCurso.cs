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
    public partial class FRMNuevoCurso : Form
    {
        public FRMNuevoCurso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new csCurso();
            gestor.AgregarCurso(
                txtNombre.Text,
                txtDescripcion.Text
            );
            this.Close();
        }
    }
}
