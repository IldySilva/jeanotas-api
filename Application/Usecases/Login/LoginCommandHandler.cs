using Application.Login;
using Application.Messaging;
using Domain.Exceptions;
using Domain.Repositories;
using Domain.ViewModel;
using Mapster;

namespace Application.Usecases.Login;

public class LoginCommandHandler: ICommandHandler<LoginCommand,ProfessorViewModel>
{

    private readonly IRepoProfessores _professores;

    public LoginCommandHandler(IRepoProfessores professores)
    {
        _professores = professores;
    }

    public async Task<ProfessorViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var profs = await _professores.GetAll();
        profs = profs.Where(x => x.Estado).ToList();
        
    
        var professor = profs.FirstOrDefault(x => x.Usuario == request.User && x.Senha == request.Password);
        if (professor == null)
        {
            throw new UserNotFoundException("Utilizador Não Encontrado,verifique as suas Credenciais")
                ;
        }
    
        
        return professor.Adapt<ProfessorViewModel>();
    }
}