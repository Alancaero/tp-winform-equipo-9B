using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca, a.IdCategoria, a.Precio, i.ImagenUrl, m.Descripcion AS NombreMarca, c.Descripcion AS NombreCategoria " +
                                     "FROM ARTICULOS a " +
                                     "LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo " +         
                                     "LEFT JOIN MARCAS m ON a.IdMarca = m.Id " +
                                     "LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : "Descripción no disponible";
                    aux.precio = (decimal)datos.Lector["Precio"];

                    aux.marcas = new Marcas
                    {
                        IdMarca = datos.Lector["IdMarca"] != DBNull.Value ? (int)datos.Lector["IdMarca"] : 0,
                        Nombre = datos.Lector["NombreMarca"] != DBNull.Value ? (string)datos.Lector["NombreMarca"] : "Marca desconocida"
                    };

                    aux.categoria = new Categoria
                    {
                        IdCategoria = datos.Lector["IdCategoria"] != DBNull.Value ? (int)datos.Lector["IdCategoria"] : 0,
                        Nombre = datos.Lector["NombreCategoria"] != DBNull.Value ? (string)datos.Lector["NombreCategoria"] : "Categoría desconocida"
                    };

                    aux.imagen = new Imagen();
                    aux.imagen.Url = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : null;

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria)");
                
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.precio);

                datos.setearParametro("@IdMarca", nuevo.marcas?.IdMarca ?? (object)DBNull.Value);
                datos.setearParametro("@IdCategoria", nuevo.categoria?.IdCategoria ?? (object)DBNull.Value);

                datos.ejecutarAccion();

                if (nuevo.imagen != null && !string.IsNullOrEmpty(nuevo.imagen.Url))
                {
                    int idArticulo = datos.getUltimoIdInsertado(); 

                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", idArticulo);
                    datos.setearParametro("@ImagenUrl", nuevo.imagen.Url);
                    datos.ejecutarAccion();
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
        }


        public void modificar(Articulos art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio " +
                                     "WHERE Id = @Id");

         
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Precio", art.precio);
                datos.setearParametro("@Id", art.IdArticulo);

                
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int IdArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
   
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", IdArticulo);

   
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public object Filtrar(string campo,string criterio,string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            bool existe = false;

            try
            {

                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE Codigo = @Codigo");
                datos.setearParametro("@Codigo", codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
         
                    existe = datos.Lector.GetInt32(0) > 0;
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