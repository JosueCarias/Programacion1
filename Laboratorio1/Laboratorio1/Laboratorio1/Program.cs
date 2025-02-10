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
                    ;
                    break;
                case 6:
                    ;
                    break;
                case 7:
                    ;
                    break;
                case 8:
                    ;
                    break;
                case 9:
                    ;
                    break;
                case 10:
                    ;
                    break;
                case 11:
                    ;
                    break;
                case 12:
                    ;
                    break;
                case 13:
                    ;
                    break;
                case 14:
                    ;
                    break;
                case 15:
                    ;
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
            Console.WriteLine("5) Finero Expresada En Quetzales:");
            Console.WriteLine("6) INE:");
            Console.WriteLine("7) Calcule El Sueldo Diario:");
            Console.WriteLine("8) Sigma:");
            Console.WriteLine("9) Calcule El Sueldo Diario:");
            Console.WriteLine("10) Marcador Futbol:");
            Console.WriteLine("11) Tabla De Multiplicar:");
            Console.WriteLine("12) Numero Entero:");
            Console.WriteLine("13) Semana Estructurada:");
            Console.WriteLine("14) Serie Fibonacci:");
            Console.WriteLine("15) Numero Entero, Entero Positivo O Entero Negativo:");
            Console.WriteLine("6) Salir:");
            Console.WriteLine("Ingrese una opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
