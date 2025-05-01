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
    public partial class FRMNuevoPago : Form
    {
        public FRMNuevoPago()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new csPagos();
            gestor.AgregarPago(
                int.Parse(txtIdCentro.Text),
                int.Parse(txtIdEstudiante.Text),
                dtpFechaPago.Text,
                txtGradoAcademico.Text
            );
        }
    }
}
