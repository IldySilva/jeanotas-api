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

  select distinct disciplina.IdDisciplina,disciplina.Descrição[Descricao],disciplina.Abreviatura from Curso  curso
    join TbHorario horario 
	join TbDisciplina disciplina on disciplina.IdDisciplina=horario.IdDisciplina
        ON  horario.IdCurso=curso.Idcurso
         where horario.IdProfessor={professor}  and curso.Idcurso={curso} and horario.Classe='{classe}'

").ToList());

        }

        public Task<List<Curso>> GetAll()
        {
            return   Task.FromResult(_db.Query<Curso>(@$"

  select distinct disciplina.IdDisciplina,disciplina.Descrição[Descricao],disciplina.Abreviatura from Curso  curso
    join TbHorario horario 
	join TbDisciplina disciplina on disciplina.IdDisciplina=horario.IdDisciplina
        ON  horario.IdCurso=curso.Idcurso

").ToList());

        }
    }
}
