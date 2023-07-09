using VirtualProxy.Interface;

namespace VirtualProxy;

public class Subject : ISubject
{
    public byte[]? Data { get; set; }
    public void Request()
    {
        Console.WriteLine("Subject.Request");
    }
}