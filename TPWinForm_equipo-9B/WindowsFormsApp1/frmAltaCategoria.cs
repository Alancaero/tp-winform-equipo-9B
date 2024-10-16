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
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null; 

        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria; 

     
            txtNombreCategoria.Text = categoria.Nombre;
        }

        private void btn_AceptarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción para la categoría.");
                return;
            }

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                {
     
                    Categoria nuevaCategoria = new Categoria();
                    nuevaCategoria.Nombre = txtNombreCategoria.Text;
                    categoriaNegocio.Agregar(nuevaCategoria);
                    MessageBox.Show("Categoría agregada con éxito.");
                }
                else
                {
                    categoria.Nombre = txtNombreCategoria.Text;
                    categoriaNegocio.Modificar(categoria);
                    MessageBox.Show("Categoría modificada con éxito.");
                }

                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la categoría: " + ex.Message);
            }
        }
    }
}
