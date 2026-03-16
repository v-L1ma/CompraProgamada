namespace CompraProgamada.Domain.Entities;

public class ItemCesta
{
    public long Id { get; set; }
    public long CestaRecomendacaoId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public decimal Percentual { get; set; }
}