using MediatR;

namespace Application.Messaging
{
    public interface IQueryHandler<in IQuery, TResponse> : IRequestHandler<IQuery, TResponse>
    where IQuery : IQuery<TResponse>
    {
    }
}



