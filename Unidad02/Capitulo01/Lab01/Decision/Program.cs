using System;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese texto: ");
            string inputTexto = Console.ReadLine();

            if(inputTexto.Length != 0 )
            {
                Console.Write("\t1.MAYUSCULAS \n\t2.minusculas\n\t3.Longitud\nIngrese opcion:");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                    default: 
                        Console.WriteLine("Opcion incorrecta, fin del programa.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se ingreso un texto, fin del programa.");
            }

        }
    }
}
