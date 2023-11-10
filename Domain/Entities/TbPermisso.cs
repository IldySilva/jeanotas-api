using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbPermisso
{
    public int IdPermissoes { get; set; }

    public string? Permissoes { get; set; }

    public int? IdnivelDeAcesso { get; set; }
}
