using System.Numerics;

namespace CompraProgamada.Domain.Entities;

public class ItenCesta
{
    public BigInteger Id { get; set; }
    public BigInteger CestaRecomendacaoId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public decimal Percentual { get; set; }
}