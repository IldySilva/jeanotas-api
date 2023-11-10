using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbExcessoTurma
{
    public int IdMatricula { get; set; }

    public int? IdEstudante { get; set; }

    public int? Idcurso { get; set; }

    public int? IdUduario { get; set; }

    public DateTime? Data { get; set; }
}
