using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.Models;

public partial class Pagamento
{
    public int IdPagamento { get; set; }

    public string? Referencia { get; set; }

    public int? IdEstudante { get; set; }

    public int? IdUsuario { get; set; }

    public string? Total { get; set; }

    public string? ValorPago { get; set; }

    public string? Troco { get; set; }

    public DateTime? Data { get; set; }

    public TimeSpan? Hora { get; set; }

    public string? FormaDePagamento { get; set; }

    public string? AnoLectivo { get; set; }

    public string? Estado { get; set; }

    public int? AnuladoPor { get; set; }

    public DateTime? DatadaAnulacao { get; set; }

    public string? Motivo { get; set; }

    public int? Tipo { get; set; }

    public virtual Estudante? IdEstudanteNavigation { get; set; }
}
