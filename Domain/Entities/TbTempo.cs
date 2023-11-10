using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbTempo
{
    public int IdTempo { get; set; }

    public string? Tempo { get; set; }

    public string? Começa { get; set; }

    public string? Termina { get; set; }

    public string? Periodo { get; set; }
}
