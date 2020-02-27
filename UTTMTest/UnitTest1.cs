using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTTM;

namespace UTTMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cls = new FizzBuzz("Sanu");
            Assert.AreEqual("Sanu", "Sanu");
        }
    }
}
