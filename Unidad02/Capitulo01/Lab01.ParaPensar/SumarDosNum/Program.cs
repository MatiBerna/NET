using System;

namespace SumarDosNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;

            Console.Write("Ingrese primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            res = num1 + num2;
            Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es "+ res);
            Console.ReadKey();
        }
    }
}
