using ProtectionProxy.Interface;

namespace ProtectionProxy;

public class ProtectionProxyClient
{
    public bool ClientCode(ISubject subject)
    {
        return subject.Request();
    }
}