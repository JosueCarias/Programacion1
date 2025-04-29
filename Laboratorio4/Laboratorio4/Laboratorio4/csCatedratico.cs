using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laboratorio4
{
    internal class csCatedratico
    {
        private string rutaArchivo = "catedratico.txt";

        // Constructor: crea el archivo con encabezados si no existe
        public csCatedratico()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "id_catedratico,nombre,direccion,telefono,especializacion\n");
            }
        }

        // Genera un nuevo ID (último ID + 1)
        private int GenerarNuevoId()
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezado
            if (!lineas.Any()) return 1; // Si no hay datos, empezar con 1

            int ultimoId = lineas
                .Select(linea => int.Parse(linea.Split(',')[0]))
                .Max();

            return ultimoId + 1;
        }

        // Agrega un nuevo catedrático
        public void AgregarCatedratico(string nombre, string direccion, string telefono, string especializacion)
        {
            try
            {
                int nuevoId = GenerarNuevoId();
                string nuevaLinea = $"{nuevoId},{nombre},{direccion},{telefono},{especializacion}\n";
                File.AppendAllText(rutaArchivo, nuevaLinea);
                MessageBox.Show("Catedrático registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Busca un catedrático por ID (retorna null si no existe)
        public string[] BuscarCatedraticoPorId(int id)
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1);
            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (int.Parse(datos[0]) == id)
                {
                    return datos;
                }
            }
            return null;
        }

        // Modifica un catedrático existente
        public bool ModificarCatedratico(int id, string nombre, string direccion, string telefono, string especializacion)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                bool encontrado = false;

                for (int i = 1; i < lineas.Count; i++) // Saltar encabezado
                {
                    string[] datos = lineas[i].Split(',');
                    if (int.Parse(datos[0]) == id)
                    {
                        lineas[i] = $"{id},{nombre},{direccion},{telefono},{especializacion}";
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    File.WriteAllLines(rutaArchivo, lineas);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Elimina un catedrático por ID
        public bool EliminarCatedratico(int id)
        {
            try
            {
                var lineas = File.ReadAllLines(rutaArchivo).ToList();
                bool encontrado = false;

                for (int i = 1; i < lineas.Count; i++) // Saltar encabezado
                {
                    string[] datos = lineas[i].Split(',');
                    if (int.Parse(datos[0]) == id)
                    {
                        lineas.RemoveAt(i);
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    File.WriteAllLines(rutaArchivo, lineas);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
