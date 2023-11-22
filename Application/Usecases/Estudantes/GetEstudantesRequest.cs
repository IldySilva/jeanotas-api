namespace Application.Usecases.Estudantes;

public record GetEstudantesRequest(int IdCurso,string Classe,string Turma,int IdDisciplina);