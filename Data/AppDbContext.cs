using Microsoft.EntityFrameworkCore;
using GamesKorn.Components.Models;

namespace GamesKorn.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductoModelo> Productos { get; set; }
        public DbSet<CategoriaModelo> Categorias { get; set; }
        public DbSet<SubCategoriaModelo> SubCategorias { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación Categoria -> SubCategoria
            modelBuilder.Entity<SubCategoriaModelo>()
                .HasOne(s => s.Categoria)
                .WithMany(c => c.SubCategorias)
                .HasForeignKey(s => s.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación SubCategoria -> Producto
            modelBuilder.Entity<ProductoModelo>()
                .HasOne(p => p.SubCategoria)
                .WithMany(s => s.Productos)
                .HasForeignKey(p => p.SubCategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}