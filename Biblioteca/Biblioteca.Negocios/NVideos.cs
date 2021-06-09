using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    class NVideos
    {

        public static DataTable Listar()
        {
            DVideos Datos = new DVideos();
            return Datos.listar();
        }

        public static DataTable Buscar(string criterio)
        {
            DVideos Datos = new DVideos();
            return Datos.Buscar(criterio);
        }

        public static string Insertar(string titulo, string director, string ISBN, string productora, string tipo, string anio, string duracion, string pais, string idiomas, string subtitulos, string clasificacion, string genero, string ubicacion, string sinopsis)
        {
            DVideos Datos = new DVideos();
            Videos Obj = new Videos();
            Obj.titulo = titulo;
            Obj.director = director;
            Obj.ISBN = ISBN;
            Obj.productora = productora;
            Obj.tipo = tipo;
            Obj.anio = anio;
            Obj.duracion = duracion;
            Obj.pais = pais;
            Obj.idiomas = idiomas;
            Obj.subtitulos = subtitulos;
            Obj.clasificacion = clasificacion;
            Obj.genero = genero;
            Obj.ubicacion = ubicacion;
            Obj.sinopsis = sinopsis;

            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int codigo_video ,string titulo, string director, string ISBN, string productora, string tipo, string anio, string duracion, string pais, string idiomas, string subtitulos, string clasificacion, string genero, string ubicacion, string sinopsis)
        {
            DVideos Datos = new DVideos();
            Videos Obj = new Videos();
            Obj.codigo_video = codigo_video;
            Obj.titulo = titulo;
            Obj.director = director;
            Obj.ISBN = ISBN;
            Obj.productora = productora;
            Obj.tipo = tipo;
            Obj.anio = anio;
            Obj.duracion = duracion;
            Obj.pais = pais;
            Obj.idiomas = idiomas;
            Obj.subtitulos = subtitulos;
            Obj.clasificacion = clasificacion;
            Obj.genero = genero;
            Obj.ubicacion = ubicacion;
            Obj.sinopsis = sinopsis;

            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DVideos Datos = new DVideos();

            return Datos.Eliminar(id);
        }

    }
}
