using Back.Infraestructura;

namespace Back.Dominio
{
    public class PrestamoCasoUso : IPrestamoCasoUso
    {
        private readonly IPrestamoRepository _prestamoRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public PrestamoCasoUso(IPrestamoRepository prestamoRepository, IUsuarioRepository usuarioRepository)
        {
            _prestamoRepository = prestamoRepository;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Prestamo> SolicitarPrestamo(int usuarioId, decimal monto)
        {
            if (monto <= 0 )
            {
                throw new ArgumentException("Monto debe ser mayor a cero.");
            }

            var usuario = await _usuarioRepository.GetById(usuarioId);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            var prestamo = new Prestamo
            {
                UsuarioId = usuarioId,
                Monto = monto,
                Estado = "pendiente",
            };

            var nuevoPrestamo = await _prestamoRepository.CrearPrestamo(prestamo);

            return nuevoPrestamo;
        }

        public async Task<Prestamo> AprobarPrestamo(int prestamoId, int usuarioAdminId)
        {

        }
        public async Task<Prestamo> RechazarPrestamo(int prestamoId, int usuarioAdminId)
        {

        }
        public async Task<Prestamo> ObtenerEstadoPrestamo(int prestamoId)
        {

        }

        public async Task<List<Prestamo>> ObtenerPrestamosUsuario(int usuarioId)
        {

        }

    }
}
