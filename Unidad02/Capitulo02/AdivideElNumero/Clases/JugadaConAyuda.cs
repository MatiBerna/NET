using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        new public bool Comparar(int numero)
        {
            if (numero == Numero)
            {
                Adivino = true;
                Console.WriteLine("Felicitaciones, adivinó el numero.");
            }
            else
            {
                Console.Clear();
                
                if (numero > Numero)
                {
                    Console.Write("El numero ingresado es mayor al esperado,");
                }
                else
                {
                    Console.Write("El numero ingresado es menor al esperado, ");
                }


                if (Math.Abs(numero-Numero) > 100)
                {
                    Console.WriteLine("y está muy lejos. ");
                }
                else if(Math.Abs(numero-Numero) <= 100 && Math.Abs(numero-Numero) > 5)
                {
                    Console.WriteLine("y está cerca. ");
                }
                else
                {
                    Console.WriteLine("y está MUY cerca. ");
                }
                Intentos++;
            }
            return Adivino;
        }
    }
}