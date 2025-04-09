using Problema_1;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu(){
            Console.WriteLine("Menu principal");
            Console.WriteLine("1) Consulta Persona");
            Console.WriteLine("2) Consulta Médica");
            Console.WriteLine("3) Consulta Médica");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Ingrese una opcion...");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion){
                case 1: MostrarConsultaPersona();menu();break;
                case 2: MostrarConsultaMedica();menu();break;
                case 3: MostrarConsultaBuffete();menu();break;
                case 4: Console.ReadKey();break;
                default: Console.WriteLine("Opcion incorrecta");menu();break;
            }
        }
        static void MostrarConsultaPersona()
        {
            Console.WriteLine("\n--- CONSULTA PERSONA ---");
            var persona = new csPersona("Juan Pérez", 30, 70.5, 1.75, "Masculino", 50.00);
            Console.WriteLine(persona.verPersonas());
        }
        static void MostrarConsultaMedica()
        {
            Console.WriteLine("\n--- CONSULTA MÉDICA ---");
            var consultaMedica = new csConsultaMedica(
                "María González", 35, 65.0, 1.68, "Femenino",
                "2023-05-15", "Control anual", 1.5, 75.00);

            Console.WriteLine(consultaMedica.verPersonas());
            Console.WriteLine($"\nCálculo independiente: {consultaMedica.calcularPrecioConsulta():C}");
        }
        static void MostrarConsultaBuffete()
        {
            Console.WriteLine("\n--- CONSULTA BUFFETE ---");
            var consultaBuffete = new csConsultaBuffete("Carlos López", 45, 80.0, 1.78, 
            "Masculino", 120.00,"AB-12345", "Asesoría legal para contrato de arrendamiento");

            Console.WriteLine(consultaBuffete.verPersonas());
            Console.WriteLine(consultaBuffete.verConsultas(150.00)); 
        }
    }
}
