using System;
using Lab2;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu(){
            Console.WriteLine("----------Menu principal----------");
            Console.WriteLine("1. Viaje de estudios");
            Console.WriteLine("2. Dinero en quetzales");
            Console.WriteLine("3. Numero perfecto");
            Console.WriteLine("4. Edad 3 Personas");
            Console.WriteLine("5. Numero entero positivo o negativo");
            Console.WriteLine("6. Volumen de un cilindro");
            Console.WriteLine("7. Marcador de equipo");
            Console.WriteLine("8. Maximo comun divisor");
            Console.WriteLine("9. Serie de Fibonacci");
            Console.WriteLine("10. Tablas de multiplicar");
            Console.WriteLine("11. Salir");
            Console.WriteLine("Elija una opcion");
            int opcion =Convert.ToInt32(Console.ReadLine());
            
            switch(opcion){
                case 1: viaje();menu();break;
                case 2: menu();break;
                case 3: menu();break;
                case 4: menu();break;
                case 5: menu();break;
                case 6: menu();break;
                case 7: menu();break;
                case 8: menu();break;
                case 9: menu();break;
                case 10: menu();break;
                case 11: Console.ReadKey();break;
                default: Console.WriteLine("Opcion Incorrecta");menu();break;
            }
        }
        public static void viaje(){
            Console.WriteLine("----------Calculo de costo de viaje en bus----------");
            Console.WriteLine("Ingrese la cantidad de alumnos:");
            int nAlumnos = Convert.ToInt32(Console.ReadLine());
            csPagoAutobus pago =new csPagoAutobus(nAlumnos);
            Console.WriteLine($"El pago total es: {pago.calcularPagoAutoBus()}");
            Console.WriteLine($"El pago individual es: {pago.calcularPagoIndividual()}");
            Console.ReadKey();
        }
    }
}
