using System;

namespace Clave
{
    internal class Program
    {
        private const string clave = "hola123";
        static void Main(string[] args)
        {
            if (ingresoClave())
            {
                Console.WriteLine("Clave Correcta");
            }
            else
            {
                Console.WriteLine("3 intentos fallidos, fin de programa.");
            }
            Console.ReadKey();
            
        }

        public static bool ingresoClave()
        {
            int intentos = 0;

            while (intentos < 4)
            {
                intentos++;

                Console.WriteLine("Ingrese clave: ");
                string input = Console.ReadLine();

                if (input == clave)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
