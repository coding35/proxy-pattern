using System;
using NUnit.Framework;
using RemoteProxy;
using RemoteProxy = RemoteProxy.RemoteProxy;

namespace RemoteProxyTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var client = new RemoteProxyClient();
        
        Subject? subject = new Subject();
        
        //a request tht does not use the proxy
        client.ClientCode(subject);
        Console.WriteLine(subject.GetData());
        
        //a request that uses the proxy
        var remoteProxy = new global::RemoteProxy.RemoteProxy(subject);
        client.ClientCode(remoteProxy);
        Console.WriteLine(subject.GetData());
    }
}