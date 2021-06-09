using System;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DVideos
    {
        public DataTable listar()
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_VIDEOS", con);
                Comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                result = Comando.ExecuteReader();
                Tabla.Load(result);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public DataTable Buscar(string criterio)
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("BUSCAR_VIDEO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@criterio", SqlDbType.VarChar).Value = criterio;
                con.Open();
                result = Comando.ExecuteReader();
                Tabla.Load(result);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public string Insertar(Videos Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_VIDEO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.ISBN;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.tipo;
                Comando.Parameters.Add("@anio", SqlDbType.VarChar).Value = Obj.anio;
                Comando.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.duracion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idiomas", SqlDbType.VarChar).Value = Obj.idiomas;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.clasificacion;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.genero;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;
                

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el video";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return Rpta;
        }

        public string Actualizar(Videos Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_VIDEO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_video", SqlDbType.Int).Value = Obj.codigo_video;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.director;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.ISBN;
                Comando.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.productora;
                Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.tipo;
                Comando.Parameters.Add("@anio", SqlDbType.VarChar).Value = Obj.anio;
                Comando.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.duracion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idiomas", SqlDbType.VarChar).Value = Obj.idiomas;
                Comando.Parameters.Add("@subtitulos", SqlDbType.VarChar).Value = Obj.subtitulos;
                Comando.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.clasificacion;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.genero;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.sinopsis;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el video";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return Rpta;
        }

        public string Eliminar(int id)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ELIMINAR_VIDEO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_video", SqlDbType.Int).Value = id;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el video";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return Rpta;
        }
    }
}
