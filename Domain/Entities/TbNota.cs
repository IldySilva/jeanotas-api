﻿namespace Domain.Entities;

public  class TbNota
{
    public int IdNotas { get; set; }

    public int IdProfessor { get; set; }

    public int IdEsudante { get; set; }

    public int IdCurso { get; set; }

    public int IdDisciplina { get; set; }

    public string? Classe { get; set; }

    public string? Av1_1º { get; set; }

    public string? Av2_1º { get; set; }

    public string? Av3_1º { get; set; }

    public string? Av4_1º { get; set; }

    public string? Mac1_1º { get; set; }

    public string? Npp1_1º { get; set; }

    public string? NpT1_1º { get; set; }

    public string? Mt1_1º { get; set; }

    public string? Av1_2º { get; set; }

    public string? Av2_2º { get; set; }

    public string? Av3_2º { get; set; }

    public string? Av4_2º { get; set; }

    public string? Mac_2º { get; set; }

    public string? Npp_2º { get; set; }

    public string? NpT_2º { get; set; }

    public string? Mt_2º { get; set; }

    public string? Av1_3º { get; set; }

    public string? Av2_3º { get; set; }

    public string? Av3_3º { get; set; }

    public string? Av4_3º { get; set; }

    public string? Mac_3º { get; set; }

    public string? Npp_3º { get; set; }

    public string? NpT_3º { get; set; }

    public string? Mt_3º { get; set; }

    public string? Mfd { get; set; }

    public string? AnoLectivo { get; set; }
}