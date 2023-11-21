using Application.Models;

namespace Domain.Repositories;

public interface IRepoTurmas
{
    Task<List<Turma>> get();
}