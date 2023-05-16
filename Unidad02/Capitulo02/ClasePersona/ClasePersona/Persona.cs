using System;

namespace ClasePersona
{
    public class Persona
    {
        private string m_nombre;
        private string m_apellido;
        private int m_dni;
        private int m_edad;

        public Persona(string m_nombre, string m_apellido, int m_dni, int m_edad)
        {
            this.m_nombre = m_nombre;
            this.m_apellido = m_apellido;
            this.m_edad = m_edad;
            this.m_dni = m_dni;
        }  

        ~Persona()
        {
            throw new System.NotImplementedException();
        }

        public string Nombre
        {
            get
            {
                return m_nombre;
            }
            set
            {
                m_nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return m_apellido;
            }
            set
            {
                m_apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return m_dni;
            }
            set
            {
                m_dni = value;
            }
        }

        public int Edad
        {
            get
            {
                return m_edad;
            }
            set
            {
                m_edad = value;
            }
        }

        public string getFullName()
        {
            return m_nombre + " " + m_apellido;
        }

        public int getAge()
        {
            return m_edad;
        }
    }
}
