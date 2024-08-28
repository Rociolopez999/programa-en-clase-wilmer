using System;

class Program

{
    static void Main(string[] arg)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Ventas Varias ===");
            Console.WriteLine("1. Transistores");
            Console.WriteLine("2. Capacitores");
            Console.WriteLine("3. Leds");
            Console.WriteLine("4. Salir");
            Console.WriteLine("=====================");
            Console.Write("Seleccione una opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has Seleccionado la Opcion 1.");
                    break;

                case "2":
                    Console.WriteLine("Has Seleccionado la Opcion 2.");
                    break;

                case "3":
                    Console.WriteLine("Has Seleccionado la Opcion 2.");
                    break;

                case "4":
                    Console.WriteLine("Has Seleccionado la Opcion 2.");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion ni Valida. Intente de Nuevo.");
                    break;


            }

            if (continuar)
            {
                Console.WriteLine("Precione Cualquier tecla Para continuar ...");
                Console.ReadKey();
            }
        }
    }
}



