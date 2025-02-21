namespace Back.Dominio
{
    public interface IPrestamo
    {
        Task<Prestamo> SolicitarPrestamo(int usuarioId, decimal monto);
        Task<Prestamo> AprobarPrestamo(int prestamoId, int usuarioAdminId);
        Task<Prestamo> RechazarPrestamo(int prestamoId, int usuarioAdminId);
        Task<Prestamo> ObtenerEstadoPrestamo(int prestamoId);
        Task<List<Prestamo>> ObtenerPrestamosUsuario(int usuarioId);
    }
}
