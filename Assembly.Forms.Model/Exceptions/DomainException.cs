namespace Assembly.Forms.Model.Exceptions;

public abstract class DomainException : Exception
{
    public DomainException(string msg) : base(msg) { }
}
