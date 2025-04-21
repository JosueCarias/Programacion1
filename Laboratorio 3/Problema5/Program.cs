using Problema5;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu(){
            Console.WriteLine("Menu principal");
            Console.WriteLine("1) Sigma");
            Console.WriteLine("2) Sigma 1");
            Console.WriteLine("3) Sigma 2");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: MostraSigma();menu();break;
                case 2: MostrarSigma1();menu();break;
                case 3: MostrarSigma2();menu();break;
                case 4: Console.ReadKey();break;
                default: Console.WriteLine("Opcion incorrecta");menu();break;
            }
        }
        static void MostraSigma()
        {
            Console.WriteLine("Sigma");
            var s = new csSigma(10.0,0.0);
            Console.WriteLine($"El valor de la sumatoria es: {s.calcular()}");
        }
        static void MostrarSigma1()
        {
            Console.WriteLine("Sigma 1");
            var s1= new csSigma_1(10.0,5.0);
            Console.WriteLine($"El valor de la sumatoria 1 es: {s1.calcular()}");
        }
        static void MostrarSigma2()
        {
            Console.WriteLine("Sigma 2");
            var s2= new csSigma_2(10.0,5.0);
            Console.WriteLine($"El valor de la sumatoria 2 es: {s2.calcular()}");

        }
    }
}