using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoSchool : IRepoSchool
    {
        private readonly IDataAccess _db;
        public RepoSchool(IDataAccess db) => _db = db;

        public async Task<Escola> Get()
        {
            return ( await _db.QueryAsync<Escola>("select  top(1) *from escola")).FirstOrDefault();
        }
    }
}
