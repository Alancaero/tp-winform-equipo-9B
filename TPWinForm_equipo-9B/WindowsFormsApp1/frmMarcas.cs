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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void CargarMarcas()
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            List<Marcas> listaMarcas = marcasNegocio.listar();

            dgvMarcas.DataSource = listaMarcas;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMarcas altaMarcas = new frmAltaMarcas();
            altaMarcas.ShowDialog();
            CargarMarcas();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            dgvMarcas.DataSource=negocio.listar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Marcas seleccionado;
            seleccionado = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;

            frmAltaMarcas modificar = new frmAltaMarcas(seleccionado);
            modificar.ShowDialog();
            CargarMarcas();
        }
    }
}
