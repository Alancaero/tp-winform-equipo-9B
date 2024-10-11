using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        private List<String> ListaImagen;

        public void Agregar(int id,string Url)
        {
            AccesoDatos datos = new AccesoDatos();
            Imagen img = new Imagen();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo,ImagenUrl) VALUES (@id,@Url)");
                datos.setearParametro("@id", id);
                datos.setearParametro("@Url", Url);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<String> ObtenerLista(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<String> listaImagenes = new List<String>();

            try
            {
                datos.setearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    listaImagenes.Add((string)datos.Lector["ImagenUrl"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }

            return listaImagenes;
        }
    }
}