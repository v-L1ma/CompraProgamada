using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class DistribuicaoConfiguration : IEntityTypeConfiguration<Distribuicao>
{
    public void Configure(EntityTypeBuilder<Distribuicao> builder)
    {
        builder.ToTable("TB_DISTRIBUICOES");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_DISTRIBUICAO")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.OrdemCompraId)
            .HasColumnName("ORDEM_COMPRA_ID")
            .IsRequired();

        builder.Property(c => c.CustodiaFilhoteId)
            .HasColumnName("CUSTODIA_FILHOTE_ID")
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

            builder.Property(c => c.DataDistribuicao)
                .HasColumnName("DATA_DISTRIBUICAO")
                .HasColumnType("datetime(6)")
                .IsRequired();
            
        // Assuming DataAtualizacao mapped safely if it exists or fallback
    }
}
