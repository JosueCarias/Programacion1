using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.WriteLine("---------------Menu---------------");
            Console.WriteLine("1) volumen de un cono");
            Console.WriteLine("2) funcion exponencial");
            Console.WriteLine("3) salir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: cono(); menu(); break;
                case 2: exponencial(); menu(); break;
                case 3: salir(); break;
                default: Console.WriteLine("Opcion incalida"); menu(); break;
            }
        }
        static void salir()
        {
            Environment.Exit(0);
        }
        static void cono()
        {
            Console.WriteLine("---------------Cono---------------");
            Console.WriteLine("Ingrese el valor de R");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de H");
            double h = Convert.ToDouble(Console.ReadLine());

            csCono c= new csCono();
            Console.WriteLine($"El volumen es {c.volumen(r, h)}");

            Console.WriteLine("----------------------------------");
            Console.ReadKey();

        }
        static void exponencial()
        {
            Console.WriteLine("-----------exponencial------------");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();

        }
    }
}
