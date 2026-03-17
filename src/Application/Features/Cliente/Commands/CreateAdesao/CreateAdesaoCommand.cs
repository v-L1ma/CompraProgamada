using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Features.SampleFeature;

namespace CompraProgamada.Application.Features.ClienteFeature.Commands
{
    public record CreateAdesaoCommand(string Nome, string CPF, string Email, decimal ValorMensal) : ICommand<CreateAdesaoCommandResponse>;
}
