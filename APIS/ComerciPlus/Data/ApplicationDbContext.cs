namespace ComerciPlus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){ }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Credito> Credito { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relación Clientes - Créditos
            modelBuilder.Entity<Credito>()
               .HasOne(c => c.Cliente)
               .WithMany() 
               .HasForeignKey(c => c.IdCliente)
               .IsRequired();

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.CedulaCliente)
                .IsUnique();
        }

    }

  
}