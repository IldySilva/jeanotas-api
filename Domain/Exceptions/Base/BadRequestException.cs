namespace Domain.Exceptions.Base
{
    public class BadRequestException : BaseException
    {
        public BadRequestException(string message)
            : base("Bad Request", message)
        {
        }
    }
}
