using System;

namespace ClassLibrary
{
    public class A
    {
        string NombreInstancia;

        public A() {
            NombreInstancia = "Instancia sin Nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;
        }

        public string MostrarNombre()
        {
            return NombreInstancia;
        }

        public void M1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }

        public void M2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }

        public void M3()
        {
            Console.WriteLine("El metodo M3 fue invocado");
        }
    }
}
