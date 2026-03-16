using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Features.SampleFeature;

namespace CompraProgamada.Application.Features.Cliente.Commands
{
    public record CreateAdesaoCommand(string Name) : ICommand<CreateAdesaoCommandResponse>;
}
