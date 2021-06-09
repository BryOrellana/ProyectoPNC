using System;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DUsuario
    {
        public DataTable listar()
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_USUARIO", con);
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

        public string Insertar(Usuario Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_NUEVO_USUARIO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.usuario;
                Comando.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = Obj.contrasenia;
                Comando.Parameters.Add("@edad", SqlDbType.Int).Value = Obj.edad;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.telefono;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.idrol;
                Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.estado;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo crear el usuario";
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

        public string Actualizar(Usuario Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_USUARIO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.idusuario;
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Obj.usuario;
                Comando.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = Obj.contrasenia;
                Comando.Parameters.Add("@edad", SqlDbType.Int).Value = Obj.edad;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.telefono;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.idrol;
                Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.estado;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar la informacion del usuario";
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
                SqlCommand Comando = new SqlCommand("ELIMINAR_USUARIO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el usuario";
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
