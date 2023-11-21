using Application.Models;

namespace Domain.Repositories;

public interface IRepoSalas
{
    Task<List<Sala>> get();
}