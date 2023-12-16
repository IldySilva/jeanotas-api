using Application.Models;
using Domain.Entities;
using Domain.ViewModel;

namespace Domain.Repositories;

public interface IRepoSchool
{

    Task<Escola> Get();

}
