using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clase_290325;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu(){
            Console.Clear();
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Rectangulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Circulo");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Elija una opcion");

            int opcion =Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: rectangulo();menu();break;
                case 2: triangulo();menu();break;
                case 3: circulo();menu();break;
                case 4: Console.WriteLine("Saliendo");break;
                default: Console.WriteLine("Opcion no valida");menu();break;
            }
        }
        static void rectangulo(){
            Console.WriteLine("Programa que calcular formulas de un rectangulo");
            Console.WriteLine("Ingrese la base");
            int ancho=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            int altura=Convert.ToInt32(Console.ReadLine());

            csRectangulo r= new csRectangulo(ancho,altura);
            Console.WriteLine(r.verDatos());
            Console.ReadKey();
        }
        static void triangulo(){
            Console.WriteLine("Programa que calcular formulas de un triangulo");
            Console.WriteLine("Ingrese la base");
            int ancho=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            int altura=Convert.ToInt32(Console.ReadLine());

            csTriangulo t= new csTriangulo(ancho,altura);
            Console.WriteLine(t.verDatos());
            Console.ReadKey();
        }
        static void circulo(){
            Console.WriteLine("Programa que calcular formulas de un circulo");
            Console.WriteLine("Ingrese el radio");
            int radio=Convert.ToInt32(Console.ReadLine());

            csCirculo c= new csCirculo(radio);
            Console.WriteLine(c.verDatos());
            Console.ReadKey();
        }
    }
}
