namespace Domain.Exceptions.Base
{
    public class BaseException : Exception
    {
        public BaseException(string title, string? message)
            : base(message)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
