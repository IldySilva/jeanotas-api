namespace Domain.Exceptions.Base
{
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string? msg) : 
            base("Utilizador Não Autorizado", msg)
        {

        }
    }
}
