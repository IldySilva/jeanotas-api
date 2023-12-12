using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoDisciplina: IRepoDisciplinas
    {
        private readonly IDataAccess _db;
        public RepoDisciplina(IDataAccess db) => _db = db;

        public Task<List<TbDisciplina>> GetByProf(int professor,int curso,string classe)
        {
            return   Task.FromResult(_db.Query<TbDisciplina>(@$"

   SELECT  distinct disciplina.IdDisciplina,Descrição[Descricao],Abreviatura FROM TbDisciplina disciplina
    join TbDisciplinaProfessor disciplinaProf 
        ON disciplinaProf.idDisciplina=disciplina.IdDisciplina
		join TbCursoDisciplina cd on cd.Iddisciplina=disciplina.IdDisciplina
         where
IdProfessor={professor}
		 and 
		 Idcurso={curso}
   and cd.Classe='{classe}'

").ToList());

        }

        public Task<List<Curso>> GetAll()
        {
            return   Task.FromResult(_db.Query<Curso>(@$"

select * from Curso 
    join TbCursoProfessor cursoProf 
        ON cursoProf.idCurso=Curso.Idcurso


").ToList());

        }
    }
}
