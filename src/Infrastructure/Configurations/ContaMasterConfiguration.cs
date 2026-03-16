using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class ContaMasterConfiguration : IEntityTypeConfiguration<ContaMaster>
{
    public void Configure(EntityTypeBuilder<ContaMaster> builder)
    {
        builder.ToTable("TB_CONTAS_MASTER");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_CONTA_MASTER")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Nome)
            .HasColumnName("NOME")
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(c => c.Descricao)
            .HasColumnName("DESCRICAO")
            .HasColumnType("VARCHAR(500)");

        builder.Property(c => c.Preco)
            .HasColumnName("PRECO")
            .HasColumnType("DECIMAL(18,2)")
            .IsRequired();

        builder.Property(c => c.Quantidade)
            .HasColumnName("QUANTIDADE")
            .IsRequired();

        builder.Property(c => c.DataCriacao)
            .HasColumnName("DATA_CRIACAO")
            .HasColumnType("datetime(6)")
            .IsRequired();

        builder.Property(c => c.DataAtualizacao)
            .HasColumnName("DATA_ATUALIZACAO")
            .HasColumnType("datetime(6)")
            .IsRequired();
    }
}
