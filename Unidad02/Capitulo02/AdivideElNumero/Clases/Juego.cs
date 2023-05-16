using System;

namespace Clases
{
    public class Juego
    {
        private int _record = 99999999;

        public Juego()
        {
            _record = 0;
        }

        public void ComenzarJuego()
        {
            int max = PreguntarMaximo();
            
            bool continua = true;

            while (continua)
            {
                bool adivino = false;
                Jugada jugada = new Jugada(max);
                Console.WriteLine($"Record actual: {_record}");

                while (!adivino)
                {
                    Console.WriteLine($"Intento numero: {jugada.Intentos}");
                    int num = PreguntarNumero();

                    adivino = jugada.Comparar(num);
                }

                CompararRecord(jugada.Intentos);

                continua = Continuar();
            }
        }


        private void CompararRecord(int intentos)
        {
            if(intentos < _record)
            {
                _record = intentos;
                Console.WriteLine("NUEVO RECORD\tNUEVO RECORD\tNUEVO RECORD\n¡FELICITACIONES! Haz hecho un nuevo record.");
            }
        }

        private bool Continuar()
        {
            Console.WriteLine("Presione Escape para salir. Presione cualquier tecla para seguir jugando.");
            ConsoleKeyInfo key = Console.ReadKey();

            if(key.Key == ConsoleKey.Escape)
            {
                return false;
            }
            else { return true; }
        }

        private int PreguntarMaximo()
        {
            Console.Write("Ingrese numero máximo aleatorio: ");
            bool succes = int.TryParse(Console.ReadLine(), out int max);
            while (!succes)
            {
                Console.Write("Entrada invalida.\nPor favor, ingrese un numero máximo: ");
                succes = int.TryParse(Console.ReadLine(), out max);
            }
            return max;
        }

        private int PreguntarNumero()
        {
            Console.Write("Ingrese un número: ");
            bool succes = int.TryParse(Console.ReadLine(), out int num);
            while (!succes)
            {
                Console.Write("Entrada invalida.\nPor favor, ingrese un número: ");
                succes = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
    }
}
