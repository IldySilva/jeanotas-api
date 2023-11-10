using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Domain.Repositories;

public interface IRepoHorario
{

    Task<List<HorarioViewModel>> GetByProfId(int Id);
    Task<List<HorarioViewModel>> GetAll();

}
