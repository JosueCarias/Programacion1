using System;
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;
using Clase_220225;

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
            Console.WriteLine("Menu principal");
            Console.WriteLine("1. Volumen de un cono");
            Console.WriteLine("2. Funcion exponecial");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Ingrese una opcion");

            int opcion=Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: volumen();menu();break;
                case 2: expinencial();menu();break;
                case 3: Console.ReadKey();break;
            }
        }
        static void volumen(){
            Console.WriteLine("Programa para calcula el volumen de un cono");
            Console.WriteLine("Ingrese el valor del radio");
            double radio=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura");
            double altura=Convert.ToDouble(Console.ReadLine());

            csCono c =new csCono();
            c.setRadio(radio);
            c.setAltura(altura);

            

            Console.WriteLine($"El volumen es: {c.calcularVolumen()}");
            Console.ReadKey();

        }
        static void expinencial(){
            
        }
    }
}
//Compilar 
//dotnet build

//ejecutar
//dotnet run
