using System;
using PrimerParcial;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu(){
            Console.WriteLine("--------Menu Principal--------");
            Console.WriteLine("1. Calcular unidad de medida");
            Console.WriteLine("2. Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion =Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: UnidadDeMedida();menu();break;
                case 2: Console.ReadKey();break;
                default: Console.WriteLine("Opcion no valida");menu();break;
            }
        }
        static void UnidadDeMedida(){
            Console.WriteLine("--------Unidad de medida--------");
            Console.WriteLine("Ingrese un numero entero a consultar:");
            int numero=Convert.ToInt32(Console.ReadLine());
            csUnidades unidades = new csUnidades(numero);
            Console.WriteLine($"{unidades.calcularUnidadDeMedida()}");
            Console.WriteLine("Precione cualquier tecla para continuar..."); 
            Console.ReadKey();
        }
    }
}