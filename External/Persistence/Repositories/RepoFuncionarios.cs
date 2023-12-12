using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoFuncionario: IRepoFuncionario
    {
        private readonly IDataAccess _db;
        public RepoFuncionario(IDataAccess db) => _db = db;

        public Task<List<TbFuncionario>> GetAll()
        {
            return   Task.FromResult(_db.Query<TbFuncionario>(@$"

select * from TbFuncionario


").ToList());

        }
    }
}
