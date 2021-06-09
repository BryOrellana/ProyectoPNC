using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NLibros
    {
        public static DataTable Listar()
        {
            DLibros Datos = new DLibros();
            return Datos.listar();
        }

        public static DataTable Buscar(string criterio)
        {
            DLibros Datos = new DLibros();
            return Datos.Buscar(criterio);
        }

        public static string Insertar(int num_ejemplares,string ISBN, string titulo, string autor, string editorial, string anio_edicion, string pais, string idioma, string materia, int num_paginas, string ubicacion, string descripcion)
        {
            DLibros Datos = new DLibros();
            Libros Obj = new Libros();
            Obj.num_ejemplares = num_ejemplares;
            Obj.ISBN = ISBN;
            Obj.titulo = titulo;
            Obj.autor = autor;
            Obj.editorial = editorial;
            Obj.anio_edicion = anio_edicion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.materia = materia;
            Obj.num_paginas = num_paginas;
            Obj.ubicacion = ubicacion;
            Obj.descripcion = descripcion;

            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int codigo_libro, int num_ejemplares, string ISBN, string titulo, string autor, string editorial, string anio_edicion, string pais, string idioma, string materia, int num_paginas, string ubicacion, string descripcion)
        {
            DLibros Datos = new DLibros();
            Libros Obj = new Libros();
            Obj.codigo_libro = codigo_libro;
            Obj.num_ejemplares = num_ejemplares;
            Obj.ISBN = ISBN;
            Obj.titulo = titulo;
            Obj.autor = autor;
            Obj.editorial = editorial;
            Obj.anio_edicion = anio_edicion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.materia = materia;
            Obj.num_paginas = num_paginas;
            Obj.ubicacion = ubicacion;
            Obj.descripcion = descripcion;

            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id)
        {
            DLibros Datos = new DLibros();

            return Datos.Eliminar(id);
        }
    }
}
