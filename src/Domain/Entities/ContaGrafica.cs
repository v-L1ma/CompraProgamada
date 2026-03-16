using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class ContaGrafica
{
    public long Id { get; set; }
    public long ClienteId { get; set; }
    public string NumeroConta { get; set; } = string.Empty;
    public TipoConta Tipo { get; set; }
    public DateTime DataCriacao { get; set; }
}