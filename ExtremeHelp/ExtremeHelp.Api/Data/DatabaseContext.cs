using Microsoft.EntityFrameworkCore;
using ExtremeHelp.Api.Models;

namespace ExtremeHelp.Api.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<DicaCategoria> DicaCategorias { get; set; }
        public DbSet<DicaPreparacao> DicaPreparacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DicaCategoria>()
                .HasMany(c => c.Dicas)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.DicaCategoriaId);
        }
    }
}