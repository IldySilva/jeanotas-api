using Application.Messaging;
using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;

namespace Application.Usecases.Horarios;

public class GetHorarioQueryHandler:IQueryHandler<GetHorarioQuery,List<HorarioViewModel>>
{

    private readonly IRepoHorario _horario;

    public GetHorarioQueryHandler(IRepoHorario horario)
    {
        _horario = horario;
    }

    public async Task<List<HorarioViewModel>> Handle(GetHorarioQuery request, CancellationToken cancellationToken)
    {
        return await _horario.GetByProfId(request.ProfessorId);
    }
}