using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Evaluable___Libreria
{
    class Revista : Material
    {
        string Nombre;
        string Periodicidad;
        string ISSN;     
           
        public Revista()
        {

        }
        public Revista(string Nombre, string Periodicidad, string ISSN, 
            string TipoMaterial, string Codigo, int Stock, double PrecioCoste, 
            string Proveedor, string Edicion) : base (TipoMaterial, Codigo, Stock, PrecioCoste, Proveedor, Edicion)
        {
            this.Nombre = Nombre;
            this.Periodicidad = Periodicidad;
            this.ISSN = ISSN;
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string periodicidad
        {
            get { return Periodicidad; }
            set { Periodicidad = value; }
        }
        public string issn
        {
            get { return ISSN; }
            set { ISSN = value; }
        }
    }
}
