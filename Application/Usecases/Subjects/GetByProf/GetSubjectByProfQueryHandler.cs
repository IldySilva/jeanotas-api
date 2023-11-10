using Application.Messaging;
using Application.Models;
using Domain.Repositories;

namespace Application.Usecases.Subjects.GetByProf;

public class GetSubjectByProfQueryHandler: IQueryHandler<GetSubjectByProfQuery,List<TbDisciplina>>
{
    private readonly IRepoDisciplinas _disciplinas;

    public GetSubjectByProfQueryHandler(IRepoDisciplinas disciplinas)
    {
        _disciplinas = disciplinas;
    }

    public Task<List<TbDisciplina>> Handle(GetSubjectByProfQuery request, CancellationToken cancellationToken)
    {
        return _disciplinas.GetByProf(request.Id);
    }
};