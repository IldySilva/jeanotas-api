namespace Domain.Exceptions.Base
{
    public class InvalidException : BaseException
    {
        public InvalidException(string? message)
            : base("Invalid Format", message)
        {
        }
    }
}
