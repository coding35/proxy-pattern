using ProtectionProxy.Interface;

namespace ProtectionProxy;

public class Subject : ISubject
{
    public bool Request()
    {
        Console.WriteLine("Subject.Request");
        return true;
    }
}