using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Evaluable___Libreria
{
    class Libro : Material
    {
        string Titulo;
        string Autor;
        string Editorial;
        string ISBN;

        public Libro()
        {

        }
        public Libro(string Titulo, string Autor, string Editorial, string ISBN, 
            string TipoMaterial, string Codigo, int Stock, double PrecioCoste, 
            string Proveedor, string Edicion): base (TipoMaterial, Codigo, Stock, PrecioCoste, Proveedor, Edicion)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Editorial = Editorial;
            this.ISBN = ISBN;            
        }
        public string titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        public string autor
        {
            get { return Autor; }
            set { Autor = value; }
        }
        public string editorial
        {
            get { return Editorial; }
            set { Editorial = value; }
        }
        public string isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
    }
}
