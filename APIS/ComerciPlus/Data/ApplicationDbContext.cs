//using ComerciPlus.Models;
//using Microsoft.EntityFrameworkCore;

using ComerciPlus.Models;

namespace ComerciPlus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){ }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
        public DbSet<proveedores> proveedores { get; set; }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<creditos> creditos { get; set; }
        public DbSet<usuarios> usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relación Clientes - Créditos
            modelBuilder.Entity<creditos>()
               .HasOne(c => c.Cliente)
               .WithMany() // o .WithOne() si cliente no tiene una colección de créditos
               .HasForeignKey(c => c.IdCliente)
               .IsRequired();

            modelBuilder.Entity<clientes>()
                .HasIndex(c => c.CedulaCliente)
                .IsUnique();
        }

    }

  
}