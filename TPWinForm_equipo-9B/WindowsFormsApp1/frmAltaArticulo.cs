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
    }
}
