using RemoteProxy.Interface;

namespace RemoteProxy;

public class RemoteProxyClient
{
    public void ClientCode(ISubject? subject)
    {
        subject?.Request();
    }
}