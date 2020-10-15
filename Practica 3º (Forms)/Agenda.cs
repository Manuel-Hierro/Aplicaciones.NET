using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Programacion___2º_Problema__Forms____3EV
{
    class Agenda
    {
        const string cabecera = "\n Fichero con informacion de Agenda\n\n";
        string nombre;
        int maximo;
        List<Persona> ListaPersonas;
        public Agenda(string nombre, int maximo)
        {
            this.nombre = nombre;
            this.maximo = maximo;
            ListaPersonas = new List<Persona>();
        }
        public Agenda()
        {
            nombre = "";
            maximo = 0;
        }
        public Agenda(BinaryReader reader)
        {
            string cabecerafichero;
            try
            {
                cabecerafichero = reader.ReadString();
            }
            catch
            {
                throw new Exception("La agenda esta vacia");
            }
            nombre = reader.ReadString();
            int nperson = reader.ReadInt32();
            maximo = nperson + reader.ReadInt32();
            ListaPersonas = new List<Persona>();
            for (int i = 0; i < nperson; i++)
            {
                ListaPersonas.Add(new Persona(reader));
            }
        }
        public void AñadePersona(Persona p)
        {
            if (ListaPersonas.Count < maximo)
            {
                ListaPersonas.Add(p);
            }
            else
            {
                throw new Exception("La agenda esta completa");
            }
        }
        public void Escribir(BinaryWriter writer)
        {
            writer.Write(cabecera);
            writer.Write(nombre);
            writer.Write(ListaPersonas.Count);
            writer.Write((maximo) - (ListaPersonas.Count));

            foreach (Persona item in ListaPersonas)
            {
                item.Escribir(writer);
            }
        }
        public void CrearHTML(BinaryWriter writer)
        {
            writer.Write("<html>");
            writer.Write("<head><title>" + cabecera + "</title></head>");
            writer.Write("<body bgcolor='#AED6F1'");
            writer.Write("<h1 align='center'>Nombre Agenda: " + nombre + "</h1>");            
            writer.Write("<h1 align='center'>Entradas Ocupadas: " + ListaPersonas.Count + "</h1>");
            writer.Write("<h1 align='center'>Libres: " + ((maximo) - (ListaPersonas.Count)) + "</h1>");            
            writer.Write("<table align='center' border='3' bgcolor='white'>");
            writer.Write("<tr>");
            writer.Write("<th> Nombre </th>");
            writer.Write("<th> Apellidos </th>");
            writer.Write("<th> Telefono </th>");
            writer.Write("<th> Fecha Nacimiento </th>");
            writer.Write("</tr>");            

            foreach (Persona selec in ListaPersonas)
            {
                selec.CrearHTML(writer);
            }
            writer.Write("</table>");
            writer.Write("</body>");
            writer.Write("</html>");
        }
    }
}
