using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        // Propiedades públicas para recibir los detalles del artículo
        public string CodigoArticulo
        {
            set { lblCodigo.Text = value; }
        }

        public string NombreArticulo
        {
            set { lblNombre.Text = value; }
        }

        public string DescripcionArticulo
        {
            set { lblDescripcion.Text = value; }
        }

        public string PrecioArticulo
        {
            set { lblPrecio.Text = value; }
        }

        public string CategoriaArticulo
        {
            set { lblCategoria.Text = value; }
        }

        public string MarcaArticulo
        {
            set { lblMarca.Text = value; }
        }




        private void lblCodigo_Click(object sender, EventArgs e)
        {
            // Este método está vacío, puedes eliminarlo si no es necesario
        }
    }
}