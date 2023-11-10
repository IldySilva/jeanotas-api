using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class MesesPago
{
    public int IdMesePagos { get; set; }

    public int? IdMeses { get; set; }

    public string IdRefernciaPagamento { get; set; } = null!;

    public int? ValorMensalidade { get; set; }
}
