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

      select distinct curso.* from Curso  curso
        join TbHorario horario 

            ON  horario.IdCurso=curso.Idcurso
             where horario.IdProfessor={id}

").ToList());

        }

        public Task<List<Curso>> GetAll()
        {
            return   Task.FromResult(_db.Query<Curso>(@$"

    select distinct * from Curso  curso
    join TbHorario horario 

        ON  horario.IdCurso=curso.Idcurso

").ToList());

        }
    }
}
