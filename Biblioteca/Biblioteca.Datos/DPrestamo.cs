using System;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DPrestamo
    {
        public DataTable listar()
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_PRESTAMOS", con);
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

        public DataTable LISTAR_PRESTAMOS_USUARIO(string usuario)
        {
            SqlDataReader result;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("LISTAR_PRESTAMOS_USUARIO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
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
        
        public string Insertar(Prestamo Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("INSERTAR_NUEVO_PRESTAMO", con);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = Obj.idUsuario;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@codigo_libro", SqlDbType.Int).Value = Obj.codigo_libro;
                Comando.Parameters.Add("@codigo_video", SqlDbType.Int).Value = Obj.codigo_video;
                Comando.Parameters.Add("@fecha_prestamo", SqlDbType.VarChar).Value = Obj.fecha_prestamo;
                Comando.Parameters.Add("@fecha_limite_dev", SqlDbType.VarChar).Value = Obj.fecha_limite_dev;
                Comando.Parameters.Add("@fecha_devolucion", SqlDbType.VarChar).Value = Obj.fecha_devolucion;
                Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.estado;
                Comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Obj.tipo;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el prestamo";
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

        public string Actualizar(Prestamo Obj)
        {
            string Rpta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ACTUALIZAR_PRESTAMO", con);
                Comando.CommandType = CommandType.StoredProcedure; 
                Comando.Parameters.Add("@idPrestamo", SqlDbType.Int).Value = Obj.idPrestamo;
                Comando.Parameters.Add("@fecha_limite_dev", SqlDbType.VarChar).Value = Obj.fecha_limite_dev;
                Comando.Parameters.Add("@fecha_devolucion", SqlDbType.VarChar).Value = Obj.fecha_devolucion;
                Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Obj.estado;

                con.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el prestamo";
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
