using ExamenQuarkAcademy.src.app.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExamenQuarkAcademy.src.app
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            optionsBuider.UseSqlite(connectionString: "Filename=ExamenQuarkAcademy.db", sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuider);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiendaModel>().ToTable("Tiendas");
            modelBuilder.Entity<TiendaModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<VendedorModel>().ToTable("Vendedores");
            modelBuilder.Entity<VendedorModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<CotizacionModel>().ToTable("Cotizaciones");
            modelBuilder.Entity<CotizacionModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<PrendaModel>().ToTable("Prendas");
            modelBuilder.Entity<PrendaModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);             
            });
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<CotizacionModel> Cotizaciones { get; set; }
        public DbSet<VendedorModel> Vendedores { get; set; }
        public DbSet<PrendaModel> Prendas { get; set; }
        public DbSet<TiendaModel> Tiendas { get; set; }
        
    }
}
