namespace CompraProgamada.Domain.Entities;

public class Cliente
{
    public long Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal ValorMensal { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataAdesao { get; set; }
}