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
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulos == null) 
                {

                    bool existeCodigo = negocio.ExisteCodigo(textCodigo.Text);

                    if (existeCodigo)
                    {
        
                        MessageBox.Show("El código del artículo ya existe. Por favor, ingrese un código diferente.");
                        return;
                    }


                    Articulos nuevoArticulo = new Articulos();
                    nuevoArticulo.Codigo = textCodigo.Text;
                    nuevoArticulo.Nombre = textNombre.Text;
                    nuevoArticulo.Descripcion = textDescripcion.Text;
                    nuevoArticulo.precio = decimal.Parse(textPrecio.Text);
                    nuevoArticulo.categoria = (Categoria)txtCategoria.SelectedItem;
                    nuevoArticulo.marcas = (Marcas)txtMarca.SelectedItem;

                    negocio.agregar(nuevoArticulo); 
                    MessageBox.Show("Artículo agregado exitosamente.");
                }
                else 
                {
                    articulos.Codigo = textCodigo.Text;
                    articulos.Nombre = textNombre.Text;
                    articulos.Descripcion = textDescripcion.Text;
                    articulos.precio = decimal.Parse(textPrecio.Text);
                    articulos.categoria = (Categoria)txtCategoria.SelectedItem;
                    articulos.marcas = (Marcas)txtMarca.SelectedItem;

                    negocio.modificar(articulos); 
                    MessageBox.Show("Artículo modificado exitosamente.");
                }

                Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcasNegocio marcasNegocio = new MarcasNegocio();

            try
            {
                List<Categoria> listaCategorias = categoriaNegocio.listar();
                List<Marcas> listaMarcas = marcasNegocio.listar();

                txtCategoria.DataSource = listaCategorias;
                txtCategoria.DisplayMember = "Nombre"; 
                txtCategoria.ValueMember = "IdCategoria"; 

                txtMarca.DataSource = listaMarcas;
                txtMarca.DisplayMember = "Nombre"; 
                txtMarca.ValueMember = "IdMarca"; 

                if (articulos != null)
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
            catch (Exception ex)
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
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
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
        { }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
