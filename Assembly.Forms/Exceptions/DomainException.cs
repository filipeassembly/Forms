namespace Assembly.Forms.Exceptions;

public abstract class DomainException : Exception
{
    public DomainException(string msg) : base(msg) { }
}
