namespace TallerDD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() {}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<Export> Export { get; set; }  

    }
}
