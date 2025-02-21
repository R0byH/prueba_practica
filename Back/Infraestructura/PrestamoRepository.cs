using Back.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Back.Infraestructura
{
    public class PrestamoRepository : IPrestamoRepository
    {
        private readonly BancoDbContext _context;

        public PrestamoRepository(BancoDbContext context)
        {
            _context = context;
        }

        public async Task<Prestamo> ObtenerPrestamoPorId(int id)
        {
            return await _context.Prestamos.FindAsync(id);
        }

        public async Task<List<Prestamo>> ObtenerPrestamosPorUsuario(int usuarioId)
        {
            return await _context.Prestamos.Where(p => p.UsuarioId == usuarioId).ToListAsync();
        }

        public async Task<Prestamo> CrearPrestamo(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }

        public async Task<Prestamo> ActualizarPrestamo(Prestamo prestamo)
        {
            _context.Prestamos.Update(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }
    }
}
