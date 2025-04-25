using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laboratorio4
{
    internal class csCentroEducativo
    {
        private string rutaArchivo = "centro_educativo.txt";
        // Constructor: verifica si el archivo existe, si no, lo crea con encabezados
        public csCentroEducativo()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "id,nombre,direccion,telefono\n");
            }
        }
        // Genera un nuevo ID (último ID + 1)
        private int GenerarNuevoId()
        {
            var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezado
            if (!lineas.Any()) return 1;

            int ultimoId = lineas
                .Select(linea => int.Parse(linea.Split(',')[0]))
                .Max();

            return ultimoId + 1;
        }
        // Agrega un nuevo centro educativo
        public void AgregarCentro(string nombre, string direccion, string telefono)
        {
            int nuevoId = GenerarNuevoId();
            string nuevaLinea = $"{nuevoId},{nombre},{direccion},{telefono}\n";
            File.AppendAllText(rutaArchivo, nuevaLinea);
        }
        // Busca un centro por ID (retorna null si no existe)
        public string[] BuscarCentroPorId(int id)
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
        // Modifica un centro educativo existente
        public bool ModificarCentro(int id, string nuevoNombre, string nuevaDireccion, string nuevoTelefono)
        {
            var lineas = File.ReadAllLines(rutaArchivo).ToList();
            bool encontrado = false;

            for (int i = 1; i < lineas.Count; i++) // Empezar desde 1 (saltar encabezado)
            {
                string[] datos = lineas[i].Split(',');
                if (int.Parse(datos[0]) == id)
                {
                    lineas[i] = $"{id},{nuevoNombre},{nuevaDireccion},{nuevoTelefono}";
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
        // Elimina un centro por ID
        public bool EliminarCentro(int id)
        {
            var lineas = File.ReadAllLines(rutaArchivo).ToList();
            bool encontrado = false;

            for (int i = 1; i < lineas.Count; i++) // Empezar desde 1 (saltar encabezado)
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
    }
}
