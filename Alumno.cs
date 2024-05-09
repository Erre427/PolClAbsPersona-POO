using System;
using System.Security.Permissions;

namespace P7PolClAbsPersona
{
    public class Alumno: Persona
    {
        // Atributos de la clase hija
        private int Semestre;
        private float Promedio = 0;
        // Propiedades de los atributos
        public int sem
        {
            get
            {
                return Semestre;
            }
            set
            {
                Semestre = value;
            }
        }

        public float prom
        {
            get
            {
                return Promedio;
            }
            set
            {
                Promedio = value;
            }
        }
        // Constructor predefinido
        public Alumno() : base()
        {
            
        }
        // Constructor sobrecargado
        public Alumno(string n, int e, int s, float p) : base(n, e)
        {
            sem = s;
            prom = p;
        }

        public override void Imprime()
        {
            Console.WriteLine("ALUMNO\n" +
                              "-------------------");
            base.Datos();
            Console.WriteLine("Semestre cursando: {0}",sem);
            Console.WriteLine("Promedio general: {0}",prom);
        }
    }
}