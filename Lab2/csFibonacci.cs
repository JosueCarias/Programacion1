using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csFibonacci
    {
        // Método para generar la serie Fibonacci
    public static List<int> GenerarSerieFibonacci(int cantidadTerminos)
    {
        List<int> serieFibonacci = new List<int>();

        if (cantidadTerminos <= 0)
        {
            return serieFibonacci; // Retorna una lista vacía si la cantidad de términos es inválida
        }

        // Primeros dos términos de la serie Fibonacci
        int a = 0, b = 1;
        serieFibonacci.Add(a);

        if (cantidadTerminos == 1)
        {
            return serieFibonacci;
        }

        serieFibonacci.Add(b);

        // Generar los términos restantes
        for (int i = 2; i < cantidadTerminos; i++)
        {
            int siguiente = a + b;
            serieFibonacci.Add(siguiente);
            a = b;
            b = siguiente;
        }

        return serieFibonacci;
    }
    }
}