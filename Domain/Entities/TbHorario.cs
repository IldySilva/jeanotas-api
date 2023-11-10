namespace Domain.Entities;

public  class TbHorario
{
    public int IdHorario { get; set; }

    public int? IdProfessor { get; set; }

    public int? IdCurso { get; set; }

    public int? IdDisciplina { get; set; }

    public string? Tempo { get; set; }

    public string? Periodo { get; set; }

    public string? Turma { get; set; }

    public string? Sala { get; set; }

    public string? Classe { get; set; }

    public string? AnoLectivo { get; set; }

    public string? DiaDsemana { get; set; }
}
