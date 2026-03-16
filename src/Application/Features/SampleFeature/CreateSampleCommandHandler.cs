using CompraProgamada.Application.Abstractions.Messaging;

namespace CompraProgamada.Application.Features.SampleFeature
{
    public sealed class CreateSampleCommandHandler : ICommandHandler<CreateSampleCommand, int>
    {
        public Task<int> Handle(CreateSampleCommand request, CancellationToken cancellationToken)
        {
            // TODO: Criar a entidade e salvar no banco de dados
            return Task.FromResult(1);
        }
    }
}
