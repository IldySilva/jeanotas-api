using Application.Models;

namespace Domain.Entities;

public partial class Estudante
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Naturalidade { get; set; }

    public string? Telefone { get; set; }

    public string? Pai { get; set; }

    public string? TelefonePai { get; set; }

    public string? Mae { get; set; }

    public string? TelefoneMae { get; set; }

    public string? Binmr { get; set; }

    public string? Sexo { get; set; }

    public string? Estado { get; set; }

    public byte[]? Foto { get; set; }

    public string? NroMeca { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
