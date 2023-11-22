using Application.Messaging;
using Domain.Repositories;
using Domain.ViewModel;

namespace Application.Usecases.Estudantes;

public class GetEstudantesQueryHandler:IQueryHandler<GetEstudantesQuery,List<MatriculaViewModel>>
{

    private readonly IRepoEstudantes _estudantes;

    public GetEstudantesQueryHandler(IRepoEstudantes estudantes)
    {
        _estudantes = estudantes;
    }

    public async Task<List<MatriculaViewModel>> Handle(GetEstudantesQuery request, CancellationToken cancellationToken)
    {
        var estudantes = await _estudantes.GetAll();
        estudantes = estudantes
            .Where(x =>
                x.IdCurso==request.IdCurso
                && x.Turma == request.Turma
                && x.Classe == request.Classe
                )
            .ToList();
        return estudantes;

    }
};