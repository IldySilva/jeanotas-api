

using Domain.Exceptions.Base;

namespace Domain.Exceptions
{
    public sealed class ValidationException : BaseException
    {
        public ValidationException(IReadOnlyDictionary<string, string[]> errorsDictionary)
            : base("A Validação Falhou", "Ocorreu um ou mais erros de validação")
            => ErrorsDictionary = errorsDictionary;

        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
