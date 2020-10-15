using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace Ejercicio_Evaluable___Libreria
{
    class Material
    {
        string TipoMaterial;
        string Codigo;
        int Stock;
        double PrecioCoste;
        string Proveedor;
        string Edicion;

        public Material()
        {

        }
        public Material(string TipoMaterial, string Codigo, int Stock, double PrecioCoste, string Proveedor, string Edicion)
        {
            this.TipoMaterial = TipoMaterial;
            this.Codigo = Codigo;
            this.Stock = Stock;
            this.PrecioCoste = PrecioCoste;
            this.Proveedor = Proveedor;
            this.Edicion = Edicion;
        }
        public string tipoMaterial
        {
            get { return TipoMaterial; }
            set { TipoMaterial = value; }
        }
        public string codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public int stock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public double precioCoste
        {
            get { return PrecioCoste; }
            set { PrecioCoste = value; }
        }
        public string proveedor
        {
            get { return Proveedor; }
            set { Proveedor = value; }
        }
        public string edicion
        {
            get { return Edicion; }
            set { Edicion = value; }
        }
        public void incrementaMaterial(string codigo, int unidad)
        {
            if (this.codigo == codigo)
            {
                Stock = Stock + unidad;
            }            
        }
        public void bajaMaterial(ref List<Material> materiales, ref DataGridView dataGV_Gestion, TextBox txtBox_Codigo)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                foreach (DataGridViewRow row in dataGV_Gestion.Rows)
                {
                    if(dataGV_Gestion.Rows[i].Cells[1].Value.ToString() == txtBox_Codigo.Text)
                    {
                        dataGV_Gestion.Rows.Remove(row);
                    }
                }
            }
        }
    }
}
