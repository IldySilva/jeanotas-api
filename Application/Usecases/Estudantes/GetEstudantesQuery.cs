using Application.Messaging;
using Domain.ViewModel;

namespace Application.Usecases.Estudantes;

public record GetEstudantesQuery(int IdCurso,string Classe,string Turma,string Sala,int IdDisciplina):IQuery<List<MatriculaViewModel>>;