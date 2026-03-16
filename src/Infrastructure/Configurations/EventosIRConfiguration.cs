using CompraProgamada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompraProgamada.Infrastructure.Configurations;

public class EventosIRConfiguration : IEntityTypeConfiguration<EventosIR>
{
    public void Configure(EntityTypeBuilder<EventosIR> builder)
    {
        builder.ToTable("TB_EVENTOS_IR");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("ID_EVENTO_IR")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.ClienteId)
            .HasColumnName("CLIENTE_ID")
            .IsRequired();

        builder.Property(c => c.TipoImposto)
            .HasColumnName("TIPO")
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.ValorBase)
            .HasColumnName("VALOR_BASE")
            .HasColumnType("DECIMAL(18,2)")
            .IsRequired();

        builder.Property(c => c.ValorImposto)
            .HasColumnName("VALOR_IR")
            .HasColumnType("DECIMAL(18,2)")
            .IsRequired();

        builder.Property(c => c.PublicadoKafka)
            .HasColumnName("PUBLICADO_KAFKA")
            .IsRequired();

        builder.Property(c => c.DataEvento)
            .HasColumnName("DATA_EVENTO")
            .HasColumnType("datetime(6)")
            .IsRequired();
    }
}
