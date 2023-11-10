using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbCursoDisciplina
{
    public int Idcurso { get; set; }

    public int Iddisciplina { get; set; }

    public string Classe { get; set; } = null!;
}
