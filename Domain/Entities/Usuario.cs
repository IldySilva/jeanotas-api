using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NomeDeUtilizador { get; set; }

    public string? PalavraPasse { get; set; }

    public int? IdNivelAcesso { get; set; }

    public int? IdFuncionario { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
