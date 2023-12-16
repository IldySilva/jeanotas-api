using Application.Messaging;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Mapster;

namespace Application.Usecases.Notas.LancarNota;

public class LancarNotaCommandHandler:ICommandHandler<LancarNotaCommand,MatriculaViewModel>
{

    private readonly IRepoNotas _notas;
    private readonly IRepoEstudantes _estudantes;

    public LancarNotaCommandHandler(IRepoNotas notas, IRepoEstudantes estudantes)
    {
        _notas = notas;
        _estudantes = estudantes;
    }

    public async Task<MatriculaViewModel> Handle(LancarNotaCommand request, CancellationToken cancellationToken)
    {


        
        
        
        if (request.IdNotas is null or 0)
        {
            var nota = request.Adapt<TbNota>();

            nota.IdNotas = null;
            await _notas.insert(nota);
        }
        else
        {
           await  _notas.Update(request.Adapt<TbNota>());
        }
        return  _estudantes.GetAll().Result.FirstOrDefault(x => x.IdEstudante == request.IdEsudante && x.IdDisciplina==request.IdDisciplina);
    }
}