using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Domain.Repositories;

public interface IRepoCursos
{

    Task<List<Curso>> GetByProf(int Id);
    Task<List<Curso>> GetAll();

}
