using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id,Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values (@nombre)");
                datos.setearParametro("@nombre", nuevo.Nombre);
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

        public void Modificar(Categoria modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE CATEGORIAS set Descripcion = @nombre where Id=@id");
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@id", modificar.IdCategoria);

                datos.ejecutarAccion();
            }
            catch(Exception ex){
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public bool ExisteCategoria(string nombreCategoria, int? idCategoria = null)
        {
            AccesoDatos datos = new AccesoDatos();
            bool existe = false;

            try
            {
                
                string consulta = "SELECT COUNT(*) FROM CATEGORIAS WHERE Descripcion = @nombre";

                if (idCategoria != null)
                {
                    consulta += " AND Id <> @id"; // Excluir la categoría actual si es una modificación
                    datos.setearParametro("@id", idCategoria);
                }

                datos.setearConsulta(consulta);
                datos.setearParametro("@nombre", nombreCategoria);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    existe = datos.Lector.GetInt32(0) > 0; // Si COUNT(*) > 0, la categoría ya existe
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

            return existe;
        }





    }
}
