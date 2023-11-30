namespace Application.Usecases.Notas.LancarNota;

public record LancarNotaRequest
{
    public int IdNotas { get; init; }
    public int IdProfessor { get; init; }
    public int IdEsudante { get; init; }
    public int IdCurso { get; init; }
    public int IdDisciplina { get; init; }
    public string? Classe { get; init; }
    public double? Av1_1º { get; init; }
    public double? Av2_1º { get; init; }
    public double? Av3_1º { get; init; }
    public double? Av4_1º { get; init; }
    public double? Mac1_1º { get; init; }
    public double? Npp1_1º { get; init; }
    public double? NpT1_1º { get; init; }
    public double? Mt1_1º { get; init; }
    public double? Av1_2º { get; init; }
    public double? Av2_2º { get; init; }
    public double? Av3_2º { get; init; }
    public double? Av4_2º { get; init; }
    public double? Mac_2º { get; init; }
    public double? Npp_2º { get; init; }
    public double? NpT_2º { get; init; }
    public double? Mt_2º { get; init; }
    public double? Av1_3º { get; init; }
    public double? Av2_3º { get; init; }
    public double? Av3_3º { get; init; }
    public double? Av4_3º { get; init; }
    public double? Mac_3º { get; init; }
    public double? Npp_3º { get; init; }
    public double? NpT_3º { get; init; }
    public double? Mt_3º { get; init; }
    public double? Mfd { get; init; }
    public string? AnoLectivo { get; init; }
};