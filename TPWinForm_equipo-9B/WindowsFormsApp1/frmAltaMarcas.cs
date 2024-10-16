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
    public partial class frmAltaMarcas : Form
    {
        private Marcas marcas = null;
        
        public frmAltaMarcas()
        {
            InitializeComponent();
        }

        public frmAltaMarcas(Marcas marcas)
        {
            InitializeComponent();
            this.marcas = marcas;

            txtNombreMarcas.Text = marcas.Nombre;
        }

        private void btn_AceptarMarcas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMarcas.Text))
            {
                MessageBox.Show("Por favor, ingresar una descripcion para la marca..");
                return;
            }

            MarcasNegocio marcasNegocio = new MarcasNegocio();

            try
            {
                if (marcas == null)
                {
                    Marcas nuevaMarca = new Marcas();
                    nuevaMarca.Nombre = txtNombreMarcas.Text;
                    marcasNegocio.Agregar(nuevaMarca);
                    MessageBox.Show("Marca agrupada fue agregada con éxito");
                }
                else
                {
                    marcas.Nombre = txtNombreMarcas.Text;
                    marcasNegocio.Modificar(marcas);
                    MessageBox.Show("Marca fue modificada con éxito");
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la marca");
            }
        }
    }
}
