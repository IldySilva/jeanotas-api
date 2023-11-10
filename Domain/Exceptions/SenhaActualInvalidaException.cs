using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class SenhaInvalidaxception:UnauthorizedException
{
    public SenhaInvalidaxception(string? message) : base(message)
    {
    }
}