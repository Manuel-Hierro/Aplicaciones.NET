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
    public partial class Almacen : Form
    {
        List<Material> materiales = new List<Material>();
        public Almacen()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {

            /* Materiales includos ya por defecto (para pruebas de codigo) */

            Libro material = new Libro("Sin", "Anonimo", "Quebrada", "xx-xx-xx", "Libro", "11", 2, 2.5, "Desconocido", "Plus");
            Libro material1 = new Libro("Sin", "Anonimo", "Quebrada", "xx-xx-xx", "Libro", "11", 3, 3.5, "Desconocido", "Plus");
            Libro material2 = new Libro("Sin", "Anonimo", "Quebrada", "xx-xx-xx", "Libro", "12", 4, 4.5, "Desconocido", "Plus");
            Revista material3 = new Revista("Desconocido", "Diaria", "xx-xx-xx", "Revista", "13", 2, 2.5, "Desconocido", "Plus");
            Revista material4 = new Revista("Desconocido", "Diaria", "xx-xx-xx", "Revista", "14", 2, 2.5, "Desconocido", "Plus");

            materiales.Add(material);
            materiales.Add(material1);
            materiales.Add(material2);
            materiales.Add(material3);
            materiales.Add(material4);

            dataGV_Gestion.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste, material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Gestion.Rows.Add(material1.tipoMaterial, material1.codigo, material1.stock, material1.precioCoste, material1.proveedor, material1.edicion, null, null, null, material1.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Gestion.Rows.Add(material2.tipoMaterial, material2.codigo, material2.stock, material2.precioCoste, material2.proveedor, material2.edicion, null, null, null, material2.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Gestion.Rows.Add(material3.tipoMaterial, material3.codigo, material3.stock, material3.precioCoste, material3.proveedor, material3.edicion, material3.nombre, material3.periodicidad, material3.issn);
            dataGV_Gestion.Rows.Add(material4.tipoMaterial, material4.codigo, material4.stock, material4.precioCoste, material4.proveedor, material4.edicion, material4.nombre, material4.periodicidad, material4.issn);
            
            dataGV_Pedido.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste, material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Pedido.Rows.Add(material1.tipoMaterial, material1.codigo, material1.stock, material1.precioCoste, material1.proveedor, material1.edicion, null, null, null, material1.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Pedido.Rows.Add(material2.tipoMaterial, material2.codigo, material2.stock, material2.precioCoste, material2.proveedor, material2.edicion, null, null, null, material2.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Pedido.Rows.Add(material3.tipoMaterial, material3.codigo, material3.stock, material3.precioCoste, material3.proveedor, material3.edicion, material3.nombre, material3.periodicidad, material3.issn);
            dataGV_Pedido.Rows.Add(material4.tipoMaterial, material4.codigo, material4.stock, material4.precioCoste, material4.proveedor, material4.edicion, material4.nombre, material4.periodicidad, material4.issn);

            dataGV_Buscar.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste, material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Buscar.Rows.Add(material1.tipoMaterial, material1.codigo, material1.stock, material1.precioCoste, material1.proveedor, material1.edicion, null, null, null, material1.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Buscar.Rows.Add(material2.tipoMaterial, material2.codigo, material2.stock, material2.precioCoste, material2.proveedor, material2.edicion, null, null, null, material2.titulo, material.autor, material.editorial, material.isbn);
            dataGV_Buscar.Rows.Add(material3.tipoMaterial, material3.codigo, material3.stock, material3.precioCoste, material3.proveedor, material3.edicion, material3.nombre, material3.periodicidad, material3.issn);
            dataGV_Buscar.Rows.Add(material4.tipoMaterial, material4.codigo, material4.stock, material4.precioCoste, material4.proveedor, material4.edicion, material4.nombre, material4.periodicidad, material4.issn);
        }
        private void cBox_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_Material.SelectedIndex == 0)
            {
                txtBox_Nombre.Enabled = false;
                txtBox_Periodicidad.Enabled = false;
                txtBox_ISSN.Enabled = false;

                txtBox_Titulo.Enabled = true;
                txtBox_Autor.Enabled = true;
                txtBox_Editorial.Enabled = true;
                txtBox_ISBN.Enabled = true;
            }
            else if (cBox_Material.SelectedIndex == 1)
            {
                txtBox_Nombre.Enabled = true;
                txtBox_Periodicidad.Enabled = true;
                txtBox_ISSN.Enabled = true;

                txtBox_Titulo.Enabled = false;
                txtBox_Autor.Enabled = false;
                txtBox_Editorial.Enabled = false;
                txtBox_ISBN.Enabled = false;                
            }
        }
        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            if (cBox_Material.SelectedIndex == 0)
            {
                try
                {
                    Libro material = new Libro();

                    material.tipoMaterial = cBox_Material.SelectedItem.ToString();
                    material.codigo = txtBox_Codigo.Text;
                    material.stock = int.Parse(txtBox_Stock.Text);
                    material.precioCoste = double.Parse(txtBox_PCoste.Text);
                    material.proveedor = txtBox__Proveedor.Text;
                    material.edicion = txtBox_Edicion.Text;

                    material.titulo = txtBox_Titulo.Text;
                    material.autor = txtBox_Autor.Text;
                    material.editorial = txtBox_Editorial.Text;
                    material.isbn = txtBox_ISBN.Text;

                    materiales.Add(material);

                    dataGV_Gestion.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste, 
                        material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);

                    dataGV_Pedido.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste,
                        material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);

                    dataGV_Buscar.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste,
                        material.proveedor, material.edicion, null, null, null, material.titulo, material.autor, material.editorial, material.isbn);
                }
                catch
                {
                    MessageBox.Show("Error, alguno de los campos son incorrectos");
                }      
            }
            else if (cBox_Material.SelectedIndex == 1)
            {
                try
                {
                    Revista material = new Revista();

                    material.tipoMaterial = cBox_Material.SelectedItem.ToString();
                    material.codigo = txtBox_Codigo.Text;
                    material.stock = int.Parse(txtBox_Stock.Text);
                    material.precioCoste = double.Parse(txtBox_PCoste.Text);
                    material.proveedor = txtBox__Proveedor.Text;
                    material.edicion = txtBox_Edicion.Text;

                    material.nombre = txtBox_Nombre.Text;
                    material.periodicidad = txtBox_Periodicidad.Text;
                    material.issn = txtBox_ISSN.Text;

                    materiales.Add(material);

                    dataGV_Gestion.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste,
                        material.proveedor, material.edicion, material.nombre, material.periodicidad, material.issn);

                    dataGV_Pedido.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste,
                        material.proveedor, material.edicion, material.nombre, material.periodicidad, material.issn);

                    dataGV_Buscar.Rows.Add(material.tipoMaterial, material.codigo, material.stock, material.precioCoste,
                        material.proveedor, material.edicion, material.nombre, material.periodicidad, material.issn);
                }
                catch
                {
                    MessageBox.Show("Error, alguno de los campos son incorrectos");
                }
            }

            cBox_Material.SelectedIndex = -1;
            txtBox_Codigo.Clear();
            txtBox_Stock.Clear();
            txtBox_PCoste.Clear();
            txtBox__Proveedor.Clear();
            txtBox_Edicion.Clear();

            txtBox_Titulo.Clear();
            txtBox_Autor.Clear();
            txtBox_Editorial.Clear();
            txtBox_ISBN.Clear();

            txtBox_Nombre.Clear();
            txtBox_Periodicidad.Clear();
            txtBox_ISSN.Clear();
        }
        private void btn_Retirar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                Material item = materiales.Find(test => (test.codigo == txtBox_Codigo.Text));

                if (txtBox_Codigo.Text == materiales[i].codigo)
                {
                    materiales.Remove(item);

                    materiales[i].bajaMaterial(ref materiales, ref dataGV_Gestion, txtBox_Codigo);
                }
            }
        }     
        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                /* Si el codigo del pedido es igual, al obejto de la lista incrementamos su stock */

                if (txtBox_Pedido_Codigo.Text == materiales[i].codigo) 
                {
                    materiales[i].incrementaMaterial(materiales[i].codigo, int.Parse(txtBox_Pedido_Cantidad.Text)); //Llamamos a la funcion en cada pasada

                    dataGV_Gestion.Rows[i].Cells[2].Value = materiales[i].stock;
                    dataGV_Pedido.Rows[i].Cells[2].Value = materiales[i].stock;
                    dataGV_Buscar.Rows[i].Cells[2].Value = materiales[i].stock;
                }
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            /* Buscamos el objeto con el codigo introducido dentro de la lista */

            Material item = materiales.Find(test => (test.codigo == txtBox_Buscar_Codigo.Text)); 

            /* Creamos un pequeño caja de texto indicando el codigo y el stock del material */

            if (item != null)
            {
                MessageBox.Show("El material solicitado es: " + item.codigo + " y su Stock es: " + item.stock.ToString());
            }
            else
            {
                MessageBox.Show("El material solicitado no fue encontrado");
            }
        }
    }
}
