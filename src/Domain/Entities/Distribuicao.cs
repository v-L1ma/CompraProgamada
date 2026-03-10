using System.Numerics;

namespace CompraProgamada.Domain.Entities;

public class Distribuicao
{
    public BigInteger Id { get; set; }
    public BigInteger OrdemCompraId { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}