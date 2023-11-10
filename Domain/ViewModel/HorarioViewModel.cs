namespace Domain.ViewModel;

public class HorarioViewModel
{
    public int IdHorario { get; set; }

    public int? IdProfessor { get; set; }

    public int? IdCurso { get; set; }
    
    public string? Curso { get; set; }

    public int? IdDisciplina { get; set; }
    
    public string? Disciplina { get; set; }

    public string? Tempo { get; set; }

    public string? Periodo { get; set; }

    public string? Turma { get; set; }

    public string? Sala { get; set; }

    public string? Classe { get; set; }

    public string? AnoLectivo { get; set; }

    public string? DiaDsemana { get; set; }
    public string? Comeca { get; set; }
    public string? Termina { get; set; }


}