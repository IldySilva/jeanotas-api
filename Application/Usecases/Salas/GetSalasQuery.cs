using Application.Messaging;
using Application.Models;

namespace Application.Usecases.Turmas;

public record GetSalasQuery : IQuery<List<Sala>>;
