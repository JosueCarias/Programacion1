using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu(); // Iniciar el menú
        }

        static void MostrarMenu()
        {
            Console.Clear(); // Limpiar la pantalla para mostrar el menú
            int opcion = menu();

            switch (opcion)
            {
                case 1:
                    factorialF();
                    break;
                case 2:
                    Combinacion();
                    break;
                case 3:
                    ecuacion();
                    break;
                case 4:
                    sigma();
                    break;
                case 5:
                    triangulo();
                    break;
                case 6:
                    salir();
                    return; // Salir del método y terminar el programa
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            MostrarMenu(); // Llamada recursiva para mostrar el menú nuevamente
        }

        public static int factorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void factorialF()
        {
            Console.WriteLine("------------Funcion Factorial------------");

            int num1 = 0;
            int resultado = 0;

            Console.WriteLine("Ingrese un número para calcular su factorial:");
            num1 = Convert.ToInt32(Console.ReadLine());

            resultado = factorial(num1);

            Console.WriteLine("El factorial de " + num1 + " es: " + resultado);

            Console.WriteLine("--------------------------------------");
        }

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

        static void ecuacion()
        {
            Console.WriteLine("------------Funcion Ecuacion Cuadratica------------");

            double a, b, c, x1, x2;

            Console.WriteLine("Ingrese el valor de a:");
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Error: 'a' no puede ser cero.");
                return;
            }

            Console.WriteLine("Ingrese el valor de b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c:");
            c = Convert.ToDouble(Console.ReadLine());

            double discriminante = Math.Pow(b, 2) - (4 * a * c);

            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las soluciones son:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminante == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("La solución doble es:");
                Console.WriteLine("x = " + x1);
            }
            else
            {
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine("Las soluciones son complejas:");
                Console.WriteLine("x1 = " + parteReal + " + " + parteImaginaria + "i");
                Console.WriteLine("x2 = " + parteReal + " - " + parteImaginaria + "i");
            }

            Console.WriteLine("--------------------------------------");
        }

        static void sigma()
        {
            Console.WriteLine("------------Funcion Sigma------------");
            Console.WriteLine("Esta función aún no está implementada.");
            Console.WriteLine("--------------------------------------");
        }

        static void triangulo()
        {
            Console.WriteLine("------------Funcion Triangulo------------");
            Console.WriteLine("Esta función aún no está implementada.");
            Console.WriteLine("--------------------------------------");
        }

        static void salir()
        {
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0); // Terminar el programa
        }

        public static int menu()
        {
            int opcion = 0;
            Console.WriteLine("Menu principal:");
            Console.WriteLine("1) Factorial:");
            Console.WriteLine("2) Combinacion:");
            Console.WriteLine("3) Ecuacion Cuadratica:");
            Console.WriteLine("4) Sigma:");
            Console.WriteLine("5) Triangulo:");
            Console.WriteLine("6) Salir:");
            Console.WriteLine("Ingrese una opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}