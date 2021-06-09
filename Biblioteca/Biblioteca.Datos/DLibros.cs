using System;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;


namespace Biblioteca.Datos
{
    public class DLibros
    {
        public DataTable listar()
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_LIBROS", con);
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
                SqlCommand Comando = new SqlCommand("BUSCAR_LIBRO", con);
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

        public string Insertar(Libros Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_LIBRO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.num_ejemplares;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.ISBN;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.num_paginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el libro";
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

        public string Actualizar(Libros Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_LIBRO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_libro", SqlDbType.Int).Value = Obj.codigo_libro;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.num_ejemplares;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.ISBN;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.VarChar).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.num_paginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el libro";
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
                SqlCommand Comando = new SqlCommand("ELIMINAR_LIBRO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_libro", SqlDbType.Int).Value = id;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar libro";
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
