using Application.Models;

namespace Domain.Repositories;

public interface IRepoFuncionario
{
    
    Task<List<TbFuncionario>> GetAll();

}