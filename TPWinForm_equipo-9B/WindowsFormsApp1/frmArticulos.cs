using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class frmArticulos : Form
    {

        private Articulos articulo = null;
        

        private List<Articulos> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }




        private void CargarImagen(string Imagen)
        {
            try
            {
                // Verifica si la URL de la imagen no es nula ni está vacía
                if (!string.IsNullOrEmpty(Imagen))
                {
                    pbxArticulos.SizeMode = PictureBoxSizeMode.Zoom;
                    pbxArticulos.Load(Imagen);  // Cargar la imagen si está disponible
                }
                else
                {
      
                    pbxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
                }
            }
            catch (Exception ex)
            { 
                pbxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
            }
        }






        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void buttonEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;


            try
            {
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.IdArticulo);
                MessageBox.Show("Eliminando el item " + seleccionado.IdArticulo);

            }
            catch (Exception ex) { }
        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
                ArticulosNegocio negocio = new ArticulosNegocio();
                dgvArticulos.DataSource = negocio.listar(); 


        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;


                if (seleccionado.imagen != null && !string.IsNullOrEmpty(seleccionado.imagen.Url))
                {
                    CargarImagen(seleccionado.imagen.Url);  
                }
                else
                {

                    CargarImagen(null);
                }
            }
        }



        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string opcion = cbxCampo.SelectedItem.ToString();

                
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void Cargar()
        {
            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecciona un campo para poder filtrar");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un criterio para poder filtrar");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe cargar el filtro para numericos");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Debe cargar el filtro solo por un campo numericos");
                    return true;
                }
            }
            return false;
        }
        
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;


            if (listaArticulos != null && listaArticulos.Count > 0) 
            {
                List<Articulos> listaFiltrada;

                if (filtro.Length >= 2)
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.Contains(filtro));
                }
                else
                {
                    listaFiltrada = listaArticulos;
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                dgvArticulos.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);
                
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frmCategoria alta = new frmCategoria();
            alta.ShowDialog();
        }

        private void btn_GestionarMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas alta = new frmMarcas();
            alta.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
         
                if (dgvArticulos.SelectedRows.Count > 0)
                {

                DataGridViewRow row = dgvArticulos.SelectedRows[0];

                    Detalle detallesForm = new Detalle();

                 
                    detallesForm.CodigoArticulo = row.Cells["Codigo"].Value.ToString();
                    detallesForm.NombreArticulo = row.Cells["Nombre"].Value.ToString();
                    detallesForm.DescripcionArticulo = row.Cells["Descripcion"].Value.ToString();
                    detallesForm.PrecioArticulo = row.Cells["precio"].Value.ToString();
                    detallesForm.CategoriaArticulo = row.Cells["categoria"].Value.ToString();
                    detallesForm.MarcaArticulo = row.Cells["marcas"].Value.ToString();


             
                detallesForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un artículo para ver los detalles.");
                }
            }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgvArticulos.DataSource = negocio.listar();

        }
    }
    }
