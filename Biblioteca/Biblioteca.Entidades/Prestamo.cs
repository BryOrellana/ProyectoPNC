namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        public int idPrestamo { get; set; }
        public int idUsuario { get; set; }
        public string titulo { get; set; }
        public int codigo_libro { get; set; }
        public int codigo_video { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_limite_dev { get; set; }
        public string fecha_devolucion { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
    }
}
