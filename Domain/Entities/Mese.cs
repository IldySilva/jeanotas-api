using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class Mese
{
    public int IdMes { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Valido { get; set; }

    public int? Estado { get; set; }

    public int? Ord { get; set; }
}
