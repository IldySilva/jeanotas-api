using System;
using System.Collections.Generic;

namespace Application.Models;

public partial class Escola
{
    public int IdEscola { get; set; }

    public string? NomeEscola { get; set; }

    public string? Nif { get; set; }

    public string? Abreviatura { get; set; }

    public string? Pais { get; set; }

    public string? Municipio { get; set; }

    public string? Telefone { get; set; }

    public string? TelefoneAlternativo { get; set; }

    public string? Email { get; set; }

    public string? Site { get; set; }

    public string? Beneficiario { get; set; }

    public string? Banco { get; set; }

    public string? Iban { get; set; }

    public string? Conta { get; set; }

    public string? Bairro { get; set; }

    public string? Rua { get; set; }

    public byte[]? Foto { get; set; }

    public string? DirGeral { get; set; }

    public string? DirPeda { get; set; }

    public string? DirAdm { get; set; }

    public string? Provincia { get; set; }
}
