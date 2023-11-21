using Application.Messaging;
using Domain.Exceptions;
using Domain.Repositories;
using Domain.ViewModel;
using Mapster;

namespace Application.Usecases.Perfil.MudarCredencias;

public class MudarCredenciaisCommandHandler : ICommandHandler<MudarCredenciaisCommand, ProfessorViewModel>
{

    private readonly IRepoProfessores  _professores ;

    public MudarCredenciaisCommandHandler(IRepoProfessores professores)
    {
        _professores = professores;
    }

    public async Task<ProfessorViewModel> Handle(MudarCredenciaisCommand request, CancellationToken cancellationToken)
    {
        var professor =await _professores.GetById(request.Id);

        professor.Usuario = request.NomeNovo;

        await _professores.Update(professor);
        return _professores.GetAll().Result.FirstOrDefault(x => x.IdProfessor == professor.IdProfessor);
    }
}