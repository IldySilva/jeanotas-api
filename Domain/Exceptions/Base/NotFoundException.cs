namespace Domain.Exceptions.Base
{
    public abstract class NotFoundException : BaseException
    {
        public NotFoundException(string? message)
            : base("Not Found", message)
        {
        }
    }
}