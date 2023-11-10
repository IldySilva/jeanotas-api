using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbPreco
{
    public decimal? Preço { get; set; }

    public decimal? Multas { get; set; }

    public int? Dia { get; set; }

    public int? Perce { get; set; }

    public decimal? Valor { get; set; }

    public string? Cob { get; set; }

    public string? Alemcurso { get; set; }

    public int? LimitePorTurma { get; set; }

    public string? Dinheiro { get; set; }

    public string? Tranferencia { get; set; }

    public string? Deposito { get; set; }

    public string? Multicaixa { get; set; }

    public string? Troco { get; set; }
}
