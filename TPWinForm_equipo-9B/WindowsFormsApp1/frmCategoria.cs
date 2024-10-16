using dominio;
using negocio;
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }


        private void CargarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> listaCategorias = categoriaNegocio.listar();

            dgvCategoria.DataSource = listaCategorias;
        }


        private void button1_Click(object sender, EventArgs e)
        {
 
                frmAltaCategoria alta = new frmAltaCategoria();
                alta.ShowDialog();
                CargarCategorias();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategoria.DataSource = negocio.listar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

            frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
            modificar.ShowDialog();
            CargarCategorias();
        }
    }
}
