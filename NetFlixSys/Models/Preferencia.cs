namespace NetFlixSys.Models
{
    public class Preferencia
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Genero { get; set; } = string.Empty;

        public Usuario Usuario { get; set; }
    }
}