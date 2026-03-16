using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class OrdemCompra
{
    public long Id { get; set; }
    public long ContaMasterId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public TipoMercado TipoMercado { get; set; }
    public DateTime DataExecucao { get; set; }
}