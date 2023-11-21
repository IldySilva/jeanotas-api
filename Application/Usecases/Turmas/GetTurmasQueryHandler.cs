using Application.Messaging;
using Application.Models;
using Domain.Repositories;

namespace Application.Usecases.Turmas;

public class GetTurmasQueryHandler : IQueryHandler<GetTurmasQuery,List<Turma>>
{

    private readonly IRepoTurmas _turmas;

    public GetTurmasQueryHandler(IRepoTurmas turmas)
    {
        _turmas = turmas;
    }

    public Task<List<Turma>> Handle(GetTurmasQuery request, CancellationToken cancellationToken)
    {

        return _turmas.get();
    }
};
