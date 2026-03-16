using MediatR;

namespace CompraProgamada.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
