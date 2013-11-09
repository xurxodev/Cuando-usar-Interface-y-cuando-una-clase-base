using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceAndBaseClassExample.V2.ShareClient;
using InterfaceAndBaseClassExample.V2;
using System.Collections.Generic;

namespace InterfaceAndBaseClassExampleTest
{

    public class TestTwitterClient:IShareClient
    {
        public void Share(string message)
        {
            throw new Exception("Invalid or expired token");
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                TestTwitterClient fakeclient = new TestTwitterClient();

                BlogService blog = new BlogService(new List<IShareClient>() { fakeclient });

                blog.PublishPost("test");

                Assert.IsTrue(true);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
    }
}
