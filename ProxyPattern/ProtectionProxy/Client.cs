using ProtectionProxy.Interface;

namespace ProtectionProxy;

public class Client
{
    public bool ClientCode(ISubject subject)
    {
        return subject.Request();
    }
}