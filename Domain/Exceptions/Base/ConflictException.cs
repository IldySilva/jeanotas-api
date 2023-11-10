namespace Domain.Exceptions.Base
{
    public class ConflictException : BaseException
    {
        public ConflictException(string? message) : 
            base("Conflict", message)
        {
        }
    }
}
