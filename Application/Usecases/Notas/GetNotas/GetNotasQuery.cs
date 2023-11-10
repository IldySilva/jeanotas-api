using Application.Messaging;
using Domain.Entities;

namespace Application.Usecases.Notas.GetNotas;

public record GetNotasQuery(int Id):ICommand<TbNota>;