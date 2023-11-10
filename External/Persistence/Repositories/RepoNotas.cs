using Domain.DTOs;
using Domain.Entities;
using Domain.Repositories;
using Infraestructure.Infra_DbAcess;
using Mapster;
using MimeKit.Tnef;
using Persistence.Helpers;

namespace Persistence.Repositories
{
    public class RepoNotas : IRepoNotas
    {
        private readonly IDataAccess _db;
        private const string Table = "TbNotas";
        public RepoNotas(IDataAccess db) => _db = db;


        public Task<TbNota> GetById(int id)
        {
            return   Task.FromResult(Task.FromResult(_db.Query<TbNota>($"select  * from  {Table} where idEsudante={id}").ToList()).Result.FirstOrDefault());

        }

        public Task<List<TbNota>> GetAll()
        {
           return   Task.FromResult(_db.Query<TbNota>($"select  * from  {Table}").ToList());
        }

        public async Task<TbNota?> Update(TbNota professor)
        {
            
            var query = SqlQueryGen.GenerateUpdateSql(professor.Adapt<DtoProfessor>(), $"{Table}",$"idProfessor={professor.IdProfessor}");
            await _db.CommandAsync(query);
            return await GetById(professor.IdProfessor);
        }
    }
}
