using System;
using ClassLibrary;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A instA = new A();
            B instB = new B();

            A segA = new A("Otra instancia");

            Console.WriteLine(instA.MostrarNombre());
            Console.WriteLine(instB.MostrarNombre());
            Console.WriteLine(segA.MostrarNombre());


            instB.M4();
            instA.M3();
            instB.M2();

        }
    }
}
