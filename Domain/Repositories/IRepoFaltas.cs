using Application.Models;

namespace Domain.Repositories;

public interface IRepoFaltas
{
    
    Task<List<TbFalta>> GetAll();

}