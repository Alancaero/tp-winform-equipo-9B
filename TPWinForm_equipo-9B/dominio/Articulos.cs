using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public decimal precio { get; set; }
        
        /*CREAR LAS SIGUIENTES CLASES
        Class Marcas
        Class Imagen
        Class Categoria

        PARA LUEGO APLICAR public Categoria categoria {get; set;}, asi tambien con imagen y categoria

        Todo esto comentado anteriormente en dominio la creación de estas tres clases
        */

    }
}
