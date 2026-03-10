using MediatR;
using CompraProgamada.Application.Common;

namespace CompraProgamada.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
