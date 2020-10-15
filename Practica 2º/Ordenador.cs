using System;
using System.Collections.Generic;
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
    class Ordenador
    {
        string ID;
        string Nombre;
        string RAM;
        string DiscoDuro;
        string Procesador;
        string TarjetaGrafica;
        string Aplicaciones;
        int Ubicacion;
        DateTime Fecha;

        

        public Ordenador() //Constructor por defecto
        {
            ID = "";
            Nombre = "";
            RAM = "";
            DiscoDuro = "";
            Procesador = "";
            TarjetaGrafica = "";
            Aplicaciones = "";
            Ubicacion = 0;
            Fecha = DateTime.Now;

            
        }
        public Ordenador(string ID, string Nombre, string RAM, string DiscoDuro, string Procesador, string TarjetaGrafica, string Aplicaciones, int Ubicacion, DateTime Fecha)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.RAM = RAM;
            this.DiscoDuro = DiscoDuro;
            this.Procesador = Procesador;
            this.TarjetaGrafica = TarjetaGrafica;
            this.Aplicaciones = Aplicaciones;
            this.Ubicacion = Ubicacion;
            this.Fecha = Fecha;

            
        }
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string ram
        {
            get { return RAM; }
            set { RAM = value; }
        }
        public string discoduro
        {
            get { return DiscoDuro; }
            set { DiscoDuro = value; }
        }
        public string procesador
        {
            get { return Procesador; }
            set { Procesador = value; }
        }
        public string tarjetagrafica
        {
            get { return TarjetaGrafica; }
            set { TarjetaGrafica = value; }
        }
        public string aplicaciones
        {
            get { return Aplicaciones; }
            set { Aplicaciones = value; }
        }
        public int ubicacion
        {
            get { return Ubicacion; }
            set { Ubicacion = value; }
        }
        public DateTime fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }       
    }
}
