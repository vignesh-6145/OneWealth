using System;

namespace OneWealth.Business.Exceptions;

public class MobileAlreadInUseException : Exception
{
    public MobileAlreadInUseException() : base()
    {

    }
    public MobileAlreadInUseException(string Mobile) : base(Mobile+" is Already in use")
    {

    }
    public MobileAlreadInUseException(string Message, Exception ex) : base(Message, ex)
    {

    }
}
