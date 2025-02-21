namespace Back.Dominio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; } // "pendiente", "aprobado", "rechazado"
        public Usuario Usuario { get; set; } 
    }
}
