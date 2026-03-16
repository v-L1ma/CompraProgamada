using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class CustodiaConfiguration : IEntityTypeConfiguration<Custodia>
{
    public void Configure(EntityTypeBuilder<Custodia> builder)
    {
        builder.ToTable("TB_CUSTODIAS");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_CUSTODIA")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ContaGraficaId)
            .HasColumnName("CONTA_GRAFICA_ID")
            .IsRequired();

        builder.Property(c => c.Ticker)
            .HasColumnName("TICKER")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.Quantidade)
            .HasColumnName("QUANTIDADE")
            .IsRequired();

        builder.Property(c => c.PrecoMedio)
            .HasColumnName("PRECO_MEDIO")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();

            builder.Property(c => c.DataUltimaAtualizacao)
                .HasColumnName("DATA_ULTIMA_ATUALIZACAO")
                .HasColumnType("datetime(6)")
                .IsRequired();
    }
}
