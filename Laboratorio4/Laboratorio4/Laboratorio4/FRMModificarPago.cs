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
    public partial class FRMModificarPago : Form
    {
        public FRMModificarPago()
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var gestor = new csPagos();
            bool exito = gestor.ModificarPago(
                int.Parse(txtIdPago.Text),
                int.Parse(txtIdCentro.Text),
                int.Parse(txtIdEstudiante.Text),
                dtpFechaPago.Text,
                txtGradoAcademico.Text
            );

            if (exito)
            {
                MessageBox.Show("Pago modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
