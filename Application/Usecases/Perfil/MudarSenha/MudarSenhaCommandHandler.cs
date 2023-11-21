using Application.Messaging;
using Domain.Exceptions;
using Domain.Repositories;
using Domain.ViewModel;
using Mapster;

namespace Application.Usecases.Perfil.MudarSenha;

public class MudarSenhaCommandHandler:ICommandHandler<MudarSenhaCommand,ProfessorViewModel>
{
    
    private readonly IRepoProfessores  _professores ;

    public MudarSenhaCommandHandler(IRepoProfessores professores)
    {
        _professores = professores;
    }

    public async Task<ProfessorViewModel> Handle(MudarSenhaCommand request, CancellationToken cancellationToken)
    {
        var professor =await _professores.GetById(request.Id);

        if (professor.Senha != request.SenhaActual)
            throw new SenhaInvalidaxception("Senha Actual Invalida");

        professor.Senha = request.SenhaNova;

        await _professores.Update(professor);
        return _professores.GetAll().Result.FirstOrDefault(x => x.IdProfessor == professor.IdProfessor);
    }
};