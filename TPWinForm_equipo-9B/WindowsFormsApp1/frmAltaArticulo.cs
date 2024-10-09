using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Articulos";
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulos == null)
                    articulos = new Articulos();
                articulos.imagen = new Imagen();

                
                art.Codigo = textCodigo.Text;
                art.Nombre = textNombre.Text;
                art.Descripcion = textDescripcion.Text;
                art.precio = decimal.Parse(textPrecio.Text);
                art.categoria = (Categoria)txtCategoria.SelectedItem;
                art.marcas = (Marcas)txtMarca.SelectedItem;

                if (art.IdArticulo !=0)
                {
                    negocio.modificar(art);
                    MessageBox.Show("Fue modificado");
                }
                else
                {
                negocio.agregar(art);
                MessageBox.Show("Fue agregado");
                }
               
                Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

    

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {

            ArticulosNegocio negocio = new ArticulosNegocio();
            //   pbxArticulo.DataSource = negocio.listar();
            try
            {
                if(articulos != null)
                {
                    textCodigo.Text = articulos.Codigo;
                    textDescripcion.Text = articulos.Descripcion;
                    textNombre.Text = articulos.Nombre;
                    textPrecio.Text = articulos.precio.ToString();
                    textImagen.Text = articulos.imagen.Url;
                    CargarImagen(articulos.imagen.Url);
                    txtCategoria.SelectedValue = articulos.categoria.IdCategoria;
                    txtMarca.SelectedValue = articulos.marcas.IdMarca;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void textImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(textImagen.Text);
        } 

        private void CargarImagen(string imagen)
        {
            try
            {
             pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
            
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                textImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
