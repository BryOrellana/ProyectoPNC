using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.listar();
        }

        public static string Insertar(string usuario, string contrasenia, int edad, string telefono, int idrol, string estado)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();
            Obj.usuario = usuario;
            Obj.contrasenia = contrasenia;
            Obj.edad = edad;
            Obj.telefono = telefono;
            Obj.idrol = idrol;
            Obj.estado = estado;

            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int idUsuario, string usuario, string contrasenia, int edad, string telefono, int idrol, string estado)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();
            Obj.idusuario = idUsuario; 
            Obj.usuario = usuario;
            Obj.contrasenia = contrasenia;
            Obj.edad = edad;
            Obj.telefono = telefono;
            Obj.idrol = idrol;
            Obj.estado = estado;

            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DUsuario Datos = new DUsuario();

            return Datos.Eliminar(id);
        }
    }
}
