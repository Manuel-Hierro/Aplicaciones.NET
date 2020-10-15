using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programacion___2º_Problema__Forms____3EV
{
    class Persona
    {
        string Nombre;
        string Apellidos;
        string FechaNacimiento;
        string Telefono;

        public Persona(string Nombre, string Apellidos, string FechaNacimiento, string Telefono)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
            this.Telefono = Telefono;
        }
        public Persona(BinaryReader reader)
        {
            Leer(reader);
        }
        public void Leer(BinaryReader reader)
        {
            Nombre = reader.ReadString();
            Apellidos = reader.ReadString();
            FechaNacimiento = reader.ReadString();
            Telefono = reader.ReadString();
        }
        public void Escribir(BinaryWriter writer)
        {
            writer.Write(Nombre);
            writer.Write(Apellidos);
            writer.Write(FechaNacimiento);
            writer.Write(Telefono);
        }
        public void CrearHTML(BinaryWriter writer)
        {
            writer.Write("<tr>");
            writer.Write("<td>" + Nombre + "</td>");
            writer.Write("<td>" + Apellidos + "</td>");
            writer.Write("<td>" + Telefono + "</td>");
            writer.Write("<td>" + FechaNacimiento + "</td>");
            writer.Write("</tr>");
        }
    }
}
