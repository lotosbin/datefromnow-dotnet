using System;
using datefromnow_dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace datefromnow_dotnet_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var now = DateTime.Now;
            var timeSpan = now - now.AddSeconds(-10);
            var s = timeSpan.ToDateStringFromNow();
            Assert.AreEqual("10秒前", s);
        }
    }
}
