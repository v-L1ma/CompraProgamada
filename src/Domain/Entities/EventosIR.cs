using System.Numerics;
using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class EventosIR
{
    public BigInteger Id { get; set; }
    public BigInteger ClienteId { get; set; }
    public TipoImpostoRenda TipoImposto { get; set; }
    public decimal ValorBase { get; set; }
    public decimal ValorImposto { get; set; }
    public bool PublicadoKafka { get; set; }
    public DateTime DataEvento { get; set; }
}