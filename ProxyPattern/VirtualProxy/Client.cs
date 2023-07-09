using VirtualProxy.Interface;

namespace VirtualProxy;

public class Client
{
    public void ClientCode(ISubject? subject)
    {
        subject?.Request();
    }
}