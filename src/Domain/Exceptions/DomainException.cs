namespace CompraProgamada.Domain.Exceptions
{
    public class DomainException : AppException
    {
        public string Codigo { get; }
        public int StatusCode { get; }

        public DomainException(string codigo, string mensagem, int statusCode = 400)
            : base(mensagem)
        {
            Codigo = codigo;
            StatusCode = statusCode;
        }
    }
}