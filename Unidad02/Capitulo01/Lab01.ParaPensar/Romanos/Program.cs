using System;
using System.Collections.Generic;

namespace Romanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero: ");
            int num = int.Parse(Console.ReadLine());


            Dictionary<int, string> numRomanos = new Dictionary<int, string>
            {
                {1000,"M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

            int aux = num;
            string numRomano = "";

            if (num < 1 || num > 3999)
            {
                Console.WriteLine("El numero debe estar entre 1 y 3999");
            }
            else
            {
                foreach (KeyValuePair<int,String> par in numRomanos)
                {
                    while (aux >= par.Key)
                    {
                        numRomano += par.Value;
                        aux -= par.Key;
                    }
                }

                Console.WriteLine(numRomano);
            }

            Console.ReadKey();

        }
    }
}
