using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Practica_1º_Evaluacion /*Alumno: Manuel Jesus Hierro Pinto - 1º DAW*/
{
    class Program
    {        
        static Random dado = new Random(); //Semilla del dado random        
        static void Main(string[] args)
        {
            Console.SetWindowSize(130,36); //Tamaño de la ventana de consola            
            MenuPrincipal();
        }
        #region Menu Principal
        static void MenuPrincipal()                 
        {
            const char opcion_salir = '0'; //Constante (Utilizada mas tarde para finalizar el programa)
            char opcion;                   // Variable donde se guarda la opcion elegida para el switch
            do                                          
            {
                MuestraMenuPrincipal();                 //Invocamos a la funcion del Menu Principal
                opcion = Console.ReadKey().KeyChar;     //Leemos del teclado la opcion elegida
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
            } while (opcion != opcion_salir);          //Hacer - Mientras no pulsen la opcion_salir que es '0' 
        }              //Control de las Opciones del Menu Principal
        static void MuestraMenuPrincipal()              
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 2); Console.Write("=== Menu Principal ===");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1 - Entrenador de operaciones aritmeticas");
            Console.SetCursorPosition(15, 5); Console.Write("2 - Numeros aleatorios");
            Console.SetCursorPosition(15, 6); Console.Write("3 - Calendario");
            Console.SetCursorPosition(15, 7); Console.Write("4 - Recursividad");
            Console.ResetColor();
            Console.SetCursorPosition(15, 8);  Console.Write("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 9); Console.Write("0 - Salir del programa");
            Console.ResetColor();
            Console.SetCursorPosition(15, 11); Console.Write("Introduzca una opción: ");
        }
        #endregion
        #region Entrenador de Operaciones
        static void Opcion1()                          
        {
            const char opcionE_salir = '0'; //Constante (Utilizada mas tarde para finalizar el programa)
            char opcion;                    // Variable donde se guarda la opcion elegida para el switch
            do                                       
            {
                MuestraMenuEntrenador();            //Invocamos a la funcion del Menu Entrenador de Operaciones Aritmeticas
                opcion = Console.ReadKey().KeyChar; //Leemos del teclado la opcion elegida
                switch (opcion)
                {
                    case '1':
                        Opcion1Entrenador();
                        break;
                    case '2':
                        Opcion2Entrenador();
                        break;
                    case '3':
                        Opcion3Entrenador();
                        break;
                    case '4':
                        Opcion4Entrenador();
                        break;
                    case '5':
                        Opcion5Entrenador();
                        break;
                    case '6':
                        Opcion6Entrenador();
                        break;
                }
            } while (opcion != opcionE_salir); //Hacer - Mientras no pulsen la opcion_salir que es '0'
        }           //Control de las opciones del Entrenador de Operaciones Aritmeticas
        static void MuestraMenuEntrenador()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(15, 2);  Console.Write("=== Entrenador de operaciones aritmeticas ===");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4);  Console.Write("1 - Suma");
            Console.SetCursorPosition(15, 5);  Console.Write("2 - Resta"); 
            Console.SetCursorPosition(15, 6);  Console.Write("3 - Multiplicacion");
            Console.SetCursorPosition(15, 7);  Console.Write("4 - Division");        
            Console.SetCursorPosition(15, 8);  Console.Write("5 - Raiz n-esima");
            Console.SetCursorPosition(15, 9);  Console.Write("6 - Valor numerico de un polinomio");
            Console.ResetColor();
            Console.SetCursorPosition(15, 10); Console.Write("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 11); Console.Write("0 - Volver al Menu anterior");
            Console.ResetColor();
            Console.SetCursorPosition(15, 13); Console.Write("Introduzca una opción: ");
        }                     
        static void Opcion1Entrenador()
        {
            const char Seguir = 'S', seguir = 's'; //Guardamos el caracter 'S' y 's' como una variable constante
            char OpcionFinal;
            do
            {
                Console.Clear();
                float n1, n2, n3, Resultado;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(22, 2); Console.Write("=== Suma ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un numero para sumarlo");
                Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (float.TryParse(n1Temporal, out Resultado)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = float.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce un 2º numero para sumarlo");
                        Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine();
                        if (float.TryParse(n2Temporal, out Resultado)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = float.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                            {
                                n3 = n1 + n2;
                                Console.SetCursorPosition(12, 10); Console.WriteLine("El resultado de la suma es: {0}", n3);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea seguir mostrando sumas (S/N)?");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }
                OpcionFinal = Console.ReadKey().KeyChar;
            } while (OpcionFinal == Seguir || OpcionFinal == seguir); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle 
        }        
        static void Opcion2Entrenador()
        {
            const char Seguir = 'S', seguir = 's'; //Guardamos el caracter 'S' y 's' como una variable constante
            char OpcionFinal;
            do
            {
                Console.Clear();
                float n1, n2, n3, Sacarlo;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(22, 2); Console.Write("=== Resta ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un numero para restarlo");
                Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (float.TryParse(n1Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = float.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce un 2º numero para restarlo");
                        Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                        if (float.TryParse(n2Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = float.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                            {
                                n3 = n1 - n2;
                                Console.SetCursorPosition(12, 10); Console.WriteLine("El resultado de la resta es: {0}", n3);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea seguir mostrando restas (S/N)?");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }
                OpcionFinal = Console.ReadKey().KeyChar; //Lee el caracter introducido
            } while (OpcionFinal == Seguir || OpcionFinal == seguir); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle 
        }        
        static void Opcion3Entrenador()
        {
            const char Seguir = 'S', seguir = 's'; //Guardamos el caracter 'S' y 's' como una variable constante
            char OpcionFinal;
            do
            {
                Console.Clear();
                float n1, n2, n3, Sacarlo;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(22, 2); Console.Write("=== Multiplicacion ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un numero para Multiplicarlo");
                Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (float.TryParse(n1Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = float.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce un 2º numero para Multiplicarlo");
                        Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                        if (float.TryParse(n2Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = float.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                            {
                                n3 = n1 * n2;
                                Console.SetCursorPosition(12, 10); Console.WriteLine("El resultado de la Multiplicacion es: {0}", n3);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea seguir mostrando Multiplicaciones (S/N)?");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }
                OpcionFinal = Console.ReadKey().KeyChar;
            } while (OpcionFinal == Seguir || OpcionFinal == seguir); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle 
        }        
        static void Opcion4Entrenador()
        {
            const char Seguir = 'S', seguir = 's'; //Guardamos el caracter 'S' y 's' como una variable constante
            char OpcionFinal;
            do
            {
                Console.Clear();
                float n1, n2, n3, Sacarlo;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(21, 2); Console.Write("=== Division ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un numero para Dividirlo");
                Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (float.TryParse(n1Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = float.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce un 2º numero para Dividirlo");
                        Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                        if (float.TryParse(n2Temporal, out Sacarlo)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = float.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                            if (n2 != 0)
                            {
                                n3 = n1 / n2;
                                Console.SetCursorPosition(12, 10); Console.WriteLine("El resultado de la Division es: {0}", n3);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea seguir mostrando Divisiones (S/N)?");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.SetCursorPosition(12, 10); Console.WriteLine("¡Division por cero! Imposible de realizar");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }
                OpcionFinal = Console.ReadKey().KeyChar;
            } while (OpcionFinal == Seguir || OpcionFinal == seguir); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle 
        }       
        static void Opcion5Entrenador()
        {
            const char Seguir = 'S', seguir = 's'; //Guardamos el caracter 'S' y 's' como una variable constante
            char OpcionFinal;
            do
            {
                Console.Clear();
                double n1, n3, Resultado;
                int n2, Resultado2;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(22, 2); Console.Write("=== Raiz n-esima ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un numero para calcular su Raiz");
                Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (double.TryParse(n1Temporal, out Resultado)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = double.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce el exponente de la Raiz ");
                        Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                        if (int.TryParse(n2Temporal, out Resultado2)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = int.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable
                            {
                                n3 = Math.Pow(n1, (double)1 / n2);
                                Console.SetCursorPosition(12, 10); Console.WriteLine("El resultado de la Raiz es: {0}", n3);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea seguir Operando (S/N)?");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }
                OpcionFinal = Console.ReadKey().KeyChar;
            } while (OpcionFinal == Seguir || OpcionFinal == seguir); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle 
        }        
        static void Opcion6Entrenador()
        {
            string Seguir; 
            double A, B, C, x, r, Sacarlo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(17, 2); Console.Write("=== Leemos el polinomio ===");
                    Console.ResetColor();
                    Console.SetCursorPosition(12, 4); Console.WriteLine("Introduce un el 1º valor del Polinomio");
                    Console.SetCursorPosition(12, 5); string n1Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                    double.TryParse(n1Temporal, out Sacarlo); //Intenta convertir el valor en un tipo determinado
                    A = double.Parse(n1Temporal); //Convierte el valor introducido y lo guarda en una nueva variable

                    Console.SetCursorPosition(12, 7); Console.WriteLine("Introduce un el 2º valor del Polinomio");
                    Console.SetCursorPosition(12, 8); string n2Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                    double.TryParse(n2Temporal, out Sacarlo); //Intenta convertir el valor en un tipo determinado
                    B = double.Parse(n2Temporal); //Convierte el valor introducido y lo guarda en una nueva variable

                    Console.SetCursorPosition(12, 10); Console.WriteLine("Introduce un el 3º valor del Polinomio");
                    Console.SetCursorPosition(12, 11); string n3Temporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                    double.TryParse(n3Temporal, out Sacarlo); //Intenta convertir el valor en un tipo determinado
                    C = double.Parse(n3Temporal); //Convierte el valor introducido y lo guarda en una nueva variable

                    Console.SetCursorPosition(12, 13); Console.WriteLine("Se ha leido el polinomio:  {0}x^2 + {1}x + {2}", A, B, C);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 15); Console.WriteLine("¿Es correcto (S/N)?");
                    Console.ResetColor();
                    Console.SetCursorPosition(12, 17); Seguir = Console.ReadLine();
                } while (Seguir.ToUpper() == "N"); //Mientras la variable 'seguir' sea igual a 'N' o 'n' continuar en el bucle  

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(22, 2); Console.Write("=== Valor numerico del Polinomio ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.WriteLine("Polinomio: {0}x^2 + {1}x + {2}", A, B, C);
                Console.SetCursorPosition(12, 6); Console.WriteLine("Introduce un valor de x");
                Console.SetCursorPosition(12, 7); string xTemporal = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                double.TryParse(xTemporal, out Sacarlo); //Intenta convertir el valor en un tipo determinado
                x = double.Parse(xTemporal); //Convierte el valor introducido y lo guarda en una nueva variable
                Console.SetCursorPosition(12, 9); Console.WriteLine("El valor de x es: {0}", x);

                r = (A * Math.Pow(x, 2)) + (B * x) + (C);   //Formula de la ecuacion de 2º (Matth.Pow(numero base, numero al que es elevado))
                Console.SetCursorPosition(12, 11); Console.WriteLine("El valor del Polinomio es: {0}", r);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 13); Console.WriteLine("¿Desea continuar calculando polinomios (S/N)?");
                Console.ResetColor();
                Console.SetCursorPosition(12, 14); Seguir = Console.ReadLine();        //Lee por teclado y guarda el valor en la variable seguir
            } while (Seguir.ToUpper() == "S"); //Hacer - Mientras la variable 'seguir' sea igual a 'S' o 's' continuar en el bucle             
        }
        #endregion
        #region Numeros Aleatorios
        static void Opcion2()                           
        {
            const char opcionNA_salir = '0'; //Constante (Utilizada mas tarde para finalizar el programa)
            char opcion;                     // Variable donde se guarda la opcion elegida para el switch
            do                                       
            {
                MuestraMenuNumerosAleatorios();     //Invocamos a la funcion del Menu de Numeros Aleatorios
                opcion = Console.ReadKey().KeyChar; //Leemos del teclado la opcion elegida
                switch (opcion)
                {
                    case '1':
                        Opcion1NumAleatorios();
                        break;
                    case '2':
                        Opcion2NumAleatorios();
                        break;
                    case '3':
                        Opcion3NumAleatorios();
                        break;
                }
            } while (opcion != opcionNA_salir); //Hacer - Mientras no pulsen la opcion_salir que es '0'
        }          //Control de las opciones de los Numeros Aleatorios        
        static void MuestraMenuNumerosAleatorios()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(19, 2); Console.Write("=== Numeros Aleatorios ===");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1 - Juego de dados: Boston");
            Console.SetCursorPosition(15, 5); Console.Write("2 - Juego de dados: Probabilidades");
            Console.SetCursorPosition(15, 6); Console.Write("3 - Juego de dados: Grafica");
            Console.ResetColor();
            Console.SetCursorPosition(15, 7); Console.Write("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 8); Console.Write("0 - Volver al Menu anterior");
            Console.ResetColor();
            Console.SetCursorPosition(15, 10); Console.Write("Introduzca una opción: ");
        }              
        static void Opcion1NumAleatorios()
        {
            DateTime tiempo1 = DateTime.Now;
            int Puntos = 0, mayor = 0, Rondas = 0, D1, D2, D3;

            do
            {                
                Console.Clear();
                DateTime tiempo2 = DateTime.Now; //Guarda la hora en este instante
                TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks); //Guarda en una variable la resta de 2 instantes de tiempo
                Rondas++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(28, 2); Console.Write("=== Juego Boston ===");
                Console.ResetColor();
                Console.SetCursorPosition(8, 3);  Console.Write("===============================================================");
                Console.SetCursorPosition(12, 4); Console.Write("Hora de Inicio: "+DateTime.Now.ToString("h'h 'm'm 's's'") + "     Tiempo Jugado: " + (total.ToString("h'h 'm'm 's's'"))); //Muestra la fecha de inicio y el tiempo jugado               
                Console.SetCursorPosition(12, 5); Console.WriteLine("Jugada Nº {0}                    Puntos Acumulados: {1}", Rondas, Puntos);
                Console.SetCursorPosition(8, 6);  Console.Write("===============================================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 8); Console.WriteLine("Pulse intro para tirar los dados (F = Finaliza)");
                Console.ResetColor();

                if (Console.ReadKey().Key == ConsoleKey.Enter && Console.ReadKey().Key != ConsoleKey.F && Puntos <= 100)
                {
                    int PuntosObtenidos = 0; //Para resetear los puntos a cero
                    D1 = dado.Next(1, 7);
                    Console.SetCursorPosition(12, 10); Console.WriteLine("Dado 1: {0}", D1);
                    D2 = dado.Next(1, 7);
                    Console.SetCursorPosition(12, 11); Console.WriteLine("Dado 2: {0}", D2);
                    D3 = dado.Next(1, 7);
                    Console.SetCursorPosition(12, 12); Console.WriteLine("Dado 3: {0}", D3);
                    if (D1 >= D2 && D1 > D3)
                        mayor = D1; //Indica que el dado 1 es el mayor
                    if (D2 > D1 && D2 >= D3)
                        mayor = D2; //Indica que el dado 2 es el mayor
                    if (D3 > D2 && D3 >= D1)
                        mayor = D3; //Inidica que el dado 3 es el mayor

                    PuntosObtenidos = PuntosObtenidos + mayor; //Suma de los puntos de la ronda

                    if ((D1 == D2) && (D1 == D3) && (D1 != 1) | (D2 != 1) | (D3 != 1))
                    {
                        PuntosObtenidos = 0;
                        PuntosObtenidos = PuntosObtenidos + 30; //Suma +30 si se cumplen las condiciones
                    }
                    if ((D1 == D2) && (D1 == D3) && (D1 == 1) && (D2 == 1) && (D3 == 1))
                    {
                        PuntosObtenidos = 0;
                        PuntosObtenidos = PuntosObtenidos - 30; //Resta -30 si se cumplen las condiciones
                    }
                    Console.SetCursorPosition(12, 14); Console.WriteLine("Puntos obtenidos: {0}", PuntosObtenidos);
                    Puntos = Puntos + PuntosObtenidos; //Suma los puntos totales  
                    if (Puntos >= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(12, 18); Console.WriteLine("Puntuacion maxima alcanzada, el juego ha finalizado");
                        Console.ResetColor();
                    }
                } else { break; }

                if (Console.ReadKey().Key == ConsoleKey.Enter && Console.ReadKey().Key != ConsoleKey.F && Puntos <= 100)
                {
                    Console.Clear();
                    tiempo2 = DateTime.Now; //Guarda la hora en este instante
                    total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks); //Guarda en una variable la resta de 2 instantes de tiempo
                    Rondas++;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(28, 2); Console.Write("=== Juego Boston ===");
                    Console.ResetColor();
                    Console.SetCursorPosition(8, 3); Console.Write("===============================================================");
                    Console.SetCursorPosition(12, 4); Console.Write("Hora de Inicio: " + DateTime.Now.ToString("h'h 'm'm 's's'") + "     Tiempo Jugado: " + (total.ToString("h'h 'm'm 's's'"))); //Muestra la fecha de inicio y el tiempo jugado  
                    Console.SetCursorPosition(12, 5); Console.WriteLine("Jugada Nº {0}                    Puntos Acumulados: {1}", Rondas, Puntos);
                    Console.SetCursorPosition(8, 6); Console.Write("===============================================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 8); Console.WriteLine("Pulse intro para tirar los dados (F = Finaliza)");
                    Console.ResetColor();

                    int PuntosObtenidos2 = 0; //Para resetear a '0' los puntos
                    D1 = dado.Next(1, 7);
                    Console.SetCursorPosition(12, 10); Console.WriteLine("Dado 1: {0}", D1);
                    D2 = dado.Next(1, 7);
                    Console.SetCursorPosition(12, 11); Console.WriteLine("Dado 2: {0}", D2);
                    if (D1 >= D2)
                        mayor = D1; //Indica que el dado 1 es el mayor
                    if (D2 > D1)
                        mayor = D2; //Indica que el dado 2 es el mayor

                    PuntosObtenidos2 = PuntosObtenidos2 + mayor; //Suma los puntos de la ronda

                    if ((D1 == D2) && (D1 != 1))
                    {
                        PuntosObtenidos2 = 0;
                        PuntosObtenidos2 = PuntosObtenidos2 + 15; //Suma +15 si se cumplen las condiciones
                    }
                    if ((D1 == D2) && (D1 == 1))
                    {
                        PuntosObtenidos2 = 0;
                        PuntosObtenidos2 = PuntosObtenidos2 - 20; //Resta -20 si se cumplen las condiciones
                    }
                    Console.SetCursorPosition(12, 14); Console.WriteLine("Puntos obtenidos: {0}", PuntosObtenidos2);
                    Puntos = Puntos + PuntosObtenidos2; //Suma los puntos totales 
                    if (Puntos >= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(12, 18); Console.WriteLine("Puntuacion maxima alcanzada, el juego ha finalizado");
                        Console.ResetColor();
                    }
                } else { break; }

                        if (Console.ReadKey().Key == ConsoleKey.Enter && Console.ReadKey().Key != ConsoleKey.F && Puntos <= 100)
                        {
                            Console.Clear();
                            tiempo2 = DateTime.Now; //Guarda la hora en este instante
                            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks); //Guarda en una variable la resta de 2 instantes de tiempo
                            Rondas++;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(28, 2); Console.Write("=== Juego Boston ===");
                            Console.ResetColor();
                            Console.SetCursorPosition(8, 3); Console.Write("===============================================================");
                    Console.SetCursorPosition(12, 4); Console.Write("Hora de Inicio: " + DateTime.Now.ToString("h'h 'm'm 's's'") + "     Tiempo Jugado: " + (total.ToString("h'h 'm'm 's's'"))); //Muestra la fecha de inicio y el tiempo jugado  
                    Console.SetCursorPosition(12, 5); Console.WriteLine("Jugada Nº {0}                    Puntos Acumulados: {1}", Rondas, Puntos);
                            Console.SetCursorPosition(8, 6); Console.Write("===============================================================");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 8); Console.WriteLine("Pulse intro para tirar los dados (F = Finaliza)");
                            Console.ResetColor();

                            int PuntosObtenidos3 = 0; //Para resetear a '0' los puntos
                            D1 = dado.Next(1, 7);
                            Console.SetCursorPosition(12, 10); Console.WriteLine("Dado 1: {0}", D1);
                            mayor = D1;

                            PuntosObtenidos3 = PuntosObtenidos3 + mayor; //Suma los puntos de la ronda

                    if (D1 == 1)
                    {
                        PuntosObtenidos3 = 0;
                        PuntosObtenidos3 = PuntosObtenidos3 - 10; //Resta -10 si el dado es 1
                    }                            
                            Console.SetCursorPosition(12, 14); Console.WriteLine("Puntos obtenidos: {0}", PuntosObtenidos3);
                            Puntos = Puntos + PuntosObtenidos3; //Suma los puntos totales                             
                            if (Puntos >= 100)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(12, 18); Console.WriteLine("Puntuacion maxima alcanzada, el juego ha finalizado");
                                Console.ResetColor();
                            }
                        } else { break; }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 16); Console.WriteLine("Pulse intro para continuar (F = Finaliza)");
                Console.ResetColor();
                if (Console.ReadKey().Key == ConsoleKey.F) { break; }  
            } while (Puntos <= 100); //Si los puntos totales son 100 o mas finaliza el juego            
        }
        static void Opcion2NumAleatorios()
        {       
            do
            {
                int nElem = 10000000, i;
                int[] Almacen = new int[nElem]; //Declaramos el array y su numero de elementos '10 millones'
                double cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(28, 2); Console.Write("=== El dado 'Bueno' ===");
                Console.ResetColor();
                Console.SetCursorPosition(8, 3); Console.Write("===============================================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 5); Console.Write("Pulse Intro para generar 10.000.000 tiradas de un dado");
                Console.ResetColor();

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(28, 2); Console.Write("=== El dado 'Bueno' ===");
                    Console.ResetColor();
                    Console.SetCursorPosition(8, 3); Console.Write("===============================================================");

                    for (i = 0; i < Almacen.Length; i++) //Iniciamos el contador 'i' en 0, recorremos el array hasta su final y sumamos 1
                    {
                        Almacen[i] = dado.Next(1, 7); //En cada rotacion tiramos un dado y lo guardamos en una posicion                        
                    }
                    for (i = 0; i < Almacen.Length; i++) //Iniciamos el contador 'i' en 0, recorremos el array hasta su final y sumamos 1
                    {
                        if (Almacen[i] == 1) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont1'
                            cont1++;
                        if (Almacen[i] == 2) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont2'
                            cont2++;
                        if (Almacen[i] == 3) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont3'
                            cont3++;
                        if (Almacen[i] == 4) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont4'
                            cont4++;
                        if (Almacen[i] == 5) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont5'
                            cont5++;
                        if (Almacen[i] == 6) //Para todos los valores 1 que existan dentro del array sumamos 1 al contador 'cont6'
                            cont6++;
                    }
                    Console.SetCursorPosition(12, 5); Console.Write("Promedio de cada cara: ");
                    Console.SetCursorPosition(12, 7); Console.Write("1: " + cont1 / nElem);  //Mostramos el resultado del promedio
                    Console.SetCursorPosition(12, 8); Console.Write("2: " + cont2 / nElem); //Mostramos el resultado del promedio
                    Console.SetCursorPosition(12, 9); Console.Write("3: " + cont3 / nElem); //Mostramos el resultado del promedio
                    Console.SetCursorPosition(12, 10); Console.Write("4: " + cont4 / nElem); //Mostramos el resultado del promedio
                    Console.SetCursorPosition(12, 11); Console.Write("5: " + cont5 / nElem); //Mostramos el resultado del promedio
                    Console.SetCursorPosition(12, 12); Console.Write("6: " + cont6 / nElem); //Mostramos el resultado del promedio
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 14); Console.Write("¿Analizar otro dado (S/N)?");
                    Console.ResetColor();
                }                
                else if (Console.ReadKey().Key == ConsoleKey.N) break; //Si pulsamos 'N' salimos del bucle               
            } while (Console.ReadKey().Key == ConsoleKey.S); // En medio de la ejecucion presionamos la tecla N para finalizar
        }       
        static void Opcion3NumAleatorios()
        {
            do
            { 
            int nElem = 100, i = 0, Puntos = 0, Lanza1 = 0, Lanza2 = 0;
            int num2=0, num3=0, num4=0, num5=0,num6=0, num7=0, num8=0, num9=0, num10=0, num11=0, num12=0;
                          
                Console.Clear();
                Console.SetCursorPosition(26, 2); Console.Write("=== Grafica 'dos dados' ===");
                Console.SetCursorPosition(8, 3); Console.Write("===============================================================");
                         
                for (i = 0; i <= nElem; i++) //Iniciamos en '0', si i es menor que la variable, suma 1
                {
                    Lanza1 = dado.Next(1, 7); //Tira dado 1
                    Lanza2 = dado.Next(1, 7); //Tira dado 2
                    Puntos = Lanza1 + Lanza2; //Suma los valores

                    if (Puntos == 2) //Si la suma vale 2, añade 1 al contador
                        num2++;
                    else if (Puntos == 3) //Si la suma vale 3, añade 1 al contador
                        num3++;
                    else if (Puntos == 4) //Si la suma vale 4, añade 1 al contador
                        num4++;
                    else if (Puntos == 5) //Si la suma vale 5, añade 1 al contador
                        num5++;
                    else if (Puntos == 6) //Si la suma vale 6, añade 1 al contador
                        num6++;
                    else if (Puntos == 7) //Si la suma vale 7, añade 1 al contador
                        num7++;
                    else if (Puntos == 8) //Si la suma vale 8, añade 1 al contador
                        num8++;
                    else if (Puntos == 9) //Si la suma vale 9, añade 1 al contador
                        num9++;
                    else if (Puntos == 10) //Si la suma vale 10, añade 1 al contador
                        num10++;
                    else if (Puntos == 11) //Si la suma vale 11, añade 1 al contador
                        num11++;
                    else
                        num12++; //si no es nigun otro es 12 y suma 1
                }
                Console.Clear();                                             
                Console.SetCursorPosition(5, 2); Console.Write("├");
                Console.SetCursorPosition(5, 3); Console.Write("├"); 
                Console.SetCursorPosition(5, 4); Console.Write("├"); 
                Console.SetCursorPosition(5, 5); Console.Write("├"); 
                Console.SetCursorPosition(5, 6); Console.Write("├"); 
                Console.SetCursorPosition(5, 7); Console.Write("├"); 
                Console.SetCursorPosition(5, 8); Console.Write("├"); 
                Console.SetCursorPosition(5, 9); Console.Write("├"); 
                Console.SetCursorPosition(5, 10); Console.Write("├"); 
                Console.SetCursorPosition(5, 11); Console.Write("├");
                Console.SetCursorPosition(5, 12); Console.Write("├"); 
                Console.SetCursorPosition(5, 13); Console.Write("├"); 
                Console.SetCursorPosition(5, 14); Console.Write("├");
                Console.SetCursorPosition(5, 15); Console.Write("├"); 
                Console.SetCursorPosition(5, 16); Console.Write("├"); 
                Console.SetCursorPosition(5, 17); Console.Write("├"); 
                Console.SetCursorPosition(5, 18); Console.Write("├"); 
                Console.SetCursorPosition(5, 19); Console.Write("├"); 
                Console.SetCursorPosition(5, 20); Console.Write("├"); 
                Console.SetCursorPosition(5, 21); Console.Write("├"); 
                Console.SetCursorPosition(5, 22); Console.Write("├"); 
                Console.SetCursorPosition(5, 23); Console.Write("├");
                Console.SetCursorPosition(5, 24); Console.Write("├");
                Console.SetCursorPosition(5, 25); Console.Write("├");
                Console.SetCursorPosition(5, 26); Console.Write("├");
                Console.SetCursorPosition(5, 27); Console.Write("├");
                Console.SetCursorPosition(5, 28); Console.Write("├");
                Console.SetCursorPosition(5, 29); Console.Write("├");
                Console.SetCursorPosition(5, 30); Console.Write("├");
                Console.SetCursorPosition(5, 31); Console.Write("├");  
                Console.SetCursorPosition(5, 32); Console.Write("└");

                Console.SetCursorPosition(6, 32); Console.Write("────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┘");
                
                Console.SetCursorPosition(10, 33); Console.Write("2");
                Console.SetCursorPosition(16, 33); Console.Write("3");
                Console.SetCursorPosition(22, 33); Console.Write("4");
                Console.SetCursorPosition(28, 33); Console.Write("5");
                Console.SetCursorPosition(34, 33); Console.Write("6");
                Console.SetCursorPosition(40, 33); Console.Write("7");
                Console.SetCursorPosition(46, 33); Console.Write("8");
                Console.SetCursorPosition(52, 33); Console.Write("9");
                Console.SetCursorPosition(58, 33); Console.Write("10");
                Console.SetCursorPosition(64, 33); Console.Write("11");
                Console.SetCursorPosition(70, 33); Console.Write("12");

                Console.SetCursorPosition(1, 2); Console.Write("30");
                Console.SetCursorPosition(1, 3); Console.Write("29");
                Console.SetCursorPosition(1, 4); Console.Write("28");
                Console.SetCursorPosition(1, 5); Console.Write("27");
                Console.SetCursorPosition(1, 6); Console.Write("26");
                Console.SetCursorPosition(1, 7); Console.Write("25");
                Console.SetCursorPosition(1, 8); Console.Write("24");
                Console.SetCursorPosition(1, 9); Console.Write("23");
                Console.SetCursorPosition(1, 10); Console.Write("22");
                Console.SetCursorPosition(1, 11); Console.Write("21");
                Console.SetCursorPosition(1, 12); Console.Write("20");
                Console.SetCursorPosition(1, 13); Console.Write("19");
                Console.SetCursorPosition(1, 14); Console.Write("18");
                Console.SetCursorPosition(1, 15); Console.Write("17");
                Console.SetCursorPosition(1, 16); Console.Write("16");
                Console.SetCursorPosition(1, 17); Console.Write("15");
                Console.SetCursorPosition(1, 18); Console.Write("14");
                Console.SetCursorPosition(1, 19); Console.Write("13");
                Console.SetCursorPosition(1, 20); Console.Write("12");
                Console.SetCursorPosition(1, 21); Console.Write("11");
                Console.SetCursorPosition(1, 22); Console.Write("10");
                Console.SetCursorPosition(1, 23); Console.Write("9");
                Console.SetCursorPosition(1, 24); Console.Write("8");
                Console.SetCursorPosition(1, 25); Console.Write("7");
                Console.SetCursorPosition(1, 26); Console.Write("6");
                Console.SetCursorPosition(1, 27); Console.Write("5");
                Console.SetCursorPosition(1, 28); Console.Write("4");
                Console.SetCursorPosition(1, 29); Console.Write("3");
                Console.SetCursorPosition(1, 30); Console.Write("2");
                Console.SetCursorPosition(1, 31); Console.Write("1");
                Console.SetCursorPosition(1, 32); Console.Write("0");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(10, Math.Abs(32 - num2)); Console.WriteLine("X");
                Console.SetCursorPosition(16, Math.Abs(32 - num3)); Console.WriteLine("X");
                Console.SetCursorPosition(22, Math.Abs(32 - num4)); Console.WriteLine("X");
                Console.SetCursorPosition(28, Math.Abs(32 - num5)); Console.WriteLine("X");
                Console.SetCursorPosition(34, Math.Abs(32 - num6)); Console.WriteLine("X");
                Console.SetCursorPosition(40, Math.Abs(32 - num7)); Console.WriteLine("X");
                Console.SetCursorPosition(46, Math.Abs(32 - num8)); Console.WriteLine("X");
                Console.SetCursorPosition(52, Math.Abs(32 - num9)); Console.WriteLine("X");
                Console.SetCursorPosition(58, Math.Abs(32 - num10)); Console.WriteLine("X");
                Console.SetCursorPosition(64, Math.Abs(32 - num11)); Console.WriteLine("X");
                Console.SetCursorPosition(70, Math.Abs(32 - num12)); Console.WriteLine("X");                
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(30, 1); Console.WriteLine("¿Quieres generar una nueva grafica (S/N)?");
                Console.SetCursorPosition(72, 1);
                Console.ResetColor();    
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'
        }
        #endregion
        #region Calendario
        static void Opcion3()                           
        {
            const char opcionC_salir = '0'; //Constante (Utilizada mas tarde para finalizar el programa)
            char opcion;                    // Variable donde se guarda la opcion elegida para el switch
            do                                       
            {
                MuestraMenuCalendario();            //Invocamos a la funcion del Menu Calendario
                opcion = Console.ReadKey().KeyChar; //Leemos del teclado la opcion elegida
                switch (opcion)
                {
                    case '1':
                        Opcion1Calendario();
                        break;
                    case '2':
                        Opcion2Calendario();
                        break;
                    case '3':
                        Opcion3Calendario();
                        break;
                    case '4':
                        Opcion4Calendario();
                        break;
                    case '5':
                        Opcion5Calendario();
                        break;                    
                }                
            } while (opcion != opcionC_salir); //Hacer - Mientras no pulsen la opcion_salir que es '0'
        }          //Control de las opciones del Calendario
        static void MuestraMenuCalendario()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(27, 2);  Console.Write("=== Calendario ===");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4);  Console.Write("1 - Mostrar el dia de la semana de una fecha");
            Console.SetCursorPosition(15, 5);  Console.Write("2 - Nº de dias desde el Inicio del año");
            Console.SetCursorPosition(15, 6);  Console.Write("3 - Nº de semanas desde el Inicio del año");
            Console.SetCursorPosition(15, 7);  Console.Write("4 - Mostrar el numero de dias entre dos fechas");
            Console.SetCursorPosition(15, 8);  Console.Write("5 - Mostrar fines de semana de un año");
            Console.ResetColor();
            Console.SetCursorPosition(15, 9);  Console.Write("----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 10); Console.Write("0 - Salir del programa");
            Console.ResetColor();
            Console.SetCursorPosition(15, 12); Console.Write("Introduzca una opción: ");
        }                              
        static int DiaSemana(int dia, int mes, int año) //Funcion que devuelve el dia, mes y año para saber el dia de la semana
        {
            int a, b, c, n; 
            if (mes <= 2) 
            {
                a = mes + 10;
                b = (año - 1) % 100;
                c = (año - 1) / 100;                
            }
            else
            {
                a = mes - 2;
                b = año % 100;
                c = año / 100;               
            }
            n = (700 + (26 * a - 2) / 10 + dia + b + b / 4 + c / 4 - 2 * c) % 7;
            return n; //Deduelve el valor de la variable
        }                 
        static bool esBisiesto(int año) //Funcion para saber si el año es bisiesto
        {
            bool bisiesto;
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                bisiesto = true;
            }
            else bisiesto = false;
            return bisiesto; //Devuelve el valor de la variable
        }                           
        static bool esFechaCorrecta(int dia, int mes, int año) //Funcion para comprobar la fecha es correcta
        {
            bool comprobacionFecha = false;

            if (mes <= 0 || mes > 12) { comprobacionFecha = false; } 
            else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia <= 0 || dia > 31) { comprobacionFecha = false; }
                else comprobacionFecha = true;
            }
            else if (mes == 2) //Si el mes es 2 (febrero)
            {
                if (esBisiesto(año)) //Llamamos a la funcion del año bisiesto 
                {
                    if (dia <= 0 || dia > 29) { comprobacionFecha = false; } 
                    else comprobacionFecha = true;
                }
                else
                {
                    if (dia <= 0 || dia > 28) { comprobacionFecha = false; }
                    else comprobacionFecha = true;
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia <= 0 || dia > 30) { comprobacionFecha = false; }
                else comprobacionFecha = true;
            }
            return comprobacionFecha; //Devuelve el valor booleano (True, False) de la variable
        }           
        static void Opcion1Calendario()
        {
            int dia, mes, año, Semana;
            string[] separar; //Declaramos una variable array de tipo string
            char[] separadores = new char[] { '/', ' ', ':', '.', '-', '_', ',', ';', '´', '|', '!', '^' }; //Array de caracteres
            string Fecha;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Calculo del dia de la semana de una fecha ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca una fecha (dd/mm/aaaa): ");
                Fecha = Console.ReadLine(); //Guardamos la fecha introducida
                separar = Fecha.Split(separadores);  // Una vez leido uno de los simbolos indicados en 'separadores' pasa al siguiente espacio del array
                dia = int.Parse(separar[0]); //Guardamos el dia y usamos el caracter del array en la posicion 0
                mes = int.Parse(separar[1]); //Guardamos el mes y usamos el caracter del array en la posicion 1
                año = int.Parse(separar[2]); //Guardamos el año y usamos el caracter del array en la posicion 2
                do
                {
                    if (esFechaCorrecta(dia, mes, año)) //Llamamos a la funcion para comprobar que la fecha sea correcta
                    {
                        Semana = DiaSemana(dia, mes, año); //La variable guarda el valor de la funcion llamada
                        switch (Semana)
                        {
                            case 1:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Lunes", dia, mes, año);
                                break;
                            case 2:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Martes", dia, mes, año);
                                break;
                            case 3:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Miercoles", dia, mes, año);
                                break;
                            case 4:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Jueves", dia, mes, año);
                                break;
                            case 5:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Viernes", dia, mes, año);
                                break;
                            case 6:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Sabado", dia, mes, año);
                                break;
                            case 0:
                                Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} es Domingo", dia, mes, año);
                                break;
                        }
                    }
                    else
                    { Console.SetCursorPosition(12, 6); Console.WriteLine("Has escrito una fecha incorrecta"); break; }

                } while (!esFechaCorrecta(dia, mes, año)); //Hacer - Mientras la fecha sea correcta si no, sale del bucle 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 8); Console.WriteLine("¿Deseas seguir introduciendo fechas (S/N)?");
                Console.ResetColor();
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'
        }
        static void Opcion2Calendario()
        {
            int DiasTranscurridos = 0, dia = 0, mes = 0, año = 0;
            string[] separar; //Declaramos una variable array de tipo string
            char[] separadores = new char[] { '/', ' ', ':', '.', '-', '_', ',', ';', '´', '|', '!', '^' }; //Array de caracteres
            string Fecha;
            int enero = 31, febrero = 28, marzo = 31, abril = 30, 
                mayo = 31, junio = 30, julio = 31, agosto = 31, 
                septiembre = 30, octubre = 31, noviembre = 30;
            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Nº de dias desde el Inicio del año ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca una fecha (dd/mm/aaaa): ");
                Fecha = Console.ReadLine(); //Guardamos la fecha introducida
                separar = Fecha.Split(separadores);  // Una vez leido uno de los simbolos indicados en 'separadores' pasa al siguiente espacio del array
                dia = int.Parse(separar[0]); //Guardamos el dia y usamos el caracter del array en la posicion 0
                mes = int.Parse(separar[1]); //Guardamos el mes y usamos el caracter del array en la posicion 1
                año = int.Parse(separar[2]); //Guardamos el año y usamos el caracter del array en la posicion 2
                do
                {                    
                    if (esFechaCorrecta(dia, mes, año)) //Llamamos a la funcion para comprobar que la fecha sea correcta
                    {
                        if (esBisiesto(año)) //Llamamos a la funcion para saber si es bisiesto
                        {   /*Sumamos los dias de un año si es bisiesto le sumamos +1 a febrero*/                                                    
                            if (mes == 1)
                                DiasTranscurridos = dia;
                            else if (mes == 2)
                                DiasTranscurridos = enero + dia;
                            else if (mes == 3)
                                DiasTranscurridos = enero + febrero + dia;
                            else if (mes == 4)
                                DiasTranscurridos = enero + febrero + marzo + dia;
                            else if (mes == 5)
                                DiasTranscurridos = enero + febrero + marzo + abril + dia;
                            else if (mes == 6)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + dia;
                            else if (mes == 7)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + dia;
                            else if (mes == 8)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                            else if (mes == 9)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                            else if (mes == 10)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                            else if (mes == 11)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                            else if (mes == 12)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;

                            if (mes >= 3) { DiasTranscurridos++; }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} han transcurrido {3} dias desde el comienzo del año", dia, mes, año, DiasTranscurridos);
                            Console.ResetColor();
                        }
                        else
                        {   /*Sumamos los dias de un año*/
                            if (mes == 1)
                                DiasTranscurridos = dia;
                            else if (mes == 2)
                                DiasTranscurridos = enero + dia;
                            else if (mes == 3)
                                DiasTranscurridos = enero + febrero + dia;
                            else if (mes == 4)
                                DiasTranscurridos = enero + febrero + marzo + dia;
                            else if (mes == 5)
                                DiasTranscurridos = enero + febrero + marzo + abril + dia;
                            else if (mes == 6)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + dia;
                            else if (mes == 7)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + dia;
                            else if (mes == 8)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                            else if (mes == 9)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                            else if (mes == 10)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                            else if (mes == 11)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                            else if (mes == 12)
                                DiasTranscurridos = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(12, 6); Console.WriteLine("El {0}/{1}/{2} han transcurrido {3} dias desde el comienzo del año", dia, mes, año, DiasTranscurridos);
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(12, 6); Console.WriteLine("Has escrito una fecha incorrecta");
                        Console.ResetColor();
                        break;
                    }
                } while (!esFechaCorrecta(dia, mes, año)); //Hacer - Mientras la fecha sea correcta si no, sale del bucle   
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 8); Console.WriteLine("¿Desea continuar (S/N)?");
                Console.ResetColor();
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'
        }
        static void Opcion3Calendario()
        {
            // Declaramos una variable array de tipo string
            string[] separar;
            // Array de caracteres
            char[] separadores = new char[] { '/', ' ', ':', '.', '-', '_', ',', ';', '´', '|', '!', '^' };
            string Fecha;
            
            do
            {
                Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Nº de semanas desde el Inicio del año ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca una fecha (dd/mm/aaaa): ");
                // Guardamos la fecha introducida
                Fecha = Console.ReadLine();
                // Una vez leido uno de los simbolos indicados en 'separadores' pasa al siguiente espacio del array
                separar = Fecha.Split(separadores);  
                try
                {
                    // Convierte el string en Fecha
                    DateTime inputDate = DateTime.Parse(Fecha.Trim());

                    // Formatea la fecha segun la hora del ordenador
                    var formateada = inputDate;
                    CultureInfo culture = CultureInfo.CurrentCulture;

                    // Usa la fecha formateada y calcula el número de la semana
                    int NumeroSemana = culture.Calendar.GetWeekOfYear(formateada, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(12, 6); Console.WriteLine("El {0} esta en la semana {1} ", Fecha, NumeroSemana);
                    Console.ResetColor();
                }
                catch (FormatException) // Si ocurre esta excepcion, salta el siguiente mensaje
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(12, 6); Console.WriteLine("Has escrito una fecha incorrecta");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 8); Console.WriteLine("¿Desea continuar (S/N)?");
                Console.ResetColor();
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'
        }        
        static void Opcion4Calendario()
        {
            int DiasTranscurridos1ºFecha = 0, DiasTranscurridos2ºFecha = 0, DiferenciaDeDias = 0, AñosTranscurridos = 0, dia = 0, mes = 0, año = 0, diaI = 0, mesI = 0, añoI = 0, añoT = 0, diaF = 0, mesF = 0, añoF = 0;
            string[] separar; //Declaramos una variable array de tipo string
            char[] separadores = new char[] { '/', ' ', ':', '.', '-', '_', ',', ';', '´', '|', '!', '^' }; //Array de caracteres
            string FechaInicial, FechaFinal;
            int enero = 31, febrero = 28, marzo = 31, abril = 30, mayo = 31, junio = 30, julio = 31, agosto = 31, septiembre = 30, octubre = 31, noviembre = 30;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Nº de dias entre dos fechas ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca una fecha Inicial (dd/mm/aaaa): ");
                Console.SetCursorPosition(12, 6); FechaInicial = Console.ReadLine(); //Introducimos por teclado la 1º Fecha
                separar = FechaInicial.Split(separadores);  // Una vez leido uno de los simbolos indicados en 'separadores' pasa al siguiente espacio del array
                dia = int.Parse(separar[0]); diaI = dia; //Guardamos el dia y usamos el caracter del array en la posicion 0 y lo pasamos a otra variable
                mes = int.Parse(separar[1]); mesI = mes; //Guardamos el mes y usamos el caracter del array en la posicion 1 y lo pasamos a otra variable
                año = int.Parse(separar[2]); añoI = año; añoT = año; //Guardamos el año y usamos el caracter del array en la posicion 2 y lo pasamos a 2 variables mas

                do
                {
                    if (esFechaCorrecta(dia, mes, año)) //Llamamos a la funcion para comprobar que la fecha sea correcta
                    {
                        if (esBisiesto(año)) //Llamamos a la funcion para saber si es bisiesto
                        {   /*Sumamos los dias de un año si es bisiesto le sumamos +1 a febrero*/
                            febrero++;
                            if (mes == 1)
                                DiasTranscurridos1ºFecha = dia;
                            else if (mes == 2)
                                DiasTranscurridos1ºFecha = enero + dia;
                            else if (mes == 3)
                                DiasTranscurridos1ºFecha = enero + febrero + dia;
                            else if (mes == 4)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + dia;
                            else if (mes == 5)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + dia;
                            else if (mes == 6)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + dia;
                            else if (mes == 7)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + dia;
                            else if (mes == 8)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                            else if (mes == 9)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                            else if (mes == 10)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                            else if (mes == 11)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                            else if (mes == 12)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;
                        }
                        else
                        {   /*Sumamos los dias de un año*/
                            if (mes == 1)
                                DiasTranscurridos1ºFecha = dia;
                            else if (mes == 2)
                                DiasTranscurridos1ºFecha = enero + dia;
                            else if (mes == 3)
                                DiasTranscurridos1ºFecha = enero + febrero + dia;
                            else if (mes == 4)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + dia;
                            else if (mes == 5)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + dia;
                            else if (mes == 6)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + dia;
                            else if (mes == 7)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + dia;
                            else if (mes == 8)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                            else if (mes == 9)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                            else if (mes == 10)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                            else if (mes == 11)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                            else if (mes == 12)
                                DiasTranscurridos1ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;
                        }
                        Console.SetCursorPosition(12, 8); Console.Write("Introduzca una fecha Final (dd/mm/aaaa): ");
                        Console.SetCursorPosition(12, 9); FechaFinal = Console.ReadLine(); //Introducimos por teclado la 2º Fecha
                        separar = FechaFinal.Split(separadores);    // Una vez leido uno de los simbolos indicados en 'separadores' pasa al siguiente espacio del array
                        dia = int.Parse(separar[0]); diaF = dia;    //Guardamos el dia y usamos el caracter del array en la posicion 0 y lo pasamos a otra variable
                        mes = int.Parse(separar[1]); mesF = mes;    //Guardamos el mes y usamos el caracter del array en la posicion 1 y lo pasamos a otra variable
                        año = int.Parse(separar[2]); añoF = año;    //Guardamos el año y usamos el caracter del array en la posicion 2 y lo pasamos a otra variable

                        do
                        {
                            if (esFechaCorrecta(dia, mes, año)) //Llamamos a la funcion para comprobar que la fecha sea correcta
                            {
                                if (añoF > añoI || añoF == añoI && (mesF > mesI) || añoF == añoI && mesF == mesI && (diaF > diaI)) //Comprobamos que la 2º Fecha sea mayor que la 1º
                                {
                                    if (esBisiesto(año)) //Llamamos a la funcion para saber si es bisiesto
                                    {                                        
                                        AñosTranscurridos = 0;
                                        febrero = 28;
                                        febrero++;
                                        if (mes == 1)
                                            DiasTranscurridos2ºFecha = dia;
                                        else if (mes == 2)
                                            DiasTranscurridos2ºFecha = enero + dia;
                                        else if (mes == 3)
                                            DiasTranscurridos2ºFecha = enero + febrero + dia;
                                        else if (mes == 4)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + dia;
                                        else if (mes == 5)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + dia;
                                        else if (mes == 6)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + dia;
                                        else if (mes == 7)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + dia;
                                        else if (mes == 8)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                                        else if (mes == 9)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                                        else if (mes == 10)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                                        else if (mes == 11)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                                        else if (mes == 12)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;
                                        
                                        while (añoT < añoF) //Mientras los años totales sean menores que el introducido en la 2º Fecha
                                        {
                                            añoT++;         //Sumamos +1 al año
                                            AñosTranscurridos = AñosTranscurridos + 365; //Sumamos +365 dias
                                        }
                                        DiferenciaDeDias = (DiasTranscurridos2ºFecha - DiasTranscurridos1ºFecha) + AñosTranscurridos; //Restamos los dias a los de la 2º Fecha
                                        Console.SetCursorPosition(12, 11); Console.WriteLine("Entre el {0}/{1}/{2} y el {3}/{4}/{5} han transcurrido {6} dias ", diaI, mesI, añoI, diaF, mesF, añoF, DiferenciaDeDias);                                        
                                    }
                                    else
                                    {
                                        AñosTranscurridos = 0;
                                        if (mes == 1)
                                            DiasTranscurridos2ºFecha = dia;
                                        else if (mes == 2)
                                            DiasTranscurridos2ºFecha = enero + dia;
                                        else if (mes == 3)
                                            DiasTranscurridos2ºFecha = enero + febrero + dia;
                                        else if (mes == 4)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + dia;
                                        else if (mes == 5)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + dia;
                                        else if (mes == 6)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + dia;
                                        else if (mes == 7)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + dia;
                                        else if (mes == 8)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + dia;
                                        else if (mes == 9)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
                                        else if (mes == 10)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
                                        else if (mes == 11)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
                                        else if (mes == 12)
                                            DiasTranscurridos2ºFecha = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;
                                        
                                        while (añoT < añoF) //Mientras los años totales sean menores que el introducido en la 2º Fecha
                                        {
                                            añoT++;         //Sumamos +1 al año
                                            AñosTranscurridos = AñosTranscurridos + 365; //Sumamos +365 dias
                                        }
                                        DiferenciaDeDias = (DiasTranscurridos2ºFecha - DiasTranscurridos1ºFecha) + AñosTranscurridos; //Restamos los dias a los de la 2º Fecha
                                        Console.SetCursorPosition(12, 11); Console.WriteLine("Entre el {0}/{1}/{2} y el {3}/{4}/{5} han transcurrido {6} dias ", diaI, mesI, añoI, diaF, mesF, añoF, DiferenciaDeDias);                                        
                                    }
                                }
                                else { Console.SetCursorPosition(12, 11); Console.WriteLine("** ERROR - Fecha final menor que la inicial"); break; }
                            }
                            else { Console.SetCursorPosition(12, 11); Console.WriteLine("Has escrito una fecha incorrecta"); break; }

                        } while (!esFechaCorrecta(dia, mes, año)); //Hacer - Mientras la fecha sea correcta si no, sale del bucle
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(12, 13); Console.WriteLine("¿Desea continuar (S/N)?");
                        Console.ResetColor();
                    }
                    else { Console.SetCursorPosition(12, 11); Console.WriteLine("Has escrito una fecha incorrecta"); break; }

                } while (!esFechaCorrecta(dia, mes, año)); //Hacer - Mientras la fecha sea correcta si no, sale del bucle
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 13); Console.WriteLine("¿Desea continuar (S/N)?");
                Console.ResetColor();

            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'             
        }
        static void Opcion5Calendario()
        {
            int aaaa, Sacar;            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Fines de Semana ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca un año (aaaa): ");
                Console.SetCursorPosition(12, 5); string AñoI = Console.ReadLine(); 
                if (int.TryParse(AñoI, out Sacar))
                {
                    aaaa = int.Parse(AñoI);
                    Console.SetCursorPosition(12, 5); Console.Write("{0}", aaaa);
                }

                Console.SetCursorPosition(12, 7); Console.Write("Enero: ");
                Console.SetCursorPosition(12, 8); Console.Write("════════");
                Console.SetCursorPosition(12, 9); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 10); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(12, 12); Console.Write("Febrero: ");
                Console.SetCursorPosition(12, 13); Console.Write("════════");
                Console.SetCursorPosition(12, 14); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 15); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(12, 17); Console.Write("Marzo: ");
                Console.SetCursorPosition(12, 18); Console.Write("════════");
                Console.SetCursorPosition(12, 19); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 20); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(12, 22); Console.Write("Abril: ");
                Console.SetCursorPosition(12, 23); Console.Write("════════");
                Console.SetCursorPosition(12, 24); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 25); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(12, 27); Console.Write("Mayo: ");
                Console.SetCursorPosition(12, 28); Console.Write("════════");
                Console.SetCursorPosition(12, 29); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 30); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(12, 32); Console.Write("Junio: ");
                Console.SetCursorPosition(12, 33); Console.Write("════════");
                Console.SetCursorPosition(12, 34); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(12, 35); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 7); Console.Write("Julio: ");
                Console.SetCursorPosition(60, 8); Console.Write("════════");
                Console.SetCursorPosition(60, 9); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 10); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 12); Console.Write("Agosto: ");
                Console.SetCursorPosition(60, 13); Console.Write("════════");
                Console.SetCursorPosition(60, 14); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 15); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 17); Console.Write("Septiembre: ");
                Console.SetCursorPosition(60, 18); Console.Write("════════");
                Console.SetCursorPosition(60, 19); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 20); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 22); Console.Write("Octubre: ");
                Console.SetCursorPosition(60, 23); Console.Write("════════");
                Console.SetCursorPosition(60, 24); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 25); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 27); Console.Write("Noviembre: ");
                Console.SetCursorPosition(60, 28); Console.Write("════════");
                Console.SetCursorPosition(60, 29); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 30); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.SetCursorPosition(60, 32); Console.Write("Diciembre: ");
                Console.SetCursorPosition(60, 33); Console.Write("════════");
                Console.SetCursorPosition(60, 34); Console.Write("Sabado: {0}, {1}, {2}, {3} ");
                Console.SetCursorPosition(60, 35); Console.Write("Domingo: {0}, {1}, {2}, {3} ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(45, 2); Console.WriteLine("¿Deseas seguir introduciendo fechas (S/N)?");
                Console.ResetColor();
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S' 
        }
        #endregion
        #region Recursividad
        static void Opcion4()
        {
            const char opcionNA_salir = '0'; //Constante (Utilizada mas tarde para finalizar el programa)
            char opcion;                     // Variable donde se guarda la opcion elegida para el switch
            do                                        
            {
                MuestraMenuRecursividad();          //Invocamos a la funcion del Menu de Numeros Aleatorios
                opcion = Console.ReadKey().KeyChar; //Leemos del teclado la opcion elegida
                switch (opcion)
                {
                    case '1':
                        Opcion1Recursividad();
                        break;
                    case '2':
                        Opcion2Recursividad();
                        break;                    
                }
            } while (opcion != opcionNA_salir); //Hacer - Mientras no pulsen la opcion_salir que es '0'
        }                                      //Control de las opciones de la Recursividad
        static void MuestraMenuRecursividad()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(23, 2); Console.Write("=== Recursividad ===");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 4); Console.Write("1 - Calculo del Maximo comun Divisor");
            Console.SetCursorPosition(15, 5); Console.Write("2 - Evaluador de Expresiones Matematicas");
            Console.ResetColor();
            Console.SetCursorPosition(15, 6); Console.Write("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(15, 7); Console.Write("0 - Volver al menu anterior");
            Console.ResetColor();
            Console.SetCursorPosition(15, 9); Console.Write("Introduzca una opción: ");
        }        
        static void Opcion1Recursividad()
        {            
            int n1, n2, Resultado;

            do
            {
                Console.Clear();
                int Sacar;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Calculo Maximo Comun Divisor ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca primer numero: ");
                Console.SetCursorPosition(12, 5); string n1Temp = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                if (int.TryParse(n1Temp, out Sacar)) //Intenta convertir el valor en un tipo determinado
                {
                    n1 = int.Parse(n1Temp); //Convierte el valor introducido y lo guarda en una nueva variable
                    {
                        Console.SetCursorPosition(12, 7); Console.Write("Introduzca segundo numero: ");
                        Console.SetCursorPosition(12, 8); string n2Temp = Console.ReadLine(); //Lee la cadena de caracteres introducidos
                        if (int.TryParse(n2Temp, out Sacar)) //Intenta convertir el valor en un tipo determinado
                        {
                            n2 = int.Parse(n2Temp); //Convierte el valor introducido y lo guarda en una nueva variable
                            {
                                int a = Math.Max(n1, n2); //Devuelve el mayor de los 2
                                int b = Math.Min(n1, n2); //Devuelve le menor de los 2

                                do
                                {
                                    Resultado = b;
                                    b = a % b;
                                    a = Resultado;

                                } while (b != 0); //Hacer - Mientras se cumpla 'b' diferente de 0
                                Console.SetCursorPosition(12, 10); Console.Write("El maximo comun divisor es: {0} ", Resultado);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(12, 12); Console.WriteLine("¿Desea continuar con MCD (S/N)?");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(12, 10); Console.WriteLine("El valor introducido es incorrecto");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(12, 12); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                            Console.ResetColor();
                        }  
                    }
                }
                else
                {
                    Console.SetCursorPosition(12, 7); Console.WriteLine("El valor introducido es incorrecto");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(12, 9); Console.WriteLine("Pulse una tecla para voler al Menu anterior");
                    Console.ResetColor();
                }                
            } while (Console.ReadKey().Key == ConsoleKey.S); //Hacer - Mientras pulsemos 'S'
        }
        static void Opcion2Recursividad()
        {
            int acu;
            char car, Valor, Sacar;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(12, 2); Console.Write("=== Evaluador de Expresiones Matematicas ===");
                Console.ResetColor();
                Console.SetCursorPosition(12, 4); Console.Write("Introduzca la expresion Matematica: ");
                Console.SetCursorPosition(12, 6); string Expresion = Console.ReadLine();
                if (char.TryParse(Expresion, out Sacar))
                {
                    Valor = char.Parse(Expresion); car = Valor;                    
                    {                        
                        if (car >= '0' && car <= '9')
                        {                           
                            acu = int.Parse(car.ToString()); //usándose esta línea para pasar de “char” a “int”
                            
                            Console.SetCursorPosition(12, 10); Console.Write("{0}", Valor);
                        }
                        else { Console.SetCursorPosition(12, 8); Console.WriteLine("-- Error -- Rango invalido (F:finaliza)"); }
                    }
                }
                else { Console.SetCursorPosition(12, 8); Console.WriteLine("-- Error -- Expresion incorrecta, pulse una tecla (F:finaliza)"); }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(12, 10); Console.WriteLine("F:finaliza");
                Console.ResetColor();
            } while (Console.ReadKey().Key != ConsoleKey.F); //Hacer - Mientras no pulsemos 'F'
        }
        #endregion
    }
}