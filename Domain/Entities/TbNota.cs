namespace Domain.Entities;

public  class TbNota
{
    public int? IdNotas;

    public int IdProfessor { get; set; }

    public int IdEsudante { get; set; }

    public int IdCurso { get; set; }

    public int IdDisciplina { get; set; }

    public string? Classe { get; set; }

    public double? Av1_1º { get; set; }

    public double? Av2_1º { get; set; }

    public double? Av3_1º { get; set; }

    public double? Av4_1º { get; set; }

    public double? Mac1_1º { get; set; }

    public double? Npp1_1º { get; set; }

    public double? NpT1_1º { get; set; }
    
    public double? Npp1_1º2 { get; init; }
    
    public double? Mt1_1º { get; set; }

    public double? Av1_2º { get; set; }

    public double? Av2_2º { get; set; }

    public double? Av3_2º { get; set; }

    public double? Av4_2º { get; set; }

    public double? Mac_2º { get; set; }

    public double? Npp_2º { get; set; }
    public double? Npp_2º2 { get; init; }

    public double? NpT_2º { get; set; }

    public double? Mt_2º { get; set; }

    public double? Av1_3º { get; set; }

    public double? Av2_3º { get; set; }

    public double? Av3_3º { get; set; }

    public double? Av4_3º { get; set; }

    public double? Mac_3º { get; set; }

    public double? Npp_3º { get; set; }

    public double? NpT_3º { get; set; }

    public double? Mt_3º { get; set; }

    public double? Mfd { get; set; }

    public string? AnoLectivo { get; set; }
}
