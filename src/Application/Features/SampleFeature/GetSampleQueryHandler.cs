using CompraProgamada.Application.Abstractions.Messaging;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public sealed class GetSampleQueryHandler : IQueryHandler<GetSampleQuery, string>
    {
        public Task<string> Handle(GetSampleQuery request, CancellationToken cancellationToken)
        {
            // TODO: Buscar do banco de dados
            return Task.FromResult("Sample Data");
        }
    }
}
