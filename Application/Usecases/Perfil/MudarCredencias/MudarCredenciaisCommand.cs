using Application.Messaging;
using Domain.ViewModel;

namespace Application.Usecases.Perfil.MudarCredencias;

public record MudarCredenciaisCommand(int Id,string NomeNovo):ICommand<ProfessorViewModel>;