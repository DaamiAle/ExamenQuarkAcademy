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
            modelBuilder.Entity<VendedorModel>().ToTable("Vendedores");
            modelBuilder.Entity<VendedorModel>(entitiy =>
            {
                entitiy.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
