using CompraProgamada.Application.Abstractions.Messaging;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public record CreateSampleCommand(string Name) : ICommand<int>;
}
