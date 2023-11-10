using Application.Messaging;
using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Application.Usecases.Horarios;

public record GetHorarioQuery(int ProfessorId) : IQuery<List<HorarioViewModel>>;
