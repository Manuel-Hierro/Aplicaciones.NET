using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/**************************************
    Autor: Manuel Jesus Hierro Pinto
    Fecha Creacion:       24/04/2018
    Ultima Modificacion:  20/05/2018
    Version:              Beta
 **************************************/

namespace Programacion___1º_Problema___3EV
{
    class Program
    {
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Directivo> Directivos = new List<Directivo>();
        public static List<Operario> Operarios = new List<Operario>();
        public static int nDias = 0;
        /*****************************************************************************************************/
        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 36);
            Console.Clear();
            Console.Write("\t======  Resumen Empleados  ======");
            Console.Write("\t\n\n             - Calculo del Salario -");
            Console.Write("\t\n       -----------------------------------");
            AñadirEmpleados();
            MostrarSueldos();
            Console.ReadKey();          
        }       
        /// <summary>
        /// Muestra la Informacion
        /// </summary>
        public static void MostrarSueldos()
        {
            Console.WriteLine("\t\t\n        Introduce el numero de Dias: ");
            nDias = excepciones(Console.ReadLine());
            Console.WriteLine("\t\t\n        Salarios:");
            Console.WriteLine("\t-----------------------------------");
            foreach (Directivo elem in Directivos)
            {
                elem.Sueldo(nDias);
                elem.MostrarSueldo();
            }
            foreach (Empleado elem in Empleados)
            {
                elem.Sueldo(nDias);
                elem.MostrarSueldo();
            } 
            foreach (Operario elem in Operarios)
            {
                elem.Sueldo(nDias);
                elem.MostrarSueldo();
            }            
            Console.WriteLine("\n\tResumen de directivos:");
            Console.WriteLine("\t-----------------------------------");
            foreach (Directivo elem in Directivos)
            {
                Console.Write("\t{0} \t\t{1}", elem.nombre, elem.EmpleadosSupervisados.Count);
                foreach (Empleado ele in elem.EmpleadosSupervisados)
                {
                    Console.Write("\t {0}", ele.nombre);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Controlador de excepciones
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Resultado de la comprobacion</returns>
        static int excepciones(string x)
        {
            int resultado = -1;
            try
            {
                resultado = int.Parse(x);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1000);
            }
            return resultado;
        }
        /// <summary>
        /// Añadimos los Empleados
        /// </summary>
        public static void AñadirEmpleados()
        {
            Directivos.Add(new Directivo("Jose", true));
            Directivos.Add(new Directivo("Manuel", true));
            Directivos.Add(new Directivo("Laura", true));
            Directivos.Add(new Directivo("Maria", false));
            Directivos.Add(new Directivo("Rocio", false));

            Empleados.Add(new Empleado("Manuel", true));
            Empleados.Add(new Empleado("Jesús", true));
            Empleados.Add(new Empleado("Jacinto", true));
            Empleados.Add(new Empleado("Victor", true));
            Empleados.Add(new Empleado("Samu", true));
            Empleados.Add(new Empleado("Alba", true));
            Empleados.Add(new Empleado("Isabel", true));
            Empleados.Add(new Empleado("Lorenzo", false));
            Empleados.Add(new Empleado("Antonio", false));
            Empleados.Add(new Empleado("Alicia", true));

            Operarios.Add(new Oficial("Pedro", true));
            Operarios.Add(new Oficial("Miguel", false));

            Operarios.Add(new Tecnico("Carmen", true));
            Operarios.Add(new Tecnico("Sebas", true));
            Operarios.Add(new Tecnico("Rodrigo", false));


            Directivos[0].Supervisa(Operarios[0]);
            Directivos[0].Supervisa(Operarios[1]);
            Directivos[0].Supervisa(Operarios[2]);

            Directivos[1].Supervisa(Empleados[0]);
            Directivos[1].Supervisa(Empleados[1]);
            Directivos[1].Supervisa(Empleados[2]);

            Directivos[2].Supervisa(Empleados[3]);
            Directivos[2].Supervisa(Empleados[4]);
        }
    }
}
