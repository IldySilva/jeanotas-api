using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbFalta
{
    public int IdFaltas { get; set; }

    public int IdFunProf { get; set; }

    public int Tipo { get; set; }

    public int Mes { get; set; }

    public DateTime Data { get; set; }

    public int? Justificada { get; set; }

    public int Idfuncionario { get; set; }

    public int? IdHorario { get; set; }

    public string? AnoLectivo { get; set; }

    public string? Justifi { get; set; }
}
