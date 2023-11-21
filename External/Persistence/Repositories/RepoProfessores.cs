using Domain.DTOs;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;
using Mapster;
using Persistence.Helpers;

namespace Persistence.Repositories
{
    public class RepoProfessores : IRepoProfessores
    {
        private readonly IDataAccess _db;
        public RepoProfessores(IDataAccess db) => _db = db;


        public Task<TbProfessor?> GetById(int Id)
        {
            return   Task.FromResult(Task.FromResult(_db.Query<TbProfessor>($"select  * from  TbProfessor where idProfessor={Id}").ToList()).Result.FirstOrDefault());

        }

        public Task<List<TbProfessor>> GetAllEntities()
        {
           return   Task.FromResult(_db.Query<TbProfessor>($"  select  p.*,nivel.NivelAcademico[Nivel],nivel.Pagamento from  TbProfessor p  join TbNivelAcademico nivel on nivel.IdNivel=p.NivelAcademico").ToList());
        }

        public Task<List<ProfessorViewModel>> GetAll()
        {
            return   Task.FromResult(_db.Query<ProfessorViewModel>($"  select  p.*,nivel.NivelAcademico[Nivel],nivel.Pagamento from  TbProfessor p  join TbNivelAcademico nivel on nivel.IdNivel=p.NivelAcademico").ToList());

        }

        public async Task<TbProfessor?> Update(TbProfessor professor)
        {
            
            var query = SqlQueryGen.GenerateUpdateSql(professor.Adapt<DtoProfessor>(), "TbProfessor",$"idProfessor={professor.IdProfessor}");
            await _db.CommandAsync(query);
            return await GetById(professor.IdProfessor);
        }
    }
}
