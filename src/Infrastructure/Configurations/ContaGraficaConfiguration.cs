using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class ContaGraficaConfiguration : IEntityTypeConfiguration<ContaGrafica>
{
    public void Configure(EntityTypeBuilder<ContaGrafica> builder)
    {
        builder.ToTable("TB_CONTAS_GRAFICAS");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_CONTA_GRAFICA")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ClienteId)
            .HasColumnName("CLIENTE_ID")
            .IsRequired();

        builder.Property(c => c.NumeroConta)
            .HasColumnName("NUMERO_CONTA")
            .HasColumnType("VARCHAR(20)")
            .IsRequired();

        builder.HasIndex(c => c.NumeroConta).IsUnique();

        builder.Property(c => c.Tipo)
            .HasColumnName("TIPO")
            .HasConversion<string>()
            .IsRequired();

            builder.Property(c => c.DataCriacao)
                .HasColumnName("DATA_CRIACAO")
                .HasColumnType("datetime(6)")
                .IsRequired();
    }
}
