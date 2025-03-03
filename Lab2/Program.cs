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
        public static void menu(){
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
                case 1: Viaje();menu();break;
                case 2: Billetes();menu();break;
                case 3: NumeroPerfecto();menu();break;
                case 4: Menor();menu();break;
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
        public static void Viaje(){
            Console.WriteLine("----------Calculo de costo de viaje en bus----------");
            Console.WriteLine("Ingrese la cantidad de alumnos:");
            int nAlumnos = Convert.ToInt32(Console.ReadLine());
            csPagoAutobus pago =new csPagoAutobus(nAlumnos);
            Console.WriteLine($"El pago total es: {pago.calcularPagoAutoBus()}");
            Console.WriteLine($"El pago individual es: {pago.calcularPagoIndividual()}");
            Console.ReadKey();
        }

        public static void Billetes(){
            Console.WriteLine("----------Calculo de cantidad de billetes----------");
            Console.WriteLine("Ingrese la cantidad a consultar:");
            int dinero = Convert.ToInt32(Console.ReadLine());
            csDinero money = new csDinero(dinero);
            Console.WriteLine($"La catidad de billetes es:");
            Console.WriteLine($"De 100: {(money.calcularBilletes())[0]}");
            Console.WriteLine($"De 50: {(money.calcularBilletes())[1]}");
            Console.WriteLine($"De 20: {(money.calcularBilletes())[2]}");
            Console.WriteLine($"De 10: {(money.calcularBilletes())[3]}");
            Console.WriteLine($"De 5: {(money.calcularBilletes())[4]}");
            Console.WriteLine($"De 1: {(money.calcularBilletes())[5]}");
            Console.ReadKey();
        }

        public static void NumeroPerfecto(){
            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            csPerfecto perfecto = new csPerfecto(numero);

            if (perfecto.calcularPerfecto())
            {
                Console.WriteLine($"{numero} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecto.");
            }
        }
        public static void Menor(){
            csEdad[] personas = new csEdad[3];

            for (int i = 0; i < 3; i++){
            Console.Write("Ingrese el nombre de la persona {0}: ", i + 1);
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad de la persona {0}: ", i + 1);
            int edad = int.Parse(Console.ReadLine());

            personas[i] = new csEdad(nombre, edad);
            }

        csEdad menor = csEdad.CalcularMenor(personas);

        Console.WriteLine("La persona más joven es: {0} con {1} años.", menor.Nombre, menor.Edad);
        }
    }
}
