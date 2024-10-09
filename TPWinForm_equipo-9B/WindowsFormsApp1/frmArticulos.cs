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
                pbxArticulos.Load(Imagen);
            }
            catch(Exception ex)
            {
                pbxArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
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

       /* private void eliminar()
        {
            Articulos seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Queres eliminar el articulo?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

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
                CargarImagen(seleccionado.imagen.Url);
                
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedIndex.ToString();
            if (opcion == "Numero")
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
            List<Articulos> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            
        }
    }
}
