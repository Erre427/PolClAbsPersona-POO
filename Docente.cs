using System;

namespace P7PolClAbsPersona
{
    public class Docente:Persona
    {
        // Atributos de la clase hija
        private string Materia;
        private int Grupos = 0;
        // Propiedades de los atributos
        public string mat
        {
            get
            {
                return Materia;
            }
            set
            {
                Materia = value;
            }
        }

        public int grup
        {
            get
            {
                return Grupos;
            }
            set
            {
                Grupos = value;
            }
        }
        // Constructor predefinido
        public Docente() : base()
        {
            
        }
        // Constructor sobrecargado
        public Docente(string n, int e, string m, int g) : base(n, e)
        {
            mat = m;
            grup = g;
        }
        // Metodos de la clase
        public override void Imprime()
        {
            Console.WriteLine("DOCENTE\n" +
                              "-----------------------");
            base.Datos();
            Console.WriteLine("Materia que se imparte: {0}",mat);
            Console.WriteLine("Grupos asignado: {0}",grup);
        }
    }
}