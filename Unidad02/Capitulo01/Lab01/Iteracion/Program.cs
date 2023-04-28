using System;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] textos = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese texto " + (i+1) + ": ");
                textos[i] = Console.ReadLine();
            }

            for (int i = cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine(textos[i]);
            }
            Console.ReadKey();
        }
    }
}
