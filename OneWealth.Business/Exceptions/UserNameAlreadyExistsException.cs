using System;

namespace OneWealth.Business.Exceptions;

public class UserNameAlreadyExistsException: Exception
{
    public UserNameAlreadyExistsException() : base()
    {
    }
    public UserNameAlreadyExistsException(string UserName) : base(UserName+" Already exists")
    {

    }
    public UserNameAlreadyExistsException(string Message, Exception ex) : base(Message, ex)
    {

    }
}
