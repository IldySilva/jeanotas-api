using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbJustificativa
{
    public int IdJustificativa { get; set; }

    public string Descrição { get; set; } = null!;
}
