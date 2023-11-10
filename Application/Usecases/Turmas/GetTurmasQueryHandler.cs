using Application.Messaging;
using Application.Models;

namespace Application.Usecases.Turmas;

public class GetTurmasQueryHandler : IQueryHandler<GetTurmasQuery,List<Turma>>
{
    public Task<List<Turma>> Handle(GetTurmasQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
};
