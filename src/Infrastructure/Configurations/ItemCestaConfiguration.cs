using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class ItemCestaConfiguration : IEntityTypeConfiguration<ItemCesta>
{
    public void Configure(EntityTypeBuilder<ItemCesta> builder)
    {
        builder.ToTable("TB_ITENS_CESTA");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_ITEM_CESTA")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.CestaRecomendacaoId)
            .HasColumnName("CESTA_ID")
            .IsRequired();

        builder.Property(c => c.Ticker)
            .HasColumnName("TICKER")
            .HasColumnType("VARCHAR(10)")
            .IsRequired();

        builder.Property(c => c.Percentual)
            .HasColumnName("PERCENTUAL")
            .HasColumnType("DECIMAL(5,2)")
            .IsRequired();
    }
}
