using System;

namespace MiProyecto
{
    class Program
    {
        //Contructor principal
        static void Main(string[] args)
        {
            menu();
        }
        static void ecuacionCuadratica()
        {
            Console.WriteLine("-----------------Ecuacion cuadratica-----------------");

            double a, b, c,x1,x2;
            Console.WriteLine("Ingrese el valor de a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de c");
            c = Convert.ToDouble(Console.ReadLine());

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            Console.WriteLine($"el valor de x1 ={x1}");
            Console.WriteLine($"el valor de x2 ={x2}");

            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
        static void sigma()
        {
            Console.WriteLine("------------------------Sigma------------------------");

            double k, suma;
            k = 3;
            suma = 0;

            for (double i = k; i <= 40; i++)
            {
                suma += Math.Pow((2 * i - 5),3);
            }
            Console.WriteLine($"El valor se la sumatoria es: {suma}");


            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
        static void triangulo()
        {
            Console.WriteLine("------------------Tipo de triangulo------------------");

            double a, b, c;
            Console.WriteLine("Ingrese el valor de a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de c");
            c = Convert.ToDouble(Console.ReadLine());

            if(a==b & a == c & b==c)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("El triangulo es isoceles");
            }
            else { 
                Console.WriteLine("el triangulo es escaleno");
            }
           
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
        static void salir()
        {
            Environment.Exit(0);
        }
        static void menu()
        {
            Console.WriteLine("-----------------Menu Principal-----------------");
            Console.WriteLine("1) Ecuacion cuadratica");
            Console.WriteLine("2) Sigma");
            Console.WriteLine("3) Tipo de triangulo");
            Console.WriteLine("4) salir");
            Console.WriteLine("elija una opcion");
            int opcion =Convert.ToInt32(Console.ReadLine());

            switch (opcion) 
            {
                case 1: ecuacionCuadratica(); menu(); ; break;
                case 2: sigma(); menu(); break;
                case 3: triangulo(); menu(); break;
                case 4: salir(); ; Console.ReadKey(); break;
                default: Console.WriteLine("Opcion invalida");Console.ReadKey();menu();break;


            }
        }
    }
}
