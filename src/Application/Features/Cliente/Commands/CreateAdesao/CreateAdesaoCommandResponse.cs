namespace CompraProgamada.Application.Features.SampleFeature
{
    public record CreateAdesaoCommandResponse(
        long ClienteId, 
        string Nome, 
        string CPF, 
        string Email, 
        decimal ValorMensal, 
        bool Ativo, 
        DateTime DataAdesao, 
        ContaGraficaResponse ContaGrafica);

    public record ContaGraficaResponse(long Id, string NumeroConta, string Tipo, DateTime DataCriacao);
}
