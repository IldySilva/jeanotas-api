using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbFuncionariosSalario
{
    public int? IdSalario { get; set; }

    public string? Nome { get; set; }

    public string? Função { get; set; }

    public string? ContaBancaria { get; set; }

    public string? Iban { get; set; }

    public string? Salario { get; set; }

    public string? SubSidio { get; set; }

    public string? HoraExtra { get; set; }

    public string? SalarioIliquido { get; set; }

    public string? SegSocial { get; set; }

    public string? Irt { get; set; }

    public string? VporDia { get; set; }

    public string? Tfaltas { get; set; }

    public string? DescFaltas { get; set; }

    public string? Tdesconto { get; set; }

    public string? SalarioLiquido { get; set; }

    public int? IdFuncionario { get; set; }

    public string? DiasTra { get; set; }

    public string? RetroAc { get; set; }
}
