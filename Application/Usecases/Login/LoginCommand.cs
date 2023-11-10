using Application.Messaging;
using Domain.Entities;
using Domain.ViewModel;

namespace Application.Login;

public record LoginCommand(string User,string Password):ICommand<ProfessorViewModel>;