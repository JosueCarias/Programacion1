namespace Laboratorio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FRMNuevoCentro nuevo = new FRMNuevoCentro();
            nuevo.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMBuscarCentro buscarCentro = new FRMBuscarCentro();
            buscarCentro.Show();
        }

        private void modificarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FRMModificarCentro modificar = new FRMModificarCentro();
            modificar.Show();
        }

        private void eliminarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FRMEliminarCentro eliminar = new FRMEliminarCentro();
            eliminar.Show();
        }
    }
}
