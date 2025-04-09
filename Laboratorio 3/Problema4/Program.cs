using Problema4;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu(){
            Console.WriteLine("Menu principal");
            Console.WriteLine("1) Sistema decimal");
            Console.WriteLine("2) Sistema binario");
            Console.WriteLine("3) Sistema octal");
            Console.WriteLine("4) Sistema hexadecimal");
            Console.WriteLine("5) Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: MostraDecimal();menu();break;
                case 2: MostrarBinario();menu();break;
                case 3: MostrarOctal();menu();break;
                case 4: MostrarHexadecimal();menu();break;
                case 5: Console.ReadKey();break;
                default: Console.WriteLine("Opcion incorrecta");menu();break;
            }
        }
        static void MostraDecimal()
        {
            Console.WriteLine("Sistema decimal");
            var d =new csSistema_decimal(10);
            Console.WriteLine($"El numero en base diez es: {d.calcular()}");
        }
        static void MostrarBinario()
        {
            Console.WriteLine("Sistema binario");
            var b=new csSistema_binario(10);
            Console.WriteLine(b.calcular());
        }
        static void MostrarOctal()
        {
            Console.WriteLine("Sistema octal");
            var o=new csSistema_octal(10);
            Console.WriteLine(o.calcular());
        }
        static void MostrarHexadecimal()
        {
            Console.WriteLine("Sistema hexadecimal");
            var h=new csSistema_hexadecimal(10);
            Console.WriteLine(h.calcular());
        }
    }
}

