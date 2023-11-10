using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbFunção
{
    public int IdFunção { get; set; }

    public string Função { get; set; } = null!;

    public string? Salário { get; set; }

    public string? Diario { get; set; }

    public string? Irt { get; set; }
}
