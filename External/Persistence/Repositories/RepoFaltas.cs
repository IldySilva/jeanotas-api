using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoFaltas: IRepoFaltas
    {
        private readonly IDataAccess _db;
        public RepoFaltas(IDataAccess db) => _db = db;

        public Task<List<TbFalta>> GetAll()
        {
            return   Task.FromResult(_db.Query<TbFalta>(@$"

select * from TbFaltas


").ToList());

        }
    }
}
