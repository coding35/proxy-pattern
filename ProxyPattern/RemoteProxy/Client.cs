
using RemoteProxy.Interface;

namespace RemoteProxy;
public class Client
{
    public void ClientCode(ISubject? subject)
    {
        subject?.Request();
    }
}
