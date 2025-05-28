using System;

namespace OneWealth.Business.Exceptions;

public class EmailAlreadyInUseException : Exception
{
    public EmailAlreadyInUseException() : base()
    {

    }
    public EmailAlreadyInUseException(string Email) : base(Email+" is Already in use")
    {

    }
    public EmailAlreadyInUseException(string Message, Exception ex) : base(Message, ex)
    {

    }

}
