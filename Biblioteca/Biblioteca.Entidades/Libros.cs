namespace Biblioteca.Entidades
{
    public class Libros
    {
        public int codigo_libro { get; set; }
        public int num_ejemplares { get; set; }
        public string ISBN { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string anio_edicion { get; set; }
        public string pais { get; set; }
        public string idioma { get; set; }
        public string materia { get; set; }
        public int num_paginas { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
    }
}
