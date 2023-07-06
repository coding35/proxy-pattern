using RemoteProxy.Interface;

namespace RemoteProxy;

public class Subject : ISubject
{
    public string Data { get; set; } = string.Empty;
    
    public void Request()
    {
        Console.WriteLine("Subject.Request");
    }

    public string GetData()
    {
        return this.Data;
    }
}