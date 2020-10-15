using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programacion___2º_Problema__Forms____3EV
{
    public partial class Principal : Form
    {
        BinaryReader read;
        BinaryWriter write;
        FileStream fs;
        Agenda agenda;
        public Principal()
        {
            InitializeComponent();            
        }
        private void Crear_Click(object sender, EventArgs e)
        {
            agenda = new Agenda(NombreAgendaBox.Text, (int)EntradasBox.Value);

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            MessageBox.Show("La agenda fue creada temporalmente   -   sin guardadar");
        }
        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogAbrir = new OpenFileDialog();
            dialogAbrir.Filter = "Todos los archivos|*.agenda";            
            dialogAbrir.Title = "Abrir como";
            dialogAbrir.CheckFileExists = false;

            if (dialogAbrir.ShowDialog() == DialogResult.OK)            {
                
                fs = new FileStream(dialogAbrir.FileName, FileMode.Open, FileAccess.Read);
                read = new BinaryReader(fs);
                try
                {
                    agenda = new Agenda(read);
                    groupBox2.Enabled = true;
                }
                catch (Exception error)
                {
                    if (error.Message == "La agenda esta vacia")
                    {
                        agenda = new Agenda();
                        groupBox1.Enabled = true;
                    }
                    MessageBox.Show(error.Message);
                }
                finally
                {                    
                    read.Close();
                    fs.Close();
                }
            }
        }       
        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona(NombreBox.Text, ApellidosBox.Text, FechaNacimientoBox.Text, TelefonoBox.Text);
                agenda.AñadePersona(p);
                MessageBox.Show("Persona añadida correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }  
        private void Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogGuardar = new SaveFileDialog();
            dialogGuardar.Filter = "Todos los archivos|*.agenda";
            dialogGuardar.Title = "Guardar como";            
            dialogGuardar.FileName = NombreAgendaBox.Text+".agenda";

            if (dialogGuardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(dialogGuardar.FileName, FileMode.Create, FileAccess.Write);
                    write = new BinaryWriter(fs);
                    agenda.Escribir(write);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    write.Close();
                    fs.Close();
                }
            }
        }
        private void ExportarEnHTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogExportar = new SaveFileDialog();
            dialogExportar.Filter = "Archivo html|*.html";
            dialogExportar.Title = "Guardar como HTML";
            dialogExportar.FileName = NombreAgendaBox.Text + ".html";

            if (dialogExportar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(dialogExportar.FileName, FileMode.Create, FileAccess.Write);
                    write = new BinaryWriter(fs, Encoding.UTF8);
                    agenda.CrearHTML(write);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    write.Close();
                    fs.Close();
                }
            }
        }        
    }
}
