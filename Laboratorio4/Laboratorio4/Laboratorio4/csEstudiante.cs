using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    internal class csEstudiante
    {
        private string rutaArchivo = "estudiante.txt";

        // Constructor: crea el archivo con encabezados si no existe
        public csEstudiante()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "carne,nombre,direccion,telefono,fecha_nacimiento,sexo\n");
            }
        }

        // Genera un nuevo carné (último carné + 1)
        private int GenerarNuevoCarne()
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezado
            if (!lineas.Any()) return 1; // Si no hay datos, empezar con 1

            int ultimoCarne = lineas
                .Select(linea => int.Parse(linea.Split(',')[0]))
                .Max();

            return ultimoCarne + 1;
        }

        // Agrega un nuevo estudiante
        public void AgregarEstudiante(string nombre, string direccion, string telefono, string fechaNacimiento, string sexo)
        {
            int nuevoCarne = GenerarNuevoCarne();
            string nuevaLinea = $"{nuevoCarne},{nombre},{direccion},{telefono},{fechaNacimiento},{sexo}\n";
            File.AppendAllText(rutaArchivo, nuevaLinea);
        }

        // Busca un estudiante por carné (retorna null si no existe)
        public string[] BuscarEstudiantePorCarne(int carne)
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1);
            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (int.Parse(datos[0]) == carne)
                {
                    return datos;
                }
            }
            return null;
        }

        // Modifica un estudiante existente
        public bool ModificarEstudiante(int carne, string nombre, string direccion, string telefono, string fechaNacimiento, string sexo)
        {
            var lineas = File.ReadAllLines(rutaArchivo).ToList();
            bool encontrado = false;

            for (int i = 1; i < lineas.Count; i++) // Saltar encabezado
            {
                string[] datos = lineas[i].Split(',');
                if (int.Parse(datos[0]) == carne)
                {
                    lineas[i] = $"{carne},{nombre},{direccion},{telefono},{fechaNacimiento},{sexo}";
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

        // Elimina un estudiante por carné
        public bool EliminarEstudiante(int carne)
        {
            var lineas = File.ReadAllLines(rutaArchivo).ToList();
            bool encontrado = false;

            for (int i = 1; i < lineas.Count; i++) // Saltar encabezado
            {
                string[] datos = lineas[i].Split(',');
                if (int.Parse(datos[0]) == carne)
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
    }
}
