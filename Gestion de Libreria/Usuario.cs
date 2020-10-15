using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Evaluable___Libreria
{
    class Usuario
    {
        int ID;
        string Nombre;
        string Contraseña;

        public Usuario()
        {
           
        }
        public Usuario(int ID, string Nombre, string Contraseña)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
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
        public string contraseña
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }
    }
}
