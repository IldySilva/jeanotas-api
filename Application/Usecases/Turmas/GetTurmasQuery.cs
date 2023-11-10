using Application.Messaging;
using Application.Models;

namespace Application.Usecases.Turmas;

public record GetTurmasQuery : IQuery<List<Turma>>;
