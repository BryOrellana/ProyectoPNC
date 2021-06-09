using System;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DRol
    {
        public DataTable listar()
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_ROL", con);
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
                if(con.State == ConnectionState.Open) con.Close();
            }

        }

        public string Insertar(Rol Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_ROL", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombreRol", SqlDbType.VarChar).Value = Obj.nombreRol;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar rol";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if(con.State == ConnectionState.Open) con.Close();
            }

            return Rpta;
        }

        public string Actualizar(Rol Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_ROL", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idRol", SqlDbType.Int).Value = Obj.idRol;
                Comando.Parameters.Add("@nombreRol", SqlDbType.VarChar).Value = Obj.nombreRol;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar rol";
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
                SqlCommand Comando = new SqlCommand("ELIMINAR_ROL", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idRol", SqlDbType.Int).Value = id;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar rol";
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
