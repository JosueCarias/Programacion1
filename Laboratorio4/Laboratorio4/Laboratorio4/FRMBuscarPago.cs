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
    public partial class FRMBuscarPago : Form
    {
        public FRMBuscarPago()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPago.Text, out int idPago))
            {
                MessageBox.Show("Ingrese un ID de pago válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gestor = new csPagos();
            string[] pago = gestor.BuscarPagoPorId(idPago);

            if (pago != null)
            {
                txtIdCentro.Text = pago[1];
                txtIdEstudiante.Text = pago[2];
                dtpFechaPago.Text = pago[3];
                txtGradoAcademico.Text = pago[4];
            }
            else
            {
                MessageBox.Show("Pago no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
