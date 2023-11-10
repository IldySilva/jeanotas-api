
namespace Domain.Entities;

public  class Matricula
{
    public int IdMatricula { get; set; }

    public int? IdCurso { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdEstudante { get; set; }

    public DateTime? Data { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? Periodo { get; set; }

    public string? Turma { get; set; }

    public string? Sala { get; set; }

    public string? Classe { get; set; }

    public string? NrMecanografico { get; set; }

    public string? AnoLectivo { get; set; }

    public string? Descrição { get; set; }

    public int? Estado { get; set; }
}
