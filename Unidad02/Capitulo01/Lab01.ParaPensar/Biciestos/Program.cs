using System;

namespace Biciestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio;
            bool bisiesto = false;

            Console.Write("Ingrese un año: ");
            anio = int.Parse(Console.ReadLine());

            if(anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if(anio % 400 == 0)
                    {
                        bisiesto = true;
                    }
                }
                else
                {
                    bisiesto = true; 
                }
            }

            if (bisiesto)
            {
                Console.WriteLine(anio + " es bisiesto.");
            }
            else
            {
                Console.WriteLine(anio + " no es bisiesto.");
            }b


        }
    }
}
