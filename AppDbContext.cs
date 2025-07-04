using Microsoft.EntityFrameworkCore;
using AREASYVOLUMENES.Models;

namespace AREASYVOLUMENES
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cuadrado> Cuadrados { get; set; }
        public DbSet<Rectangulo> Rectangulos { get; set; }
        public DbSet<Circulo> Circulos { get; set; }
        public DbSet<Cubo> Cubos { get; set; }
        public DbSet<Esfera> Esferas { get; set; }
        public DbSet<Cilindro> Cilindros { get; set; }
    }
} 