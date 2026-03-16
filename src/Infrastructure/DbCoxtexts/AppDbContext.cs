using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompraProgamada.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CestaRecomendacao> CestaRecomendacoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ContaGrafica> ContasGraficas { get; set; }
        public DbSet<ContaMaster> ContasMaster { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<Custodia> Custodias { get; set; }
        public DbSet<Distribuicao> Distribuicoes { get; set; }
        public DbSet<EventosIR> EventosIRs { get; set; }
        public DbSet<ItemCesta> ItensCesta { get; set; }
        public DbSet<OrdemCompra> OrdensCompra { get; set; }
        public DbSet<Rebalanceamento> Rebalanceamentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
