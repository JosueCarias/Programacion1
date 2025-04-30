using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    internal class csDetalleAsignacion
    {
        private string rutaArchivo = "detalle_asignacion.txt";
        private csCatedratico gestorCatedraticos = new csCatedratico();
        private csCurso gestorCursos = new csCurso();

        // Constructor: crea el archivo con encabezados si no existe
        public csDetalleAsignacion()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "ID_DETALLE_ASIGNACION,ID_CATEDRATICO,ID_CURSO,horario,dias_impartido\n");
            }
        }

        // Genera un nuevo ID (último ID + 1)
        private int GenerarNuevoId()
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1);
            return lineas.Any() ? lineas.Select(l => int.Parse(l.Split(',')[0])).Max() + 1 : 1;
        }

        // Valida que existan el catedrático y el curso
        private bool ValidarRelaciones(int idCatedratico, int idCurso)
        {
            return gestorCatedraticos.BuscarCatedraticoPorId(idCatedratico) != null
                   && gestorCursos.BuscarCursoPorId(idCurso) != null;
        }

        // Agrega una nueva asignación
        public void AgregarAsignacion(int idCatedratico, int idCurso, string horario, string diasImpartido)
        {
            try
            {
                if (!ValidarRelaciones(idCatedratico, idCurso))
                {
                    MessageBox.Show("El catedrático o el curso no existen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nuevoId = GenerarNuevoId();
                File.AppendAllText(rutaArchivo, $"{nuevoId},{idCatedratico},{idCurso},{horario},{diasImpartido}\n");
                MessageBox.Show("Asignación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Busca una asignación por ID
        public string[] BuscarAsignacionPorId(int id)
        {
            return File.ReadAllLines(rutaArchivo)
                .Skip(1)
                .FirstOrDefault(linea => int.Parse(linea.Split(',')[0]) == id)
                ?.Split(',');
        }

        // Modifica una asignación
        public bool ModificarAsignacion(int id, int idCatedratico, int idCurso, string horario, string diasImpartido)
        {
            try
            {
                if (!ValidarRelaciones(idCatedratico, idCurso))
                {
                    MessageBox.Show("El catedrático o el curso no existen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                for (int i = 1; i < lineas.Count; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    if (int.Parse(datos[0]) == id)
                    {
                        lineas[i] = $"{id},{idCatedratico},{idCurso},{horario},{diasImpartido}";
                        File.WriteAllLines(rutaArchivo, lineas);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Elimina una asignación
        public bool EliminarAsignacion(int id)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                for (int i = 1; i < lineas.Count; i++)
                {
                    if (int.Parse(lineas[i].Split(',')[0]) == id)
                    {
                        lineas.RemoveAt(i);
                        File.WriteAllLines(rutaArchivo, lineas);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
