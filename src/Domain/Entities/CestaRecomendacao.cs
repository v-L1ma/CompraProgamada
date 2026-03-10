using System.Numerics;

namespace CompraProgamada.Domain.Entities;

public class CestaRecomendacao
{
    public BigInteger Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public bool Ativa { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataDesativacao { get; set; }
}