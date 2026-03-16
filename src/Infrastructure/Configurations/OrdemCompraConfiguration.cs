using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class OrdemCompraConfiguration : IEntityTypeConfiguration<OrdemCompra>
{
    public void Configure(EntityTypeBuilder<OrdemCompra> builder)
    {
        builder.ToTable("TB_ORDENS_COMPRA");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_ORDEM_COMPRA")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ContaMasterId)
            .HasColumnName("CONTA_MASTER_ID")
            .IsRequired();

        builder.Property(c => c.Ticker)
            .HasColumnName("TICKER")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.Quantidade)
            .HasColumnName("QUANTIDADE")
            .IsRequired();

        builder.Property(c => c.PrecoUnitario)
            .HasColumnName("PRECO_UNITARIO")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();

        builder.Property(c => c.TipoMercado)
            .HasColumnName("TIPO_MERCADO")
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.DataExecucao)
            .HasColumnName("DATA_EXECUCAO")
            .HasColumnType("datetime(6)")
            .IsRequired();
    }
}
