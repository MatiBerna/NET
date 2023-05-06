using System;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cantidad de filas: ");
            int maxFilas = int.Parse(Console.ReadLine());

            for(int i = 0;i < maxFilas;i++)
            {
                string fila = "";
                for(int j = 0;j <= 2*maxFilas-1; j++)
                {
                    if (j >= ((2*maxFilas-1) / 2 - i) && j <= (2*maxFilas - 1) / 2 + i)
                    {
                        fila += "*";
                    }
                    else
                    {
                        fila += " ";
                    }
                }

                Console.WriteLine(fila);
            }
        }
    }
}
