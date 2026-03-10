using MediatR;
using CompraProgamada.Application.Common;

namespace CompraProgamada.Application.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
