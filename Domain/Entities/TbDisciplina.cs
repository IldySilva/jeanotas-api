using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbDisciplina
{
    public int IdDisciplina { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Abreviatura { get; set; }
}
