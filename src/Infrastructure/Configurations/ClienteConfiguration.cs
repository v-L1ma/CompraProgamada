using CompraProgamada.Domain.Entities;
using CompraProgamada.Domain.Entities.ClienteEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("TB_CLIENTES");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_CLIENTE")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.Nome)
            .HasColumnName("NOME")
            .HasColumnType("VARCHAR(200)")
            .IsRequired();

        builder.Property(c => c.CPF)
            .HasColumnName("CPF")
            .HasColumnType("VARCHAR(11)")
            .IsRequired();

        builder.HasIndex(c => c.CPF).IsUnique();

        builder.Property(c => c.Email)
            .HasColumnName("EMAIL")
            .HasColumnType("VARCHAR(200)");

        builder.Property(c => c.ValorMensal)
            .HasColumnName("VALOR_MENSAL")
            .HasColumnType("DECIMAL(18,2)");

        builder.Property(c => c.Ativo)
            .HasColumnName("ATIVO")
            .HasDefaultValue(true);

        builder.Property(c => c.DataAdesao)
            .HasColumnName("DATA_ADESAO")
            .HasColumnType("datetime(6)");
    }
}
