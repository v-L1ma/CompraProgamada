using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class CestaRecomendacaoConfiguration : IEntityTypeConfiguration<CestaRecomendacao>
{
    public void Configure(EntityTypeBuilder<CestaRecomendacao> builder)
    {
        builder.ToTable("TB_CESTA_RECOMENDACAO");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_CESTA_RECOMENDACAO")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Nome)
            .HasColumnName("NOME")
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(c => c.Ativa)
            .HasColumnName("ATIVO")
            .IsRequired();

        builder.Property(c => c.DataCriacao)
            .HasColumnName("DATA_CRIACAO")
            .HasColumnType("datetime(6)")
            .IsRequired();

        builder.Property(c => c.DataDesativacao)
            .HasColumnName("DATA_DESATIVACAO")
            .HasColumnType("datetime(6)");
    }
}
