using Domain.Entities;
using Domain.ViewModel;

namespace Domain.Repositories;

public interface IRepoProfessores
{

    Task<TbProfessor?> GetById(int id);
    Task<List<TbProfessor>> GetAllEntities();
    Task<List<ProfessorViewModel>> GetAll();

    Task<TbProfessor?> Update(TbProfessor professor);

}
