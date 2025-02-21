using Back.Dominio;

namespace Back.Infraestructura
{
    public interface IPrestamoRepository
    {
        Task<Prestamo> ObtenerPrestamoPorId(int id);
        Task<List<Prestamo>> ObtenerPrestamosPorUsuario(int usuarioId);
        Task<Prestamo> CrearPrestamo(Prestamo prestamo);
        Task<Prestamo> ActualizarPrestamo(Prestamo prestamo);
    }
}
