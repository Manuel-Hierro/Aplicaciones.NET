using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************
    Autor: Manuel Jesus Hierro Pinto
    Fecha Creacion:       31/01/2018
    Ultima Modificacion:  15/06/2018
    Version:              1.01 Alpha
 **************************************/

namespace Practica_2º_Evaluacion
{
    class Program
    {
        /// <summary>
        /// Listas donde guardaremos la informacion relacionada de las Aulas y los Ordenadores, 
        /// junto con estos mismos
        /// </summary>
        public static List<Aula> Clase = new List<Aula>();
        public static List<Ordenador> PC = new List<Ordenador>();
        IEnumerable<Aula> ClaseO = Clase.OrderBy(item => item.id);
        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 36);
            MenuPrincipal();                        
        }
        #region MenuPrincipal
        /// <summary>
        /// Funcion del switch principal el cual llama, al Menu Principal 
        /// </summary>
        static void MenuPrincipal()
        {
            const char Salir_P = '0';
            char opcion;
            do
            {
                MuestraMenuPrincipal();
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        Aulas_Salas_del_Centro();
                        break;
                    case '2':
                        Ordenadores();
                        break;
                    case '3':
                        Busquedas();
                        break;
                    case '4':
                        Listados();
                        break;
                    case '5':
                        Configuracion();
                        break;
                }
            } while (opcion != Salir_P);
        }
        /// <summary>
        /// Funcion que describe la forma del Menu Principal
        /// </summary>
        static void MuestraMenuPrincipal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("====== GESTION DE ORDENADORES ======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1. Aulas/Salas del Centro");
            Console.SetCursorPosition(15, 5); Console.Write("2. Ordenadores");
            Console.SetCursorPosition(15, 6); Console.Write("3. Busquedas");
            Console.SetCursorPosition(15, 7); Console.Write("4. Listados");
            Console.SetCursorPosition(15, 8); Console.Write("5. Configuracion");
            Console.ResetColor();
            Console.SetCursorPosition(15, 9); Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 10); Console.Write("0. Salir");
            Console.ResetColor();
            Console.SetCursorPosition(15, 12); Console.Write("Introduzca una opción: ");
        }
        #endregion
        #region Aulas
        /// <summary>
        /// Funcion del switch/Aulas el cual llama, al Menu Aulas
        /// </summary>
        static void Aulas_Salas_del_Centro()
        {
            const char Salir_A = '0';
            char opcion;
            do
            {
                MuestraMenuAulas();
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        VerAulas();
                        break;
                    case '2':
                        AñadirAulas();
                        break;
                    case '3':
                        BorrarAula();
                        break;
                    case '4':
                        ModificarAula();
                        break;                                   
                }
            } while (opcion != Salir_A);            
        }
        /// <summary>
        /// Funcion que describe la forma del Menu Aulas
        /// </summary>
        static void MuestraMenuAulas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("====== AULAS ======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1. Ver Aulas");
            Console.SetCursorPosition(15, 5); Console.Write("2. Añadir Aula");
            Console.SetCursorPosition(15, 6); Console.Write("3. Borrar Aula");
            Console.SetCursorPosition(15, 7); Console.Write("4. Modificar Aula");
            Console.ResetColor();
            Console.SetCursorPosition(15, 8); Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 9); Console.Write("0. Volver al Menu Principal");
            Console.ResetColor();
            Console.SetCursorPosition(15, 11); Console.Write("Introduzca una opción: ");
        }
        /// <summary>
        /// Muesra las aulas y la informacion contenida en ellas,
        /// de las aulas registradas en la lista Clase
        /// </summary>
        static void VerAulas()
        {       
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.Write("\t\t\t======  Listado de Aulas  ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\t\tNombre\t\tNº Ordenadores\t\tFecha y Hora de Modificacion");
                Console.SetCursorPosition(24, 5); Console.Write("==\t\t=======\t\t===============\t\t============================");
                int m = 0;                            
                for (int i = 0; i < Clase.Count; i++) //Va mostrando cada elemento de la lista Clase
                {
                    for (int u = 0; u < PC.Count; u++)
                    {
                        if (PC[u].ubicacion == Clase[i].id)
                        {
                            Clase[i].ubicacion++;
                        }
                    }
                    Console.SetCursorPosition(24, 6 + m); VerDatosAula(Clase[i]); //Muestra cada elemento en una linea mas abajo
                    m++;
                    Clase[i].ubicacion = 0;                         
                }
                Console.SetCursorPosition(24, 7 + m); Console.Write("====================================================================================");
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Aulas: {0}", Clase.Count);
                Console.SetCursorPosition(24, 9 + m); Console.Write("Nº Ordenadores: {0}", PC.Count);

                Console.SetCursorPosition(24, 11 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        /// <summary>
        /// Funcion que permite añadir aulas a la lista, invocando a la funcion 
        /// que permite introducir los datos de las aulas
        /// </summary>
        static void AñadirAulas()
        {
            do
            {
                int m = 0;
                for (int i = 0; i < Clase.Count; i++)
                {                    
                   m++;
                }
                Console.Clear();
                LeeDatosAula(); //Invocamos la funcion para introducir los datos
                Console.SetCursorPosition(24, 14 + m); Console.Write("¿Desea volver a añadir un Aula? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        /// <summary>
        /// Funcion que permite borrar aulas a la lista, y comprobando
        /// que esta aula ya exista, si no, no podria borrarse y preguntaria que hacer
        /// </summary>
        static void BorrarAula()
        {            
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.WriteLine("Introduzca el ID del Aula que desea borrar (Pulse 0 para ver lista de Aulas): ");
                Console.SetCursorPosition(15, 4); int Borrar = int.Parse(Console.ReadLine()); //Lee el ID                
                
                if (Borrar == 0)
                {
                    VerAulas();
                }
                else
                {
                    Aula item = Clase.Find(test => test.id == Borrar); //Crea una variable donde guarda la busqueda
                    
                    if (item != null) //Si no es nulo 'existe'
                    {
                        Console.SetCursorPosition(15, 6); Console.WriteLine("El ID existe, ¿Desea borrar los datos asociados? (S/N)");

                        if (Console.ReadKey().Key == ConsoleKey.S) //Pulsamos S para lo Borrarlo
                        {
                            int total = 0;
                            for (int i = 0; i < Clase.Count; i++) //Va mostrando cada elemento de la lista Clase
                            {
                                for (int u = 0; u < PC.Count; u++)
                                {
                                    if ((PC[u].ubicacion == Clase[i].id) && (PC[u].ubicacion == Borrar))
                                    {
                                        total++;                                     
                                    }
                                }
                                Console.SetCursorPosition(15, 8); Console.WriteLine("Este aula contiene ({0}) Ordenadores asociados, ¿Desea continuar? (S/N)", total);                                
                            }

                            if (Console.ReadKey().Key == ConsoleKey.S) //Pulsamos S para lo Borrarlo
                            {
                                for (int e = PC.Count; e != 0; e--)
                                {
                                    Ordenador item2 = PC.Find(test2 => test2.ubicacion == item.id); //Crea una variable donde guarda la busqueda
                                    PC.Remove(item2);
                                }
                                Clase.Remove(item);
                                Console.SetCursorPosition(15, 10); Console.WriteLine("Los Datos (Aula con sus Ordenadores) Fueron Borrados");
                            }
                        }                        
                    }
                    else //Si es nulo 'no existe'
                    {
                        Console.SetCursorPosition(15, 6); Console.WriteLine("El ID no existe");
                    }
                    Console.SetCursorPosition(15, 12); Console.WriteLine("¿Desea volver a buscar? (S/N)");
                }
             } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        /// <summary>
        /// Funcion que permite modificar aulas de la lista comprobando que esta aula ya exista, si no,
        /// no podria modificarse y preguntaria que hacer, si existe la borra y llama a la funcion de Leer aula 
        /// para introducir una nueva
        /// </summary>
        static void ModificarAula()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.WriteLine("Introduzca el ID del Aula que desea modificar (Pulse 0 para ver lista de Aulas): ");
                Console.SetCursorPosition(15, 4); int Modificar = int.Parse(Console.ReadLine()); //Lee el ID

                if (Modificar == 0)
                {
                    VerAulas();
                }
                else
                {

                    Aula item = Clase.Find(test => test.id == Modificar); //Crea una variable donde guarda la busqueda

                    if (item != null) //Si no es nulo 'existe'
                    {
                        Console.SetCursorPosition(15, 6); Console.WriteLine("El ID existe, ¿Desea modificar los datos asociados? (S/N)");

                        if (Console.ReadKey().Key == ConsoleKey.S) //Pulsamos S para lo Borrarlo
                        {
                            Clase.Remove(item); //Borra el aula existente
                            Console.Clear();
                            LeeDatosAula();     //Pide nuevos datos para el aula que se va crear
                        }
                    }
                    else  //Si es nulo 'no existe'
                    {
                        Console.SetCursorPosition(15, 6); Console.WriteLine("El ID no existe");
                    }
                    Console.SetCursorPosition(15, 12); Console.WriteLine("¿Desea volver a Modificar? (S/N)");
                }
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        #endregion Aulas              
        #region Ordenadores
        /// <summary>
        /// Funcion del switch/Ordenadores el cual llama, al Menu Ordenadores
        /// </summary>
        static void Ordenadores()
        {
            const char Salir_O = '0';
            char opcion;
            do
            {
                MuestraMenuOrdenadores();
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        VerOrdenadores();
                        break;
                    case '2':
                        AñadirOrdenadores();
                        break;
                    case '3':
                        BorrarOrdenadores();
                        break;
                    case '4':
                        CambiarOrdenadores();
                        break;
                    case '5':
                        ModificarOrdenadores();
                        break;
                }
            } while (opcion != Salir_O);
        }
        /// <summary>
        /// Funcion que describe la forma del Menu Ordenadores
        /// </summary>
        static void MuestraMenuOrdenadores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("====== ORDENADORES ======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1. Ver Lista de Ordenadores");
            Console.SetCursorPosition(15, 5); Console.Write("2. Añadir Ordenador");
            Console.SetCursorPosition(15, 6); Console.Write("3. Borrar Ordenador");
            Console.SetCursorPosition(15, 7); Console.Write("4. Cambiar Ordenador de Aula");
            Console.SetCursorPosition(15, 8); Console.Write("5. Modificar Ordenador");
            Console.ResetColor();
            Console.SetCursorPosition(15, 9); Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 10); Console.Write("0. Volver al Menu Principal");
            Console.ResetColor();
            Console.SetCursorPosition(15, 12); Console.Write("Introduzca una opción: ");
        }
        /// <summary>
        /// Muesra los Ordenadores y la informacion contenida,
        /// de los Ordenadores registrados en la lista PC
        /// </summary>
        static void VerOrdenadores()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.Write("\t\t======  Listado de Ordenadores  ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\t\t\tAula\t\t\tFecha y Hora de Creacion");
                Console.SetCursorPosition(24, 5); Console.Write("==\t\t\t====\t\t\t=========================");
                int m = 0;
                for (int i = 0; i < PC.Count; i++) //Va mostrando cada elemento de la lista PC
                {                    
                    Console.SetCursorPosition(24, 6 + m); VerDatosOrdenador(PC[i]); //Muestra cada elemento en una linea mas abajo
                    m++;
                }
                Console.SetCursorPosition(24, 7 + m); Console.Write("=========================================================================");                
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Ordenadores: {0}", PC.Count);

                Console.SetCursorPosition(24, 10 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        /// <summary>
        /// Funcion que permite añadir ordenadores a la lista, invocando a la funcion 
        /// que permite introducir los datos de los ordenadores
        /// </summary>
        static void AñadirOrdenadores()
        {            
            do
            {                
                LeeDatosOrdenador(); 
                Console.SetCursorPosition(24, 12); Console.Write("¿Desea volver a añadir un Ordenador? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        static void BorrarOrdenadores()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.WriteLine("Introduzca el ID del Ordenador que desee borrar (Pulse 0 para ver lista de Ordenadores): ");
                Console.SetCursorPosition(24, 4); string Borrar = Console.ReadLine(); //Lee el ID

                Ordenador item = PC.Find(test => test.id == Borrar); //Crea una variable donde guarda la busqueda

                if (item != null) //Si no es nulo 'existe'
                {
                    Console.SetCursorPosition(24, 6); Console.WriteLine("El ID existe, ¿Desea borrar los datos asociados? (S/N)");

                    if (Console.ReadKey().Key == ConsoleKey.S) //Pulsamos S para lo Borrarlo
                    {
                        PC.Remove(item);
                        Console.SetCursorPosition(24, 8); Console.WriteLine("Los Datos Fueron Borrados");
                    }
                }
                else //Si es nulo 'no existe'
                {
                    Console.SetCursorPosition(24, 6); Console.WriteLine("El ID no existe");
                }
                Console.SetCursorPosition(24, 8); Console.WriteLine("¿Desea volver a buscar? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);           
        }
        static void CambiarOrdenadores()
        {
            Console.Clear();
            Console.SetCursorPosition(15, 2); Console.WriteLine("En Construccion...");
            Console.SetCursorPosition(15, 4); Console.WriteLine("Presione una tecla para salir");
            Console.SetCursorPosition(15, 5); Console.ReadKey();
        }
        static void ModificarOrdenadores()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.WriteLine("Introduzca el ID del Ordenador que desea modificar (Pulse 0 para ver lista de Ordenadores): ");
                Console.SetCursorPosition(15, 4); string Modificar = Console.ReadLine(); //Lee el ID

                Ordenador item = PC.Find(test => test.id == Modificar); //Crea una variable donde guarda la busqueda

                if (item != null) //Si no es nulo 'existe'
                {
                    Console.SetCursorPosition(15, 6); Console.WriteLine("El ID existe, ¿Desea modificar los datos asociados? (S/N)");

                    if (Console.ReadKey().Key == ConsoleKey.S) //Pulsamos S para lo Borrarlo
                    {
                        PC.Remove(item); //Borra el ordenador existente                       
                        LeeDatosOrdenador(); //Pide los datos para el nuevo ordenador a crear
                    }
                }
                else  //Si es nulo 'no existe'
                {
                    Console.SetCursorPosition(15, 6); Console.WriteLine("El ID no existe");
                }
                Console.SetCursorPosition(15, 12); Console.WriteLine("¿Desea volver a Modificar? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);            
        }
        #endregion Ordenadores
        #region Busquedas
        static void Busquedas()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.WriteLine("Introduzca el ID del Aula que desea Buscar: ");
                Console.SetCursorPosition(15, 4); int Buscar = int.Parse(Console.ReadLine()); 
                Aula item = Clase.Find(test => test.id == Buscar); 

                if (item != null) //Si no es nulo 'existe'
                {
                Console.SetCursorPosition(15, 6); Console.WriteLine("El ID existe ¿Desea Continuar? (S/N)");

                        if (Console.ReadKey().Key == ConsoleKey.S)
                        {
                            int total = 0;
                            for (int i = 0; i < Clase.Count; i++) 
                            {
                                for (int u = 0; u < PC.Count; u++)
                                {
                                    if ((PC[u].ubicacion == Clase[i].id) && (PC[u].ubicacion == Buscar))
                                    {
                                        total++;
                                    }
                                }
                                Console.SetCursorPosition(15, 8); Console.WriteLine("Este aula contiene ({0}) Ordenadores asociados", total);
                            }                           
                        }
                    }
                    else 
                    {
                        Console.SetCursorPosition(15, 6); Console.WriteLine("El ID no existe");
                    }
                    Console.SetCursorPosition(15, 12); Console.WriteLine("¿Desea volver a buscar? (S/N)");
                
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        #endregion Busquedas
        #region Listas        
        /// <summary>
        /// Funcion del switch/Listados el cual llama, al Menu Listados
        /// </summary>
        static void Listados()
        {
            const char Salir_L = '0';
            char opcion;
            do
            {
                MuestraMenuListas();
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        Opcion1();
                        break;
                    case '2':
                        Opcion2();
                        break;
                    case '3':
                        Opcion3();
                        break;
                    case '4':
                        Opcion4();
                        break;                    
                }
            } while (opcion != Salir_L);
        }
        /// <summary>
        /// Funcion que describe la forma del Menu Listados
        /// </summary>
        static void MuestraMenuListas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("====== Listados ======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1. Nº de Ordenadores por Aula");
            Console.SetCursorPosition(15, 5); Console.Write("2. Lista de Ordenadores ordenados por aula e identificador");
            Console.SetCursorPosition(15, 6); Console.Write("3. Aplicaciones Instaladas por cada ordenador");
            Console.SetCursorPosition(15, 7); Console.Write("4. Caracteristicas de cada Ordenador");            
            Console.ResetColor();
            Console.SetCursorPosition(15, 8); Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 9); Console.Write("0. Salir");
            Console.ResetColor();
            Console.SetCursorPosition(15, 11); Console.Write("Introduzca una opción: ");
        }
        static void Opcion1()
        {            
            do
            {
                Console.Clear();                
                Console.SetCursorPosition(24, 2); Console.Write("\t\t======  Listado de Aulas (Ordenadas) ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\t\tNombre\t\tNº Ordenadores");
                Console.SetCursorPosition(24, 5); Console.Write("==\t\t=======\t\t===============");
                int m = 0;                
                    for (int i = 0; i < Clase.Count; i++)
                    {
                        for (int u = 0; u < PC.Count; u++)
                        {
                            if (PC[u].ubicacion == Clase[i].id)
                            {
                                Clase[i].ubicacion++;
                            }
                        }
                        Console.SetCursorPosition(24, 6 + m); VerDatosAula2(Clase[i]);
                        m++;
                        Clase[i].ubicacion = 0;
                    }                
                Console.SetCursorPosition(24, 7 + m); Console.Write("====================================================================================");
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Aulas: {0}", Clase.Count);

                Console.SetCursorPosition(24, 10 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        static void Opcion2()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.Write("\t\t======  Listado de Ordenadores (Ordenados por Aula e ID) ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\t\tAula\t\tAplicaciones");
                Console.SetCursorPosition(24, 5); Console.Write("==\t\t=====\t\t====================================================");
                int m = 0;
                foreach (Ordenador item in PC)
                {
                    Console.SetCursorPosition(24, 6 + m); Console.WriteLine("{0}\t\t{1}\t\t{2}", item.id, item.ubicacion, item.aplicaciones);
                    m++;
                }
                Console.SetCursorPosition(24, 7 + m); Console.Write("====================================================================================");
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Ordenadores: {0}", PC.Count);

                Console.SetCursorPosition(24, 10 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        static void Opcion3()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.Write("\t\t======  Aplicaciones Instaladas por Ordenador ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\tAplicaciones");
                Console.SetCursorPosition(24, 5); Console.Write("==\t====================================================");
                int m = 0;
                foreach (Ordenador item in PC)
                {
                    Console.SetCursorPosition(24, 6 + m); Console.WriteLine("{0}\t{1}", item.id, item.aplicaciones);
                    m++;
                }
                Console.SetCursorPosition(24, 7 + m); Console.Write("====================================================================================");
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Ordenadores: {0}", PC.Count);

                Console.SetCursorPosition(24, 10 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        static void Opcion4()
        {
            do
            {
                Console.Clear();
                Console.SetCursorPosition(24, 2); Console.Write("\t\t======  Caracteristicas por Ordenador ======");
                Console.SetCursorPosition(24, 4); Console.Write("ID\tRam\tD.Duro\t\tT.Grafica\t\tProcesador\tFecha");
                Console.SetCursorPosition(24, 5); Console.Write("==\t=====\t=======\t\t=================\t========\t==========");
                int m = 0;
                foreach (Ordenador item in PC)
                {
                   Console.SetCursorPosition(24, 6 + m); Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}\t{5}", item.id, item.ram, item.discoduro, item.tarjetagrafica, item.procesador, item.fecha.ToString("MM:dd:yyyy"));
                   m++;
                }
                Console.SetCursorPosition(24, 7 + m); Console.Write("====================================================================================");
                Console.SetCursorPosition(24, 8 + m); Console.Write("Nº Ordenadores: {0}", PC.Count);

                Console.SetCursorPosition(24, 10 + m); Console.WriteLine("¿Desea volver a mostrar la lista? (S/N)");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
        #endregion Listas
        #region Configuracion
        /// <summary>
        /// Funcion del switch/Configuracion el cual llama, al Menu Configuracion
        /// </summary>
        static void Configuracion()
        {
            const char Salir_C = '0';
            char opcion;
            do
            {
                MuestraMenuConfiguracion();
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        MaxAulas();
                        break;
                    case '2':
                        MaxOrdenadores();
                        break;
                    case '3':
                        Pruebas();
                        break;                    
                }
            } while (opcion != Salir_C);
        }
        /// <summary>
        /// Funcion que describe la forma del Menu Configuracion
        /// </summary>
        static void MuestraMenuConfiguracion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("====== Configuracion ======");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1. Nº maximo de Aulas");
            Console.SetCursorPosition(15, 5); Console.Write("2. Nº maximo de Ordenadores por Aula");
            Console.SetCursorPosition(15, 6); Console.Write("3. Inicializacion Automatica para Pruebas");            
            Console.ResetColor();
            Console.SetCursorPosition(15, 8); Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 9); Console.Write("0. Salir");
            Console.ResetColor();
            Console.SetCursorPosition(15, 11); Console.Write("Introduzca una opción: ");
        }
        public static int MaxAulas()
        {
            Console.Clear();
            int maxa;
            Console.WriteLine("\n\tIntroduce el Maximo de Aulas: ");
            maxa = Console.Read();
            return  maxa;                 
        }
       public static int MaxOrdenadores()
        {
            Console.Clear();
            int maxo;
            Console.WriteLine("\n\tIntroduce el Maximo de Ordenadores: ");
            maxo = Console.Read();
            return maxo;            
        }
        /// <summary>
        /// Funcion que crea una serie de Aulas y Ordenadores dentro de las listas, para realizar
        /// pruebas de correcto funcionamiento del programa
        /// </summary>
        static void Pruebas()
        {
            Console.Clear();
            
            Aula a = new Aula(1, "Aula 1", DateTime.Now, 0);            
            if (Clase.Find(aa => aa.id == a.id) == null) Clase.Add(a);  

            Aula b = new Aula(2, "Aula 2", DateTime.Now, 0);            
            if (Clase.Find(bb => bb.id == b.id) == null) Clase.Add(b);  
            
            Aula c = new Aula(3, "Aula 3", DateTime.Now, 0);
            if (Clase.Find(cc => cc.id == c.id) == null) Clase.Add(c);

            Aula d = new Aula(4, "Aula 4", DateTime.Now, 0);
            if (Clase.Find(dd => dd.id == d.id) == null) Clase.Add(d);

            Aula e = new Aula(5, "Aula 5", DateTime.Now, 0);
            if (Clase.Find(ee => ee.id == e.id) == null) Clase.Add(e);

            Ordenador f = new Ordenador("1","PC 1","8 GB","500 GB","Intel i5","Intel HD Graphics","Win 7, Office 2010, Chrome",1 ,DateTime.Now);
            if (PC.Find(ff => ff.id == f.id) == null) PC.Add(f);

            Ordenador g = new Ordenador("2","PC 2","8 GB","500 GB","Intel i5","Intel HD Graphics","Win 7, Office 2010, Chrome",1 ,DateTime.Now);
            if (PC.Find(gg => gg.id == g.id) == null) PC.Add(g);

            Ordenador h = new Ordenador("3","PC 3","8 GB","500 GB","Intel i5","Intel HD Graphics","Win 7, Office 2010, Chrome",1 ,DateTime.Now);
            if (PC.Find(hh => hh.id == h.id) == null) PC.Add(h);

            Ordenador i = new Ordenador("4", "PC 4", "8 GB", "500 GB", "Intel i5", "Intel HD Graphics", "Win 7, Office 2010, Chrome",1 ,DateTime.Now);
            if (PC.Find(ii => ii.id == i.id) == null) PC.Add(i);

            Ordenador j = new Ordenador("5", "PC 5", "8 GB", "500 GB", "Intel i5", "Intel HD Graphics", "Win 7, Office 2010, Chrome",2 ,DateTime.Now);
            if (PC.Find(jj => jj.id == j.id) == null) PC.Add(j);

            Ordenador k = new Ordenador("6", "PC 6", "8 GB", "500 GB", "Intel i5", "Intel HD Graphics", "Win 7, Office 2010, Chrome",2 ,DateTime.Now);
            if (PC.Find(kk => kk.id == k.id) == null) PC.Add(k);

            Ordenador l = new Ordenador("7", "PC 7", "8 GB", "500 GB", "Intel i5", "Intel HD Graphics", "Win 7, Office 2010, Chrome",2 ,DateTime.Now);
            if (PC.Find(ll => ll.id == l.id) == null) PC.Add(l);

            Ordenador m = new Ordenador("8", "PC 8", "8 GB", "500 GB", "Intel i5", "Intel HD Graphics", "Win 7, Office 2010, Chrome",4 ,DateTime.Now);
            if (PC.Find(mm => mm.id == m.id) == null) PC.Add(m);

            Console.SetCursorPosition(15, 2); Console.WriteLine("Prueba Ejecutada");
            Console.SetCursorPosition(15, 4); Console.WriteLine("Presione una tecla para salir");
            Console.SetCursorPosition(15, 5); Console.ReadKey();
        }
        #endregion Configuracion
        #region Otras Funciones
        /// <summary>
        /// Funcion que muestra la informacion contenida en los obejtos Aula
        /// </summary>
        /// <param name="Clase">Le pasamos la lista/parametro que, queremos mostrar</param>
        static void VerDatosAula(Aula Clase)
        { 
          Console.Write("{0}\t\t{1}\t\t{2}\t\t\t{3}", Clase.id, Clase.nombre, Clase.ubicacion, Clase.fecha);
        }
        static void VerDatosAula2(Aula item)
        {
            Console.Write("{0}\t\t{1}\t\t{2}", item.id, item.nombre, item.ubicacion);
        }
        /// <summary>
        /// Funcion que muestra la informacion contenida en los obejtos Ordenadores
        /// </summary>
        /// <param name="PC">Le pasamos la lista/parametro que, queremos mostrar</param>
        static void VerDatosOrdenador(Ordenador PC)
        {
            Console.Write("{0}\t\t\t{1}\t\t\t{2}", PC.id, PC.ubicacion, PC.fecha);
        }
        /// <summary>
        /// Funcion que lee los datos de cada nuevo obejto aula que queremos introducir
        /// Creamos el objeto
        /// Pedimos al usuario que rellene los campos, si cumplen las condiciones requeridas, 
        /// como su NO existencia previa
        /// Y añadimos el objeto a la lista correspondiente (Clase)
        /// </summary>
        static void LeeDatosAula()
        {    
            Console.Clear();
            
                Aula a = new Aula();
            

            Console.SetCursorPosition(24, 2); Console.Write("Introduce el ID del Aula (Pulse 0 para ver lista de Aulas): ");
                Console.SetCursorPosition(24, 4); a.id = int.Parse(Console.ReadLine());

                if (a.id == 0)
                {
                    VerAulas();
                }
                else
                {
                    Aula item = Clase.Find(test => test.id == a.id);

                //Si no es nulo 'existe' y no deja seguir
                if (item != null) 
                    {
                        Console.SetCursorPosition(24, 6); Console.WriteLine("El ID ya existe, ¿Desea volver a intentarlo? (S/N)");
                        if (Console.ReadKey().Key == ConsoleKey.S) 
                        {
                            LeeDatosAula();                  
                        }
                    }
                //Si es nulo 'no existe' y continua el proceso
                else
                {
                        Console.SetCursorPosition(24, 6); Console.Write("Introduce el Nombre del Aula: ");
                        Console.SetCursorPosition(24, 8); a.nombre = Console.ReadLine();

                        Clase.Add(a);           
                        Console.SetCursorPosition(24, 10); Console.WriteLine("El Aula fue Añadida Correctamente");
                    }
                }                                     
        }
        /// <summary>
        /// Funcion que lee los datos de cada nuevo obejto ordenador que queremos introducir
        /// Creamos el objeto
        /// Pedimos al usuario que rellene los campos, si cumplen las condiciones requeridas, 
        /// como su NO existencia previa
        /// Y añadimos el objeto a la lista correspondiente (PC)
        /// </summary>
        static void LeeDatosOrdenador()
        {

            Console.Clear();
            Ordenador o = new Ordenador(); 

            Console.SetCursorPosition(24, 2); Console.Write("Introduce el ID del Ordenador (Pulse 0 para ver lista de Ordenadores): ");
            Console.SetCursorPosition(24, 4); o.id = Console.ReadLine();

            if (o.id == "0")
            {
                VerOrdenadores();
            }
            else {
                Ordenador itemO = PC.Find(testO => testO.id == o.id);

                //Si no es nulo 'existe' y no deja seguir
                if (itemO != null) 
                {
                    Console.SetCursorPosition(24, 6); Console.WriteLine("El ID ya existe, ¿Desea volver a intentarlo? (S/N)");
                    if (Console.ReadKey().Key == ConsoleKey.S) 
                    {
                        LeeDatosOrdenador(); 
                    }
                }
                //Si es nulo 'no existe' y continua el proceso
                else
                {
                    Console.SetCursorPosition(24, 6); Console.Write("Introduzca las caracteristicas del {0}: ", o.id);

                    Console.SetCursorPosition(24, 8); Console.Write("Introduce el ID del Ordenador: ");
                    Console.SetCursorPosition(24, 9); o.id = Console.ReadLine();
                    Console.SetCursorPosition(24, 10); Console.Write("Introduce el Nombre del Ordenador: ");
                    Console.SetCursorPosition(24, 11); o.nombre = Console.ReadLine();
                    Console.SetCursorPosition(24, 12); Console.Write("RAM: ");
                    Console.SetCursorPosition(24, 13); o.ram = Console.ReadLine();
                    Console.SetCursorPosition(24, 14); Console.Write("Disco Duro: ");
                    Console.SetCursorPosition(24, 15); o.discoduro = Console.ReadLine();
                    Console.SetCursorPosition(24, 16); Console.Write("Procesador: ");
                    Console.SetCursorPosition(24, 17); o.procesador = Console.ReadLine();
                    Console.SetCursorPosition(24, 18); Console.Write("Tarjeta Grafica: ");
                    Console.SetCursorPosition(24, 19); o.tarjetagrafica = Console.ReadLine();
                    Console.SetCursorPosition(24, 20); Console.Write("Aplicaciones: ");
                    Console.SetCursorPosition(24, 21); o.aplicaciones = Console.ReadLine();
                    Console.SetCursorPosition(24, 22); Console.Write("Introduce la Clase donde estara: ");
                    Console.SetCursorPosition(24, 23); o.ubicacion = Console.Read();

                    PC.Add(o);

                    Console.SetCursorPosition(24, 10); Console.WriteLine("El Ordenador fue Creado Correctamente");
                }
            }                 
        }
        #endregion
    }
}
