using Application.Messaging;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Usecases.Notas.GetNotas;

public class GetNotasQueryHandler : ICommandHandler<GetNotasQuery, TbNota>
{

    private readonly IRepoNotas _notas;

    public GetNotasQueryHandler(IRepoNotas notas)
    {
        _notas = notas;
    }

    public Task<TbNota> Handle(GetNotasQuery request, CancellationToken cancellationToken)
    {
        var nota= _notas.GetById(request.Id);
        return nota;
    }
}