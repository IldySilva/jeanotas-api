using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoCursos: IRepoCursos
    {
        private readonly IDataAccess _db;
        public RepoCursos(IDataAccess db) => _db = db;

        public Task<List<Curso>> GetByProf(int id)
        {
            return   Task.FromResult(_db.Query<Curso>(@$"

select * from Curso 
    join TbCursoProfessor cursoProf 
        ON cursoProf.idCurso=Curso.Idcurso
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
