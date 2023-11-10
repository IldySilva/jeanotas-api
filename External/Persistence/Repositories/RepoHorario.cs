
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoHorario: IRepoHorario
    {
        private readonly IDataAccess _db;
        public RepoHorario(IDataAccess db) => _db = db;

        public   Task<List<HorarioViewModel>> GetByProfId(int Id)
        {
            return   Task.FromResult(_db.Query<HorarioViewModel>(@$"
 SELECT   horario.*, 
 tempo.Começa[Comeca],
 tempo.Termina,
disciplina.Descrição[Disciplina] ,
 curso.Descricao[Curso]
FROM TbHorario  horario 
  join TbDisciplina
disciplina  on horario.IdDisciplina=disciplina.IdDisciplina

join  Curso curso on curso.Idcurso=horario.Idcurso

join   TbTempo tempo on tempo.Tempo=horario.Tempo  and tempo.Periodo=horario.Periodo
 where idProfessor={Id}").ToList());

        }

        public Task<List<HorarioViewModel>> GetAll()
        {
            return   Task.FromResult(_db.Query<HorarioViewModel>(@$"

SELECT   horario.*, 
disciplina.Descrição[Disciplina] ,
 curso.Descricao[Curso]
FROM TbHorario  horario 
  join TbDisciplina
disciplina  on horario.IdDisciplina=disciplina.IdDisciplina
join  Curso curso on curso.Idcurso=horario.Idcurso

").ToList());

        }
    }
}
