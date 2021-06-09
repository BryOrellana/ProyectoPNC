using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NPrestamo
    {
        public static DataTable Listar()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.listar();
        }

        public static DataTable LISTAR_PRESTAMOS_USUARIO(string usuario)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.LISTAR_PRESTAMOS_USUARIO(usuario);
        }

        public static string Insertar(int idUsuario, string titulo, int codigo_libro, int codigo_video, string fecha_prestamo, string fecha_limite_dev, string fecha_devolucion, string estado, string tipo)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.idUsuario = idUsuario;
            Obj.titulo = titulo;
            Obj.codigo_libro = codigo_libro;
            Obj.codigo_video = codigo_video;
            Obj.fecha_prestamo = fecha_prestamo;
            Obj.fecha_limite_dev = fecha_limite_dev;
            Obj.fecha_devolucion = fecha_devolucion;
            Obj.estado = estado;
            Obj.tipo = tipo;

            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int idPrestamo, string fecha_limite_dev, string fecha_devolucion,string estado)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.idPrestamo = idPrestamo;
            Obj.fecha_limite_dev = fecha_limite_dev;
            Obj.fecha_devolucion = fecha_devolucion;
            Obj.estado = estado;


            return Datos.Actualizar(Obj);
        }

    }
}
