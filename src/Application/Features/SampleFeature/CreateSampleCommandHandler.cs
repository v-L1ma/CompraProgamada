using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Common;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public sealed class CreateSampleCommandHandler : ICommandHandler<CreateSampleCommand, int>
    {
        public async Task<Result<int>> Handle(CreateSampleCommand request, CancellationToken cancellationToken)
        {
            // TODO: Criar a entidade e salvar no banco de dados
            return Result<int>.Success(1);
        }
    }
}
