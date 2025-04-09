using Problema3;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu(){
            Console.WriteLine("Menu principal");
            Console.WriteLine("1) Teorema");
            Console.WriteLine("2) Permutacion");
            Console.WriteLine("3) Combinacion");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: MostraTeorema();menu();break;
                case 2: MostrarPermutacion();menu();break;
                case 3: MostrarCombinacion();menu();break;
                case 4: Console.ReadKey();break;
                default: Console.WriteLine("Opcion incorrecta");menu();break;
            }
        }
        static void MostraTeorema()
        {
            Console.WriteLine("Teorema");
            var factorial = new csTeorema(5,5);
            Console.WriteLine($"El factorial es: {factorial.Factorial(5)}");
        }
        static void MostrarPermutacion()
        {
            Console.WriteLine("Permutacion");
            var permutacion = new csPermutacion(3,2);
            Console.WriteLine($"La permutacion es: {permutacion.Calcular()}");
        }
        static void MostrarCombinacion()
        {
            Console.WriteLine("Combinacion");
            var combinacion = new csCombinacion(3,2);
            Console.WriteLine($"La combinacion es: {combinacion.Calcular()}");
        }
    }
}
