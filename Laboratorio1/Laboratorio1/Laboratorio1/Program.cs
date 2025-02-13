using System;

namespace MiProyecto
{
    class Program
    {
        //Contructor principal
        static void Main(string[] args)
        {
            MostrarMenu(); 
        }

        //Funcion que ejecuta el menu principal
        static void MostrarMenu()
        {
            Console.Clear();
            int opcion = menu();

            switch (opcion)
            {
                case 1:
                    anoBisiesto();
                    break;
                case 2:
                    sueldo();
                    break;
                case 3:
                    numeroIntermedio();
                    break;
                case 4:
                    Combinacion();
                    break;
                case 5:
                    vueltos();
                    break;
                case 6:
                    clasificacion();
                    break;
                case 7:
                    sueldoDiario();
                    break;
                case 8:
                    sigma();
                    break;
                case 9:
                    ganador();
                    break;
                case 10:
                    tablas();
                    break;
                case 11:
                    numeroPerfecto();
                    break;
                case 12:
                    semana();
                    break;
                case 13:
                    fibonacci();
                    break;
                case 14:
                    formula();
                    break;
                case 15:
                    año();
                    break;
                case 16:
                    salir();
                    return; 
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            MostrarMenu();
        }

        //Funcion que calcular el año bisiesto #1
        static void anoBisiesto()
        {
            int año = 0;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ingrese Un Año:");
            año= Convert.ToInt32(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine($"El Año {año} Es Bisiesto.");
            }
            else
            {
                Console.WriteLine($"El Año {año} No Es Bisiesto.");
            }

            Console.WriteLine("-----------------------------------------------");
        }

        //Funcion que calcula es sueldo #2
        static void sueldo()
        {
            double sueldoBase = 0;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ingrese Su Sueldo:");
            sueldoBase = Convert.ToDouble(Console.ReadLine());           

            Console.WriteLine($"Sueldo Base :{sueldoBase}");
            Console.WriteLine($"Cuota Laboral :{cuotaLaboral(sueldoBase)}");
            Console.WriteLine($"Cuota Patronal :{cuotaPatronal(sueldoBase)}");
            Console.WriteLine($"Sueldo Liquido :{sueldoLiquido(sueldoBase)}");

            Console.WriteLine("-----------------------------------------------");

        }

        //Funcion complemento de sueldo
        static double cuotaLaboral(double sueldoBase)
        {
            double cuotaLaboral = 0;
            cuotaLaboral=sueldoBase*0.0483;

            return cuotaLaboral;
        }

        //Funcion complemento de sueldo
        static double cuotaPatronal(double sueldoBase)
        {
            double cuotaPatronal = 0;
            cuotaPatronal = sueldoBase * 0.01;

            return cuotaPatronal;
        }

        //Funcion complemento de sueldo
        static double sueldoLiquido(double sueldoBase)
        {
            double sueldoLiquido = 0;
            sueldoLiquido = sueldoBase -(cuotaLaboral(sueldoBase)+cuotaPatronal(sueldoBase));

            return sueldoLiquido;
        }

        //Funcion que calcular el numero intermedio #3
        static void numeroIntermedio()
        {
            Console.WriteLine("-----------------------------------------------");

            int num1, num2, num3;

            Console.WriteLine("Ingrese El Primer Numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese El Segundo Numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese El Tercer Numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
            {
                Console.WriteLine($"El número {num1} es el número intermedio.");
            }
            else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
            {
                Console.WriteLine($"El número {num2} es el número intermedio.");
            }
            else if ((num3 > num1 && num3 < num2) || (num3 < num1 && num3 > num2))
            {
                Console.WriteLine($"El número {num3} es el número intermedio.");
            }
            else
            {
                Console.WriteLine("los números son iguales");
            }
        }

        //Funcion combinacion #4
        static void Combinacion()
        {
            Console.WriteLine("------------Funcion Combinacion------------");

            int n, r, resultado;

            Console.WriteLine("Ingrese el valor de N:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de R:");
            r = Convert.ToInt32(Console.ReadLine());

            if (n >= r)
            {
                resultado = factorial(n) / (factorial(r) * factorial(n - r));
                Console.WriteLine("Resultado de la combinación: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: N debe ser mayor o igual que R.");
            }

            Console.WriteLine("--------------------------------------");
        }

        //Funcion completo de combinacion
        public static int factorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        //Funcion Vueltos #5
        static void vueltos()
        {
            int dinero = 0;

            Console.WriteLine("Ingrese la cantidad: ");
            dinero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La cantidad de billetes es:");
            Console.WriteLine($"La cantidad de billetes de 100 {billetes100(dinero)}");
            Console.WriteLine($"La cantidad de billetes de 50 {billetes50(dinero)}");
            Console.WriteLine($"La cantidad de billetes de 20 {billetes20(dinero)}");
            Console.WriteLine($"La cantidad de billetes de 10 {billetes10(dinero)}");
            Console.WriteLine($"La cantidad de billetes de 5 {billetes5(dinero)}");
            Console.WriteLine($"La cantidad de billetes de 1 {billetes1(dinero)}");


        }
        // Función para calcular billetes de 100
        static int billetes100(int dinero)
        {
            return dinero / 100;
        }

        // Función para calcular billetes de 50
        static int billetes50(int dinero)
        {
            return (dinero % 100) / 50;
        }

        // Función para calcular billetes de 20
        static int billetes20(int dinero)
        {
            return (dinero % 50) / 20;
        }

        // Función para calcular billetes de 10
        static int billetes10(int dinero)
        {
            return (dinero % 20) / 10;
        }

        // Función para calcular billetes de 5
        static int billetes5(int dinero)
        {
            return (dinero % 10) / 5;
        }

        // Función para calcular billetes de 1
        static int billetes1(int dinero)
        {
            return dinero % 5;
        }
        //Funcion INE #6
        static void clasificacion()
        {
            int edad = 0;
            string clasificacion = "";

            Console.WriteLine("Ingrese la edad de la persona:");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 5)
            {
                clasificacion = "Bebé";
            }
            else if (edad >= 6 && edad <= 12)
            {
                clasificacion = "Niño";
            }
            else if (edad >= 13 && edad <= 17)
            {
                clasificacion = "Adolescente";
            }
            else if (edad >= 18 && edad <= 50)
            {
                clasificacion = "Adulto";
            }
            else
            {
                clasificacion = "Anciano";
            }
            Console.WriteLine($"La persona es: {clasificacion}");
        }
        //Funcion sueldo #9
        static void sueldoDiario()
        {
            string nombre = "";
            double horasTrabajadas = 0;
            double pagoPorHora = 0;
            double horasNormales = 0;
            double horasExtras = 0;
            double pagoHorasNormales = 0;
            double pagoHorasExtras = 0;
            double sueldoTotal = 0;

            Console.WriteLine("Ingrese el nombre de la persona");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas:");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el pago por hora:");
            pagoPorHora = Convert.ToDouble(Console.ReadLine());

            horasNormales = Math.Min(horasTrabajadas, 8);
            horasExtras = Math.Max(horasTrabajadas - 8, 0);

            pagoHorasNormales = horasNormales * pagoPorHora;
            pagoHorasExtras = horasExtras * (pagoPorHora * 1.5);
            sueldoTotal = pagoHorasNormales + pagoHorasExtras;

            Console.WriteLine("\nDetalle de pagos:");
            Console.WriteLine($"- Trabajador: {nombre}");
            Console.WriteLine($"- Horas normales: {horasNormales} horas, Pago: {pagoHorasNormales:C}");
            Console.WriteLine($"- Horas extras: {horasExtras} horas, Pago: {pagoHorasExtras:C}");
            Console.WriteLine($"- Sueldo total a recibir: {sueldoTotal:C}");
        }


