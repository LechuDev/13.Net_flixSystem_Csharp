using Microsoft.EntityFrameworkCore;
using NetFlixSys.Models;

namespace NetFlixSys.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Preferencia> Preferencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Usuarios simulados
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Jorge", Email = "jorge@netflixsys.com" },
                new Usuario { Id = 2, Nombre = "Ana", Email = "ana@netflixsys.com" },
                new Usuario { Id = 3, Nombre = "Luis", Email = "luis@netflixsys.com" }
            );

            // Películas simuladas (20+ registros)
            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula { Id = 1, Titulo = "Matrix", Genero = "Sci-Fi", Año = 1999, Puntuacion = 9.0 },
                new Pelicula { Id = 2, Titulo = "Inception", Genero = "Sci-Fi", Año = 2010, Puntuacion = 8.8 },
                new Pelicula { Id = 3, Titulo = "Interstellar", Genero = "Sci-Fi", Año = 2014, Puntuacion = 8.6 },
                new Pelicula { Id = 4, Titulo = "The Dark Knight", Genero = "Acción", Año = 2008, Puntuacion = 9.1 },
                new Pelicula { Id = 5, Titulo = "Avengers: Endgame", Genero = "Acción", Año = 2019, Puntuacion = 8.4 },
                new Pelicula { Id = 6, Titulo = "Titanic", Genero = "Romance", Año = 1997, Puntuacion = 7.9 },
                new Pelicula { Id = 7, Titulo = "La La Land", Genero = "Musical", Año = 2016, Puntuacion = 8.0 },
                new Pelicula { Id = 8, Titulo = "Parasite", Genero = "Drama", Año = 2019, Puntuacion = 8.6 },
                new Pelicula { Id = 9, Titulo = "Joker", Genero = "Drama", Año = 2019, Puntuacion = 8.5 },
                new Pelicula { Id = 10, Titulo = "Toy Story", Genero = "Animación", Año = 1995, Puntuacion = 8.3 },
                new Pelicula { Id = 11, Titulo = "Finding Nemo", Genero = "Animación", Año = 2003, Puntuacion = 8.1 },
                new Pelicula { Id = 12, Titulo = "Shrek", Genero = "Animación", Año = 2001, Puntuacion = 7.9 },
                new Pelicula { Id = 13, Titulo = "Gladiator", Genero = "Acción", Año = 2000, Puntuacion = 8.5 },
                new Pelicula { Id = 14, Titulo = "The Godfather", Genero = "Drama", Año = 1972, Puntuacion = 9.2 },
                new Pelicula { Id = 15, Titulo = "Pulp Fiction", Genero = "Drama", Año = 1994, Puntuacion = 8.9 },
                new Pelicula { Id = 16, Titulo = "Forrest Gump", Genero = "Drama", Año = 1994, Puntuacion = 8.8 },
                new Pelicula { Id = 17, Titulo = "The Lion King", Genero = "Animación", Año = 1994, Puntuacion = 8.5 },
                new Pelicula { Id = 18, Titulo = "Frozen", Genero = "Animación", Año = 2013, Puntuacion = 7.5 },
                new Pelicula { Id = 19, Titulo = "Moana", Genero = "Animación", Año = 2016, Puntuacion = 7.6 },
                new Pelicula { Id = 20, Titulo = "Black Panther", Genero = "Acción", Año = 2018, Puntuacion = 7.3 }
            );

            // Preferencias simuladas
            modelBuilder.Entity<Preferencia>().HasData(
                new Preferencia { Id = 1, UsuarioId = 1, Genero = "Sci-Fi" },
                new Preferencia { Id = 2, UsuarioId = 1, Genero = "Acción" },
                new Preferencia { Id = 3, UsuarioId = 2, Genero = "Drama" },
                new Preferencia { Id = 4, UsuarioId = 2, Genero = "Romance" },
                new Preferencia { Id = 5, UsuarioId = 3, Genero = "Animación" }
            );
        }
    }
}