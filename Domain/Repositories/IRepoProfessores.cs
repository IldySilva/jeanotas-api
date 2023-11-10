using Domain.Entities;

namespace Domain.Repositories;

public interface IRepoProfessores
{

    Task<TbProfessor?> GetById(int id);
    Task<List<TbProfessor>> GetAll();
    Task<TbProfessor?> Update(TbProfessor professor);

}
