using Application.Models;
using Domain.Repositories;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories;



public class RepoSalas:IRepoSalas
{
    private readonly IDataAccess _db;

    public RepoSalas(IDataAccess db) =>  _db = db;

    public async Task<List<Sala>> get()
    {
        return  _db.Query<Sala>("Select * from Salas").ToList();

    }
}