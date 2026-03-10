using System.Numerics;
using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class OrdemCompra
{
    public BigInteger Id { get; set; }
    public BigInteger ContaMasterId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public TipoMercado TipoMercado { get; set; }
    public DateTime DataExecucao { get; set; }
}