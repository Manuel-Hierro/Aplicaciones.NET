using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************
    Autor: Manuel Jesus Hierro Pinto
    Fecha Creacion:       24/04/2018
    Ultima Modificacion:  20/05/2018
    Version:              Beta
 **************************************/

namespace Programacion___1º_Problema___3EV
{
    class Empleado
    {
        string Nombre;
        bool Trabajando;       
        public decimal sueldo;
        /// <summary>
        /// Constructores
        /// </summary>
        public Empleado()
        {
            Nombre = "Sin Asignar";
            Trabajando = true;
        }
        public Empleado(string Nombre, bool Trabajando)
        {
            this.Nombre = Nombre;
            this.Trabajando = Trabajando;
        }
        /// <summary>
        /// Propiedades
        /// </summary>
        public string nombre
        {
            get {return Nombre;}
            set {Nombre = value;}
        }
        public bool trabajando
        {
            get {return Trabajando;}
            set {Trabajando = value;}
        }
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="nDias">Dias Trabajados</param>
        /// <returns>Ganancias economicas</returns>
        public virtual decimal Sueldo(int nDias)
        {
            sueldo = nDias * 20;
            return sueldo;                     
        }
        public virtual string Cargo()
        {
            return "Empleado";
        }              
        public string MostrarTrabajando()
        {
            if (trabajando == true)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }
        public void MostrarEmpleado()
        {
            Console.WriteLine("Nombre: {0}\t\tCargo: {1}", nombre, Cargo());
        }
        public void MostrarSueldo()
        {          
          Console.WriteLine("\tNombre: {0}\t\tSueldo: {1}\t\tTrabajando: {2}\t\tCargo: {3}", nombre, sueldo, MostrarTrabajando(), Cargo());
        }
    }
    class Directivo : Empleado
    {
        public List<Empleado> EmpleadosSupervisados;
        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Trabajando"></param>
        public Directivo(string Nombre, bool Trabajando) : base(Nombre, Trabajando)
        {
            this.nombre = Nombre;
            this.trabajando = Trabajando;
            EmpleadosSupervisados = new List<Empleado>();
    }
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="nDias">Dias Trabajados</param>
        /// <returns>Ganancias economicas</returns>
        public override decimal Sueldo(int nDias)
        {
            if (trabajando == true)
            {
                sueldo = (15 + (2 * EmpleadosSupervisados.Count)) * nDias;
            }
            else
            {
                sueldo = nDias * 20;
            }
            return sueldo;
        }
        public override string Cargo()
        {
            return "Directivo";
        }
        public void Supervisa(Empleado UnEmpleado)
        {
            EmpleadosSupervisados.Add(UnEmpleado);
        }        
    }
    class Operario : Empleado
    {
        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Trabajando"></param>
        public Operario(string Nombre, bool Trabajando) : base(Nombre, Trabajando)
        {
            this.nombre = Nombre;
            this.trabajando = Trabajando;
        }
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="nDias">Dias Trabajados</param>
        /// <returns>Ganancias economicas</returns>
        public override decimal Sueldo(int nDias)
        {
            if (trabajando == true)
            {
                sueldo = (5 * nDias) + base.Sueldo(nDias);
            }
            else
            {
                sueldo = nDias * 20;
                return sueldo;
            }
            return sueldo;
        }
        public override string Cargo()
        {
            return "Operario";
        }
    }
    class Oficial : Operario
    {
        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Trabajando"></param>
        public Oficial(string Nombre, bool Trabajando) : base(Nombre, Trabajando)
        {
            this.nombre = Nombre;
            this.trabajando = Trabajando;
        }
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="nDias">Dias Trabajados</param>
        /// <returns>Ganancias economicas</returns>
        public override decimal Sueldo(int nDias)
        {            
            if (trabajando == true)
            {
                if (nDias <= 15)
                {
                    sueldo = nDias * 50;
                }
                else
                if (nDias > 15)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        nDias--;
                    }
                    sueldo = (15 * 50) + (nDias * 28);
                }
            }
            return sueldo;
        }
        public override string Cargo()
        {
            return "Oficial";
        }
    }
    class Tecnico : Operario
    {
        /// <summary>
        /// Constructores
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Trabajando"></param>
        public Tecnico(string Nombre, bool Trabajando) : base(Nombre, Trabajando)
        {
            this.nombre = Nombre;
            this.trabajando = Trabajando;
        }
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="nDias">Dias Trabajados</param>
        /// <returns>Ganancias economicas</returns>
        public override decimal Sueldo(int nDias)
        {
            if (trabajando == true)
            {
                sueldo = base.Sueldo(nDias);
            }
            else
            {
                sueldo = nDias * 20;
                return sueldo;
            }
            return sueldo;
        }
        public override string Cargo()
        {
            return "Tecnico";
        }
    }    
}
   

