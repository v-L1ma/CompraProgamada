using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class RebalanceamentoConfiguration : IEntityTypeConfiguration<Rebalanceamento>
{
    public void Configure(EntityTypeBuilder<Rebalanceamento> builder)
    {
        builder.ToTable("TB_REBALANCEAMENTOS");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_REBALANCEAMENTO")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ClienteId)
            .HasColumnName("CLIENTE_ID")
            .IsRequired();

        builder.Property(c => c.Tipo)
            .HasColumnName("TIPO")
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.TickerVendido)
            .HasColumnName("TICKER_VENDIDO")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.TickerComprado)
            .HasColumnName("TICKER_COMPRADO")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.ValorVenda)
            .HasColumnName("VALOR_VENDA")
            .HasColumnType("DECIMAL(18,2)")
            .IsRequired();

        builder.Property(c => c.DataRebalanceamento)
            .HasColumnName("DATA_REBALANCEAMENTO")
            .HasColumnType("datetime(6)")
            .IsRequired();
    }
}
