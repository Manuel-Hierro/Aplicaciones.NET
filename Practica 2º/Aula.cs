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
    class Aula
    {
        int ID;
        string Nombre;
        DateTime Fecha;

        int Ubicacion;

        public Aula() //Constructor por defecto
        {
            ID = 0;
            Nombre = "";
            Fecha = DateTime.Now;

            Ubicacion = 0;        
        }
        public Aula(int ID, string Nombre, DateTime Fecha, int Ubicacion)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Fecha = Fecha;

            this.Ubicacion = Ubicacion;  
        }
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public DateTime fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public int ubicacion
        {
            get { return Ubicacion; }
            set { Ubicacion = value; }
        }
    }
}
