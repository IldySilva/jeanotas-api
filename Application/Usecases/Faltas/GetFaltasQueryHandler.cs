using Application.Messaging;
using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;

namespace Application.Usecases.Horarios;

public class GetFaltasQueryHandler:IQueryHandler<GetFaltasQuery,List<TbFalta>>
{

    private readonly IRepoProfessores _professores;
    private readonly IRepoFaltas _faltas;
    private readonly IRepoFuncionario _funcionario;

    public GetFaltasQueryHandler(IRepoProfessores professores, IRepoFaltas faltas, IRepoFuncionario funcionario)
    {
        _professores = professores;
        _faltas = faltas;
        _funcionario = funcionario;
    }

    public async Task<List<TbFalta>> Handle(GetFaltasQuery request, CancellationToken cancellationToken)
    {

        var prof = await _professores.GetById(request.ProfessorId);
        var func =  _funcionario.GetAll().Result.FirstOrDefault(x => x.Bilhete == prof.Bilhete);
        return  _faltas.GetAll().Result.Where(x => x.Idfuncionario == func.IdFuncionario).ToList();
    }
}