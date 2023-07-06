using System.Net;
using RemoteProxy.Interface;

namespace RemoteProxy;


public class RemoteProxy : ISubject
{
    readonly HttpClient _client = new HttpClient();
    private readonly string _url = "https://api.openweathermap.org/data/2.5/weather?appid={openweathermap_apikey}&q=chicago";
    private static Subject? _subject;
    public RemoteProxy(Subject? subject)
    {
        _subject = subject;
    }

    public void Request()
    {
        var response = _client.GetAsync(_url).Result;
        var result = response.Content.ReadAsStringAsync().Result;
        if (_subject != null) _subject.Data = result;
    }
}