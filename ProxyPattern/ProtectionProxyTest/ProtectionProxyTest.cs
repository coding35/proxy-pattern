using NUnit.Framework;
using ProtectionProxy;

namespace Test;

public class ProtectionProxyTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var client = new Client();
        
        Subject subject = new Subject();
        
        //a request tht does not use the proxy
        var result1 = client.ClientCode(subject);
        
        var protectionProxy = new ProtectionProxy.ProtectionProxy(subject);
        
        //a request that uses the proxy
        var result2 = client.ClientCode(protectionProxy);

        Assert.IsTrue(result1);
        Assert.IsFalse(result2);
    }
}