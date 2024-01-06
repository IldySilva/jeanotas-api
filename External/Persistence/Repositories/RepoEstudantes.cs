using Application.Models;
using Domain.Entities;
using Domain.Repositories;
using Domain.ViewModel;
using Infraestructure.Infra_DbAcess;

namespace Persistence.Repositories
{
    public class RepoEstudantes: IRepoEstudantes
    {
        private readonly IDataAccess _db;
        public RepoEstudantes(IDataAccess db) => _db = db;


        public Task<List<MatriculaViewModel>> GetByStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MatriculaViewModel>> GetAll()
        {
            return   Task.FromResult(_db.Query<MatriculaViewModel>(@$"

SELECT 
	Estudante.Nome,
	Estudante.Sexo,
	Estudante.Telefone,
	Matricula.*,
	notas.*
    FROM Matricula
	join Estudante on Estudante.Id=Matricula.IdEstudante
	left  join TbNotas  notas on notas.IdEsudante=Estudante.Id
join TbPrecos p on p.ALemcurso=Matricula.AnoLectivo

").ToList());

        }
    }
}
