using Microsoft.EntityFrameworkCore;

namespace CompraProgamada.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets
        // TODO: Adicionar seus DbSets aqui
        // public DbSet<YourEntity> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // TODO: Configurar suas entidades aqui
        }
    }
}
