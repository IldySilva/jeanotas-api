using Application.Messaging;
using Domain.ViewModel;

namespace Application.Usecases.Perfil.MudarSenha;

public record MudarSenhaCommand(int Id,string SenhaActual,string SenhaNova):ICommand<ProfessorViewModel>;