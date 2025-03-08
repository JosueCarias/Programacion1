using System;
using System.Security.Cryptography;
using Clase_080325;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu(){
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Volumen de cono");
            Console.WriteLine("2. Funcion exponencial");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Ingrese una opcion");
            int opcion =Convert.ToInt32(Console.ReadLine());
            switch(opcion){
                case 1: Volumen();menu();break;
                case 2: Exponencial();menu();break;
                case 3: Console.ReadKey();break;
                default: Console.WriteLine("Opcion invalida");menu();break;
            }
        }
        static void Volumen(){
            Console.WriteLine("Programa para calcular el volumen de un cono");
            Console.WriteLine("Ingrse el radio");
            double radio=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrse la altura");
            double altura=Convert.ToDouble(Console.ReadLine());

            csCono c =new csCono(radio,altura);
            Console.WriteLine($"El Volumen es: {c.resultado()}");

            Console.ReadKey();
        }
        static void Exponencial(){
            Console.WriteLine("Programa para calcular una funcion exponencial");
            Console.WriteLine("Ingrese el valor de X");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de interaciones n");
            int n=Convert.ToInt32(Console.ReadLine());

            csExponencial e=new csExponencial(x,n);
            Console.WriteLine($"El valor del exponencial para los valores de x={x} y x={n}, es: {e.resultado()}");
        }
    }
}
