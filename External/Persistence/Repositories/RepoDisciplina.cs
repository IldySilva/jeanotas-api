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

        public Task<List<TbDisciplina>> GetByProf(int id)
        {
            return   Task.FromResult(_db.Query<TbDisciplina>(@$"

select * from TbDisciplina disciplina 
    join TbDisciplinaProfessor disciplinaProf 
        ON disciplinaProf.idDisciplina=disciplina.IdDisciplina
         where IdProfessor={id}

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
