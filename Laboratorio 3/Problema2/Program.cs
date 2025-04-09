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
                case 2: menu();break;
                case 3: menu();break;
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
            
        }
        static void MostrarInteresCompuesto()
        {
        
        }
    }
}

