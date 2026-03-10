using System.Numerics;

namespace CompraProgamada.Domain.Entities;

public class Custodia
{
    public BigInteger Id { get; set; }
    public BigInteger ContaGraficaId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoMedio { get; set; }
    public DateTime DataUltimaAtualizacao { get; set; }
}