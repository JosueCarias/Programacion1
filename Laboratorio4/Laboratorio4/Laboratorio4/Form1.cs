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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMNuevoEstudiante nuevoEstudiante = new FRMNuevoEstudiante();
            nuevoEstudiante.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMBuscarEstudiante buscarEstudiante = new FRMBuscarEstudiante();
            buscarEstudiante.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMModificarEstudiante modificarEstudiante = new FRMModificarEstudiante();
            modificarEstudiante.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMEliminarEstudiante eliminarEstudiante = new FRMEliminarEstudiante();
            eliminarEstudiante.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMNuevoCatedratico nuevoCatedratico = new FRMNuevoCatedratico();
            nuevoCatedratico.Show();
        }

        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMBuscarCatedratico buscarCatedratico = new FRMBuscarCatedratico();
            buscarCatedratico.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMModificarCatedratico modificarCatedratico = new FRMModificarCatedratico();
            modificarCatedratico.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMEliminarCatedratico eliminarCatedratico = new FRMEliminarCatedratico();
            eliminarCatedratico.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMNuevoCurso nuevoCurso = new FRMNuevoCurso();
            nuevoCurso.Show();
        }

        private void busquedaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMBuscarCurso buscarCurso = new FRMBuscarCurso();
            buscarCurso.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMModificarCurso modificarCurso = new FRMModificarCurso();
            modificarCurso.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMEliminarCurso eliminarCurso = new FRMEliminarCurso();
            eliminarCurso.Show();
        }
    }
}
