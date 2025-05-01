using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    internal class csPagos
    {
        private string rutaArchivo = "pagos.csv";
        private csCentroEducativo gestorCentros = new csCentroEducativo();
        private csEstudiante gestorEstudiantes = new csEstudiante();

        // Constructor: crea el archivo con encabezados si no existe
        public csPagos()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "ID_PAGO,ID_CENTRO_EDUCATIVO,ID_ESTUDIANTE,fecha_pago,grado_academico\n");
            }
        }

        // Genera un nuevo ID_PAGO (último ID + 1)
        private int GenerarNuevoId()
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1);
            return lineas.Any() ? lineas.Select(l => int.Parse(l.Split(',')[0])).Max() + 1 : 1;
        }

        // Valida que existan el centro educativo y el estudiante
        private bool ValidarRelaciones(int idCentro, int idEstudiante)
        {
            return gestorCentros.BuscarCentroPorId(idCentro) != null
                   && gestorEstudiantes.BuscarEstudiantePorCarne(idEstudiante) != null;
        }

        // Agrega un nuevo pago
        public void AgregarPago(int idCentro, int idEstudiante, string fechaPago, string gradoAcademico)
        {
            try
            {
                if (!ValidarRelaciones(idCentro, idEstudiante))
                {
                    MessageBox.Show("Error: El centro educativo o el estudiante no existen.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nuevoId = GenerarNuevoId();
                string nuevaLinea = $"{nuevoId},{idCentro},{idEstudiante},{fechaPago},{gradoAcademico}\n";
                File.AppendAllText(rutaArchivo, nuevaLinea);
                MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Busca un pago por ID_PAGO
        public string[] BuscarPagoPorId(int idPago)
        {
            return File.ReadAllLines(rutaArchivo)
                .Skip(1)
                .FirstOrDefault(linea => int.Parse(linea.Split(',')[0]) == idPago)
                ?.Split(',');
        }

        // Modifica un pago existente
        public bool ModificarPago(int idPago, int idCentro, int idEstudiante, string fechaPago, string gradoAcademico)
        {
            try
            {
                if (!ValidarRelaciones(idCentro, idEstudiante))
                {
                    MessageBox.Show("Error: El centro educativo o el estudiante no existen.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                for (int i = 1; i < lineas.Count; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    if (int.Parse(datos[0]) == idPago)
                    {
                        lineas[i] = $"{idPago},{idCentro},{idEstudiante},{fechaPago},{gradoAcademico}";
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

        // Elimina un pago por ID_PAGO
        public bool EliminarPago(int idPago)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                for (int i = 1; i < lineas.Count; i++)
                {
                    if (int.Parse(lineas[i].Split(',')[0]) == idPago)
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
