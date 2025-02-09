using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace programacionModularSeccionD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre="Programa que calcula un formula de convinacion";
            int n, r, resultado;
            //instruciones de salida de datos
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el valor de N");
            //entrada de datos
            n = Convert.ToInt32(Console.ReadLine());
            //instruccione de salida de datos
            Console.WriteLine("Ingrese el valor de R");
            //entrada de datos
            r = Convert.ToInt32(Console.ReadLine());

            //proceso de convinacion por formulas
            resultado = factorial(n) / (factorial(r) * factorial(n - r));

            //salida de respuesta
            Console.WriteLine("Resultado de factorial");
            Console.WriteLine(resultado);

        }
        public static int factorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
