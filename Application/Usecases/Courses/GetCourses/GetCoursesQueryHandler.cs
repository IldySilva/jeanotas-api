using Application.Messaging;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Usecases.Courses.GetCourses;

public class GetCoursesQueryHandler:IQueryHandler<GetCoursesQuery,List<Curso>>
{

    private readonly IRepoCursos _cursos;

    public GetCoursesQueryHandler(IRepoCursos cursos)
    {
        _cursos = cursos;
    }

    public Task<List<Curso>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
    {
        return _cursos.GetByProf(request.Id);
    }
};