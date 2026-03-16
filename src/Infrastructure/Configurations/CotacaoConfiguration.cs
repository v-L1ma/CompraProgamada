using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class CotacaoConfiguration : IEntityTypeConfiguration<Cotacao>
{
    public void Configure(EntityTypeBuilder<Cotacao> builder)
    {
        builder.ToTable("TB_COTACOES");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_COTACAO")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.DataPregao)
            .HasColumnName("DATA_PREGAO")
            .HasColumnType("DATE")
            .IsRequired();

        builder.Property(c => c.Ticker)
            .HasColumnName("TICKER")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.PrecoAbertura)
            .HasColumnName("PRECO_ABERTURA")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();

        builder.Property(c => c.PrecoFechamento)
            .HasColumnName("PRECO_FECHAMENTO")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();

        builder.Property(c => c.PrecoMaximo)
            .HasColumnName("PRECO_MAXIMO")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();

        builder.Property(c => c.PrecoMinimo)
            .HasColumnName("PRECO_MINIMO")
            .HasColumnType("DECIMAL(18,4)")
            .IsRequired();
    }
}
