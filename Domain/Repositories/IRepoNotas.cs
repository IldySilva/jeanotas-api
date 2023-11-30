using Domain.Entities;

namespace Domain.Repositories;

public interface IRepoNotas
{

    Task<TbNota> GetById(int id);
    Task<List<TbNota>> GetAll();
    Task<TbNota?> Update(TbNota professor);
    Task<TbNota?> insert(TbNota nota);
}    

