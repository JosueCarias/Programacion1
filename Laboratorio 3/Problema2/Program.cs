using Problema2;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu(){
            Console.WriteLine("Menu principal");
            Console.WriteLine("1) Consulta interes");
            Console.WriteLine("2) Consulta interes simple");
            Console.WriteLine("3) Consulta interes compuesto");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: MostraInteres();menu();break;
                case 2: MostrarInteresSimple();menu();break;
                case 3: MostrarInteresCompuesto();menu();break;
                case 4: Console.ReadKey();break;
                default: Console.WriteLine("Opcion incorrecta");menu();break;
            }
        }
        static void MostraInteres()
        {
            Console.WriteLine("Clase interes general");
            var interes = new csInteres(0.05,500.0);
            Console.WriteLine(interes.calcular());
            Console.ReadKey();
        }
        static void MostrarInteresSimple()
        {
            Console.WriteLine("Clase interes simple");
            var interes = new csInteres_simple(0.05,500.0,5);
            Console.WriteLine(interes.calcular());
            Console.ReadKey();
        }
        static void MostrarInteresCompuesto()
        {
            Console.WriteLine("Clase interes compuesto");
            var interes = new csInteres_Compuesto(0.05,500.0,4);
            Console.WriteLine(interes.interesCompuesto());
            Console.ReadKey();
        }
    }
}

