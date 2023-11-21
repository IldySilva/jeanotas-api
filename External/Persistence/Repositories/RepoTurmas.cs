using Application.Models;
using Domain.Repositories;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories;



public class RepoTurmas:IRepoTurmas
{
    private readonly IDataAccess _db;

    public RepoTurmas(IDataAccess db)=> _db = db;

    public async Task<List<Turma>> get()
    {
        return  _db.Query<Turma>("Select Descricaoo Descricao from Turmas").ToList();

    }
}