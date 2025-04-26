using System;
using SegundoParcial;


namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu(){
            Console.WriteLine("--------Menu Principal--------");
            Console.WriteLine("1. Venta De Articulo");
            Console.WriteLine("2. Salir");
            Console.WriteLine("Elija Una Opcion");

            int opcion =Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: 
                    venta();
                    menu();
                    break;
                case 2:
                    Console.WriteLine("Programa Finalizado");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        static void venta(){
            Console.WriteLine("--------Venta Articulo--------");

            Console.WriteLine("Ingrese EL Nombre Del Articulo: ");
            string nombre=Console.ReadLine();
            Console.WriteLine("Ingrese El Precio Venta: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese El Tipo De Pago: ");
            string tipo = Console.ReadLine();
            Console.WriteLine("Ingrese La Cantidad de Dinero Presentado:");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            csVenta v = new csVenta(nombre,precio,tipo,cantidad);

            Console.WriteLine($"Nombre Del Articulo: {v.NombreArticulo}");
            Console.WriteLine($"Precio Venta: {v.PrecioVenta}");
            Console.WriteLine($"Iva Incluido: {v.calcularIva()}");
            Console.WriteLine($"Mensaje: {v.retonarRespuesta()}");
            
        }
    
    }
}
