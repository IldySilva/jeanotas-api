using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Domain.Repositories;

public interface IRepoEstudantes
{

    Task<List<MatriculaViewModel>> GetByStudent(int Id);
    Task<List<MatriculaViewModel>> GetAll();

}