        //Funcion Sigma #8
        static void sigma()
        {
            double sumatoria = 0;
            double termino = 0;

            for (int n = 1; n <= 4; n++)
            {
                termino = 1.0 / (n * (n + 2));
                sumatoria += termino;

                Console.WriteLine($"Para n = {n}, término = {termino}");
            }

            Console.WriteLine($"\nEl resultado de la sumatoria es: {sumatoria}");
        }
        //Funcion ganador 9
        static void ganador()
        {
            Console.WriteLine("Ingrese el nombre del primer equipo:");
            string equipo1 = Console.ReadLine();

            Console.WriteLine($"Ingrese el marcador de {equipo1}:");
            int marcador1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del segundo equipo:");
            string equipo2 = Console.ReadLine();

            Console.WriteLine($"Ingrese el marcador de {equipo2}:");
            int marcador2 = Convert.ToInt32(Console.ReadLine());

            if (marcador1 > marcador2)
            {
                Console.WriteLine($"\nEl equipo ganador es: {equipo1} ({marcador1} - {marcador2})");
                Console.WriteLine($"El equipo perdedor es: {equipo2}");
            }
            else if (marcador2 > marcador1)
            {
                Console.WriteLine($"\nEl equipo ganador es: {equipo2} ({marcador2} - {marcador1})");
                Console.WriteLine($"El equipo perdedor es: {equipo1}");
            }
            else
            {
                Console.WriteLine($"\nEl partido terminó en empate: {equipo1} {marcador1} - {equipo2} {marcador2}");
            }
        }
        //Funcion tablas de multiplicar #10
        static void tablas()
        {
            // Ciclo externo para las tablas del 1 al 10
            for (int tabla = 1; tabla <= 10; tabla++)
            {
                Console.WriteLine($"\nTabla del {tabla}:");

                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    int resultado = tabla * multiplicador;
                    Console.WriteLine($"{tabla} x {multiplicador} = {resultado}");
                }
            }
        }

