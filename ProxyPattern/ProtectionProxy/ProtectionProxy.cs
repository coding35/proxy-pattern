using ProtectionProxy.Interface;

namespace ProtectionProxy;

public class ProtectionProxy : ISubject
{
    private readonly Subject _subject;
    public ProtectionProxy(Subject subject)
    {
        _subject = subject;
    }

    public bool Request()
    {
        if (this.IsAuthorized())
        {
            return this._subject.Request();
        }

        return false;
    }

    private bool IsAuthorized()
    {
        //some logic to check if the user is authorized
        return false;
    }
}
