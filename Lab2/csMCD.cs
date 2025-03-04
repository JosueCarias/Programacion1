using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csMCD
    {
        // Método para calcular el MCD usando el algoritmo de Euclides
    public static int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Método para obtener los divisores comunes de un número
    public static List<int> ObtenerDivisoresComunes(int numero)
    {
        List<int> divisores = new List<int>();
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }
        return divisores;
    }
    }
}