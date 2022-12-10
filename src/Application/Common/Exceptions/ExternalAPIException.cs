namespace Rentel.ServiceTemplate.Application.Common.Exceptions;

public class ExternalAPIException : Exception
{
    public ExternalAPIException()
        : base()
    {
    }

    public ExternalAPIException(string message)
        : base(message)
    {
    }

    public ExternalAPIException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
