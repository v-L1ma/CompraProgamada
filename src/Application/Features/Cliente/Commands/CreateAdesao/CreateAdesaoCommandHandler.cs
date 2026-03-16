using System.Net;
using CompraProgamada.Application.Abstractions.Messaging;
using CompraProgamada.Application.Features.SampleFeature;

namespace CompraProgamada.Application.Features.Cliente.Commands
{
    public sealed class CreateAdesaoCommandHandler : ICommandHandler<CreateAdesaoCommand, CreateAdesaoCommandResponse>
    {
        public Task<CreateAdesaoCommandResponse> Handle(CreateAdesaoCommand request, CancellationToken cancellationToken)
        {
            // TODO: Criar a entidade e salvar no banco de dados
            return Task.FromResult(new CreateAdesaoCommandResponse("FUNCIONOU"));
        }
    }
}
