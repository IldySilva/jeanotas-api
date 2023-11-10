using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class TbFornecedor
{
    public int IdFornecedor { get; set; }

    public string Nome { get; set; } = null!;

    public decimal? Nif { get; set; }

    public decimal? Contacto { get; set; }
}
