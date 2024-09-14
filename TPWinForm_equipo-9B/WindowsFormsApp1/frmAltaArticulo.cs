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

       



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

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
    }
}
