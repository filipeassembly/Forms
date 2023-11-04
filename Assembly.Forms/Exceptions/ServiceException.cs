namespace Assembly.Forms.Exceptions;

public abstract class ServiceException : Exception
{
    public ServiceException(string msg)  : base(msg) { }
}
