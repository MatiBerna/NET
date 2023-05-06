using System;

namespace PrimosGemelos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, antNum, max,i = 0;
            num = antNum = 1;

            Console.Write("Ingrese maximo de numeros primos gemelos a calcular: ");
            max = int.Parse(Console.ReadLine());

            while(i < max)
            {
                if (EsPrimo(num))
                {
                    if((num-antNum) == 2)
                    {
                        Console.WriteLine(antNum + " " + num);
                        i++;
                    }
                    antNum = num;
                    
                }
                num++;
            }
            Console.ReadKey();
        }

        public static bool EsPrimo(int num)
        {
            if(num < 2)
            {
                return false;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
