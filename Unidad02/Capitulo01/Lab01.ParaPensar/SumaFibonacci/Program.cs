using System;

namespace SumaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int antNum = 0;
            int max, aux, suma = num;

            Console.Write("Ingrese cantidad de iteraciones máxima: ");
            max = int.Parse(Console.ReadLine());

            for(int i = 0; i < max; i++)
            {
                aux = num;
                num = num + antNum;
                antNum = aux;

                suma = suma + num;
            }

            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
