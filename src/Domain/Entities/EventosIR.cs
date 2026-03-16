using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class EventosIR
{
    public long Id { get; set; }
    public long ClienteId { get; set; }
    public TipoImpostoRenda TipoImposto { get; set; }
    public decimal ValorBase { get; set; }
    public decimal ValorImposto { get; set; }
    public bool PublicadoKafka { get; set; }
    public DateTime DataEvento { get; set; }
}