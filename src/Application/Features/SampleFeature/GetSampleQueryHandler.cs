using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Common;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public sealed class GetSampleQueryHandler : IQueryHandler<GetSampleQuery, string>
    {
        public async Task<Result<string>> Handle(GetSampleQuery request, CancellationToken cancellationToken)
        {
            // TODO: Buscar do banco de dados
            return Result<string>.Success("Sample Data");
        }
    }
}
