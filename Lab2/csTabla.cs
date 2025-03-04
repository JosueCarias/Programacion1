using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csTabla
    {
        // Método para generar y mostrar la tabla de multiplicar de un número
    public static void MostrarTabla(int numero)
    {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
        Console.WriteLine(); // Salto de línea para separar las tablas
    }
    }
}