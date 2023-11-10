﻿namespace Domain.Entities;

public  class TbProfessor
{
    public int IdProfessor { get; set; }

    public string Nome { get; set; } = null!;

    public string? Bilhete { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Sexo { get; set; }

    public string? Nacionalidade { get; set; }

    public decimal? Telefone { get; set; }

    public int? NivelAcademico { get; set; }

    public string? Curso { get; set; }

    public string? Media { get; set; }

    public string? Morada { get; set; }

    public string? Usuario { get; set; }

    public string? Senha { get; set; }

    public byte[]? Foto { get; set; }

    public string? ContaBancaria { get; set; }

    public string? Iban { get; set; }
}
