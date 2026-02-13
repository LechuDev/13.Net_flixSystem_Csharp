using System.Collections.Generic;

namespace NetFlixSys.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<Preferencia> Preferencias { get; set; } = new();
    }
}