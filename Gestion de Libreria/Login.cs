using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Evaluable___Libreria
{
    public partial class Login : Form
    {
        int id = 1;
        List<Usuario> usuarios = new List<Usuario>();
        public Login()
        {
            InitializeComponent();           
        }
        private void Login_Load(object sender, EventArgs e)
        {
            /*  Usuarios por defecto */
            Usuario usuario = new Usuario(id,"","");
            Usuario usuario1 = new Usuario(id = id + 1, "user", "user");
            Usuario usuario2 = new Usuario(id = id + 1, "admin", "admin");

            usuarios.Add(usuario);
            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {     
            /* Comprueba que exista el usuario */
            Usuario item = usuarios.Find(test => (test.nombre == txtBox_usuario.Text) && (test.contraseña == txtBox_contraseña.Text));

            if (item != null)
            {
                MessageBox.Show("Se ha logueado satisfactoriamente");

                Almacen almacen = new Almacen(); //Creamos el objeto del otro Form
                almacen.Show(); //Carga otro Form

                Close(); //Cierra el Form actual (El main)
            }
            else
            {
                MessageBox.Show("No se ha podido loguear -- Error --");
            }            
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            /* Creamos el objeto y lo introducimos en la Lista de Usuarios */

            Usuario usuario = new Usuario();

            usuario.id = id++; //Incrementamos el ID para que sean siempre usuarios unicos (aun teniendo el mismo nombre)

            usuario.nombre = txtBox_usuario.Text;
            usuario.contraseña = txtBox_contraseña.Text;

            usuarios.Add(usuario);
            
            /* Para mostrar en  unfuturo la lista de usuarios */

            //ListViewItem lista = new ListViewItem(usuario.id.ToString());
            //lista.SubItems.Add(txtBox_usuario.Text);
            //lista.SubItems.Add(txtBox_contraseña.Text);

            //listView1.Items.Add(lista);
        }        
    }
}
