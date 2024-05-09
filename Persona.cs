using System;

namespace P7PolClAbsPersona
{
    public abstract class Persona
    {
        // Atributos de la clase padre
        private string Nombre;
        private int Edad = 0;
        // Propiedades de los atributos
        public string nom
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int ed
        {
            get
            {
                return Edad;
            }
            set
            {
                Edad = value;
            }
        }
        // Constructor predefinido
        public Persona()
        {
            
        }
        // Constructor sobrecargado
        public Persona(string n, int e)
        {
            nom = n;
            ed = e;
        }
        // Metodos de la clase Abstracta
        public abstract void Imprime();

        public void Datos()
        {
            Console.WriteLine("Nombre: {0}", nom);
            Console.WriteLine("Edad: {0}", ed);
        }

    }
}