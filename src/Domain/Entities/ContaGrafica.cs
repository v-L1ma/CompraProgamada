using System.Numerics;
using CompraProgamada.Domain.Enums;

namespace CompraProgamada.Domain.Entities;

public class ContaGraficaFilhote
{
    public BigInteger Id { get; set; }
    public BigInteger ClienteId { get; set; }
    public string NumeroConta { get; set; } = string.Empty;
    public TipoConta Tipo { get; set; }
    public DateTime DataCriacao { get; set; }
}