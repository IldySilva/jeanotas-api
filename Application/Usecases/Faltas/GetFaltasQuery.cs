using Application.Messaging;
using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Application.Usecases.Horarios;

public record GetFaltasQuery(int ProfessorId) : IQuery<List<TbFalta>>;
