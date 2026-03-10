using CompraProgamada.Application.Abstractions.Messaging;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public record GetSampleQuery(int Id) : IQuery<string>;
}