        //Funcion numero perfecto #11
        static void numeroPerfecto()
        {
            int numero = 0;

            Console.WriteLine("Ingrese un número entero:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (EsNumeroPerfecto(numero))
            {
                Console.WriteLine($"{numero} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecto.");
            }
        }
        // Función para verificar si un número es perfecto
        static bool EsNumeroPerfecto(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            int sumaDivisores = 0;
     
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == numero;
        }
        //Funcion semana #12
        static void semana()
        {
            int numero = 0;
            string dia = "";
            Console.WriteLine("Ingrese un número del 1 al 7:");
            numero = Convert.ToInt32(Console.ReadLine());

            dia = ObtenerDiaDeLaSemana(numero);

            if (dia != null)
            {
                Console.WriteLine($"El número {numero} corresponde al día: {dia}");
            }
            else
            {
                Console.WriteLine("Número no válido. Debe ser un valor entre 1 y 7.");
            }
        }
        static string ObtenerDiaDeLaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return null;
            }
        }
        //serie de Fibonacci 13
        static void fibonacci()
        {
            int cantidad = 0;

            Console.WriteLine("¿Cuántos números de la serie Fibonacci desea visualizar?");
            cantidad = Convert.ToInt32(Console.ReadLine());

            List<int> serieFibonacci = ObtenerSerieFibonacci(cantidad);

            Console.WriteLine("\nSerie Fibonacci:");
            Console.WriteLine(string.Join(", ", serieFibonacci));
        }

        static List<int> ObtenerSerieFibonacci(int cantidad)
        {
            List<int> serie = new List<int>();

            if (cantidad >= 1)
            {
                serie.Add(0); 
            }
            if (cantidad >= 2)
            {
                serie.Add(1); 
            }

            for (int i = 2; i < cantidad; i++)
            {
                int siguienteNumero = serie[i - 1] + serie[i - 2];
                serie.Add(siguienteNumero);
            }

            return serie;
        }

        //funcion formula 14
        static void formula()
        {
            double P = 0;
            double tasaAnual = 0;
            int plazoAnios = 0;
            double r = 0;
            int n = 0;
            double A = 0;

            Console.WriteLine("Ingrese el monto principal del préstamo (P):");
            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa de interés anual (en decimal, por ejemplo, 0.05 para 5%):");
            tasaAnual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el plazo del préstamo en años:");
            plazoAnios = Convert.ToInt32(Console.ReadLine());

            r = tasaAnual / 12;
            n = plazoAnios * 12;
            A = CalcularPagoMensual(P, r, n);

            Console.WriteLine($"\nEl pago mensual es: {A:C}");
        }
        static double CalcularPagoMensual(double P, double r, int n)
        {
            double factor = Math.Pow(1 + r, n);

            double A = P * (r * factor) / (factor - 1);

            return A;
        }
        // funcion año bisiesto #15
        static void año()
        {
            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            string resultado = ClasificarNumero(numero);

            Console.WriteLine(resultado);
        }
        static string ClasificarNumero(int numero)
        {
            if (numero > 0)
            {
                return "El número es positivo.";
            }
            else if (numero < 0)
            {
                return "El número es negativo.";
            }
            else
            {
                return "El número es neutro (0).";
            }
        }

        //Funcion para salir #16
        static void salir()
        {
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0); 
        }

        //Fucion que genera el menu
        public static int menu()
        {
            int opcion = 0;
            Console.WriteLine("Menu principal:");
            Console.WriteLine("1) Año Bisiesto:");
            Console.WriteLine("2) Cuota Laboral:");
            Console.WriteLine("3) Numero intermedio:");
            Console.WriteLine("4) Combinacion:");
            Console.WriteLine("5) Cantidad de billetes:");
            Console.WriteLine("6) INE:");
            Console.WriteLine("7) Calcule El Sueldo Diario:");
            Console.WriteLine("8) Sigma:");
            Console.WriteLine("9) Marcador Futbol:");
            Console.WriteLine("10) Tabla de multiplicar:");
            Console.WriteLine("11) Nnumero es perfecto:");
            Console.WriteLine("12) estructurada por 7 días:");
            Console.WriteLine("13) Serie Fibonacci:");
            Console.WriteLine("14) Desarrollo formula:");
            Console.WriteLine("15) Numero Entero, Entero Positivo O Entero Negativo:");
            Console.WriteLine("6) Salir:");
            Console.WriteLine("Ingrese una opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
