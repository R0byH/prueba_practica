﻿namespace Back.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rol { get; set; } // "usuario" o "admin"
    }
}
