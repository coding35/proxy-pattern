using System.Threading;
using NUnit.Framework;
using VirtualProxy;

namespace VirtualProxyTest;

public class VirtualProxyTest
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// We can see that the proxy is used to delay the creation of the subject until it is needed and provides
    /// a stand-in for the real data until it is available.
    /// In this scenario, the virtual proxy also creates the subject.
    /// </summary>
    [Test]
    public void Test1()
    {
        var client = new Client();
        var subject = new global::VirtualProxy.VirtualProxy();
        //a request that uses the proxy
        client.ClientCode(subject);
        Assert.AreEqual(new[] { (byte)'a', (byte)'b', (byte)'c'}, subject.GetData());
        Thread.Sleep(2000);
        Assert.AreEqual(new[] { (byte)'x', (byte)'y', (byte)'z'}, subject.GetData());
        
    }
}