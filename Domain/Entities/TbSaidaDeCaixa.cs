using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbSaidaDeCaixa
{
    public int IdSaida { get; set; }

    public int Idmês { get; set; }

    public string AnoLectivo { get; set; } = null!;

    public int IdFuncionário { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public string Valor { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Descrição { get; set; } = null!;

    public int IdJustificativa { get; set; }

    public string? Observação { get; set; }

    public int? IdFornecedor { get; set; }
}
