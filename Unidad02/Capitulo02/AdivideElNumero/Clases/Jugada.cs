using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Jugada
    {
        int _numero;
        private bool _adivino;
        private int _intentos = 1;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            Console.WriteLine("Numero aleatorio generado "+ Numero+
                
                
                
                
                
                
                
                
                
                
                );

            Adivino = false;
        }

        public int Numero { 
            get { return _numero; }
            set { _numero = value; }
        }

        public bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
        }

        public int Intentos
        {
            get { return _intentos; }
            set { _intentos = value; }
        }

        public bool Comparar(int numero)
        {
            if(numero == Numero)
            {
                Adivino = true;
                Console.WriteLine("Felicitaciones, adivinó el numero.");
            }
            else
            {
                Console.WriteLine("Numero incorrecto");
                Intentos++;
            }
            return Adivino;
        }
    }
}
