using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NRol
    {
        public static DataTable Listar()
        {
            DRol Datos = new DRol();
            return Datos.listar();
        }

        public static string Insertar(string nombre, string descripcion)
        {
            DRol Datos = new DRol();
            Rol Obj = new Rol();
            Obj.nombreRol = nombre;
            Obj.descripcion = descripcion;

            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int id, string nombre, string descripcion)
        {
            DRol Datos = new DRol();
            Rol Obj = new Rol();
            Obj.idRol = id;
            Obj.nombreRol = nombre;
            Obj.descripcion = descripcion;

            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DRol Datos = new DRol();

            return Datos.Eliminar(id);
        }

    }
}
