using System;

namespace P7PolClAbsPersona
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Declaracion de variables
            char opc;
            bool ban = true;
            // Try para la deteccion de excepciones dentro del programa
            try
            {
                // Ciclo do while si ban es igual a true
                do
                {
                    // Se borra pantalla cada vez que se reinicia ciclo
                    Console.Clear();
                    Console.WriteLine("CAPTURA E IMPRESION DE DATOS\n" +
                                      "-------------------------------------");
                    Console.WriteLine("1.- Docente\n" +
                                      "2.- Alumno\n" +
                                      "3.- Salir");
                    opc = Console.ReadKey().KeyChar;
                    switch (opc)
                    {
                        case '1':
                            CaptaImpDoc();
                            Console.ReadKey();
                            break;
                        case '2':
                            CaptaImpAlumn();
                            Console.ReadKey();
                            break;
                        case '3':
                            ban = false;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            Console.ReadKey();
                            break;
                        
                    }
                } while (ban == true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Se ingreso un dato erroneo");
            }
        }

        static void CaptaImpDoc()
        {
            // Se crea el objeto Docente
            Docente PerDoc = new Docente();
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            PerDoc.nom = Console.ReadLine();
            Console.Write("Ingrese Edad: ");
            PerDoc.ed = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Materia que imparte: ");
            PerDoc.mat = Console.ReadLine();
            Console.Write("Ingrese Grupos que imparte: ");
            PerDoc.grup = int.Parse(Console.ReadLine());
            // Se borra pantalla y se imprimen datos llamando al metodo del objeto
            Console.Clear();
            PerDoc.Imprime();
            Console.ReadKey();
        }

        static void CaptaImpAlumn()
        {
            // Se crea el objeto Alumno
            Alumno PerAlum = new Alumno();
            // Se borra pantalla y se capturan datos
            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            PerAlum.nom = Console.ReadLine();
            Console.Write("Ingrese Edad: ");
            PerAlum.ed = int.Parse(Console.ReadLine());
            Console.Write("Semestre en que se cursa: ");
            PerAlum.sem = int.Parse(Console.ReadLine());
            Console.Write("Promedio general del alumno: ");
            PerAlum.prom = float.Parse(Console.ReadLine());
            // Se borra pantalla y se imprimen los datos mandando a llamar el metodo del objeto
            Console.Clear();
            PerAlum.Imprime();
            Console.ReadKey();
        }
    }
}