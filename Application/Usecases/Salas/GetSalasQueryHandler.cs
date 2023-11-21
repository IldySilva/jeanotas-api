using Application.Messaging;
using Application.Models;
using Domain.Repositories;

namespace Application.Usecases.Turmas;

public class GetSalasQueryHandler : IQueryHandler<GetSalasQuery,List<Sala>>
{

    private readonly IRepoSalas _salas;

    public GetSalasQueryHandler(IRepoSalas salas)
    {
        _salas = salas;
    }

    public Task<List<Sala>> Handle(GetSalasQuery request, CancellationToken cancellationToken)
    {

        return _salas.get();
    }
};
