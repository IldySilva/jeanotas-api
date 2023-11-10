using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbSalario
{
    public int IdSalario { get; set; }

    public int IdMes { get; set; }

    public string Ano { get; set; } = null!;

    public int IdFuncionario { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public string? TotalSalarioBase { get; set; }

    public string? TotalSubsidio { get; set; }

    public string? TotalHoraExtra { get; set; }

    public string? TotalIliquido { get; set; }

    public string? TotallSegurançaSocial { get; set; }

    public string? ToTalIrt { get; set; }

    public string? ToTalDesFaltas { get; set; }

    public string? TotalDescontos { get; set; }

    public string? TotalLiquido { get; set; }

    public string? Estado { get; set; }
}
