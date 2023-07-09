using VirtualProxy.Interface;

namespace VirtualProxy;

public class VirtualProxy : ISubject
{
    private readonly Subject _subject;
    //a stand-in for the real data
    private readonly byte[]? _data = new[] { (byte)'a', (byte)'b', (byte)'c'};

    public VirtualProxy()
    {
        _subject = new Subject();
    }

    public async void Request()
    {
        _subject!.Data = _data; // staged data
        await Task.Delay(1000);
        _subject.Data = new[] { (byte)'x', (byte)'y', (byte)'z' }; // a logical expensive operation
    }
    
    public byte[]? GetData()
    {
        return _subject.Data;
    }
}
