using Microsoft.EntityFrameworkCore;
using API_MVC.Models;


namespace API_MVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){ }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

    }

  
}