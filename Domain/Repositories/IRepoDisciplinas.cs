using Application.Models;

namespace Domain.Repositories;

public interface IRepoDisciplinas
{
    
    Task<List<TbDisciplina>> GetByProf(int id);

}