using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class Rebalanceamento
{
    public long Id { get; set; }
    public long ClienteId { get; set; }
    public TipoRebalanceamento Tipo { get; set; }
    public string TickerVendido { get; set; } = string.Empty;
    public string TickerComprado { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal ValorVenda { get; set; }
    public DateTime DataRebalanceamento { get; set; }
}