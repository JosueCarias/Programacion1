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
                case 5: Entero();menu();break;
                case 6: Cilindro();menu();break;
                case 7: Equipo();menu();break;
                case 8: MCD();menu();break;
                case 9: Fibonacci();menu();break;
                case 10: Tabla();menu();break;
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
        public static void Entero(){
            Console.WriteLine("Ingrese un numero entero:");
            int numero=Convert.ToInt32(Console.ReadLine());
            csEntero entero = new csEntero(numero);

            Console.WriteLine($"El numero: {numero} es {entero.calculaPositivo()}");
        }
        public static void Cilindro(){
            Console.WriteLine("Ingrese la altura del cono");
            double altura=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el radio");
            double radio=Convert.ToDouble(Console.ReadLine());

            csVolumen cono= new csVolumen(radio,altura);

            Console.WriteLine($"El volumen es: {cono.calcularVolumen()}");
        }

        public static void Equipo(){
             // Solicitar datos del primer equipo
            Console.Write("Ingrese el nombre del primer equipo: ");
            string nombreEquipo1 = Console.ReadLine();
            Console.Write("Ingrese el marcador del primer equipo: ");
            int marcadorEquipo1 = int.Parse(Console.ReadLine());

            // Solicitar datos del segundo equipo
            Console.Write("Ingrese el nombre del segundo equipo: ");
            string nombreEquipo2 = Console.ReadLine();
            Console.Write("Ingrese el marcador del segundo equipo: ");
            int marcadorEquipo2 = int.Parse(Console.ReadLine());

            // Crear objetos de la clase csEquipo
            csEquipo equipo1 = new csEquipo(nombreEquipo1, marcadorEquipo1);
            csEquipo equipo2 = new csEquipo(nombreEquipo2, marcadorEquipo2);

            // Calcular y mostrar el resultado
            string resultado = csEquipo.CalcularMarcador(equipo1, equipo2);
            Console.WriteLine(resultado);
        }

        public static void MCD(){
            // Solicitar dos números enteros al usuario
            Console.Write("Ingrese el primer número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcular el MCD
            int mcd = csMCD.CalcularMCD(numero1, numero2);

            // Obtener los divisores comunes del MCD
            List<int> divisoresComunes = csMCD.ObtenerDivisoresComunes(mcd);

            // Mostrar el resultado
            Console.WriteLine($"El Máximo Común Divisor (MCD) de {numero1} y {numero2} es: {mcd}");
            Console.WriteLine("Los divisores comunes del MCD son: " + string.Join(", ", divisoresComunes));
            
        }
        public static void Fibonacci(){
            // Solicitar al usuario la cantidad de términos de la serie Fibonacci
            Console.Write("¿Cuántos números de la serie Fibonacci desea visualizar? ");
            int cantidadTerminos = int.Parse(Console.ReadLine());

            // Generar la serie Fibonacci
            List<int> serieFibonacci = csFibonacci.GenerarSerieFibonacci(cantidadTerminos);

            // Mostrar la serie Fibonacci
            if (serieFibonacci.Count > 0)
            {
                Console.WriteLine("La serie Fibonacci es: " + string.Join(", ", serieFibonacci));
            }
            else
            {
                Console.WriteLine("La cantidad de términos debe ser mayor a 0.");
            }
        }
        public static void Tabla(){
            // Mostrar las tablas de multiplicar del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                csTabla.MostrarTabla(i);
            }
        }
    }
}
