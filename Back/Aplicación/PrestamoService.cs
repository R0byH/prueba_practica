using Back.Dominio;

namespace Back.Aplicación
{
    public class PrestamoService
    {
        private readonly IPrestamoCasoUso _iprestamo;

        public async Task<Prestamo> SolicitarPrestamo(int usuarioId, decimal monto)
        {
            try
            {
                Prestamo prestamo = await _iprestamo.SolicitarPrestamo(usuarioId, monto);

                return prestamo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al solicitar préstamo: " + ex.Message);
                throw;
            }
        }

        public async Task<Prestamo> AprobarPrestamo(int prestamoId, int usuarioAdminId)
        {
            try
            {
                Prestamo prestamo = await _iprestamo.AprobarPrestamo(prestamoId, usuarioAdminId);

                return prestamo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al aprobar el préstamo: " + ex.Message);
                throw;
            }
        }
        public async Task<Prestamo> RechazarPrestamo(int prestamoId, int usuarioAdminId)
        {
            try
            {
                Prestamo prestamo = await _iprestamo.RechazarPrestamo(prestamoId, usuarioAdminId);

                return prestamo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al rechazar el préstamo: " + ex.Message);
                throw;
            }
        }
        public async Task<Prestamo> ObtenerEstadoPrestamo(int prestamoId)
        {
            try
            {
                Prestamo estadosPrestamo = await _iprestamo.ObtenerEstadoPrestamo(prestamoId);

                return estadosPrestamo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el estado del préstamo: " + ex.Message);
                throw;
            }
        }
        public async Task<List<Prestamo>> ObtenerPrestamosUsuario(int usuarioId)
        {
            try
            {
                List<Prestamo> estadosPrestamo = await _iprestamo.ObtenerPrestamosUsuario(usuarioId);

                return estadosPrestamo;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los prestamos: " + ex.Message);
                throw;
            }
        }

    }
}
