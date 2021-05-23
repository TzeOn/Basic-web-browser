using Microsoft.VisualStudio.TestTools.UnitTesting;
using browserv2;
using System;
using System.Reflection;

namespace BrowserTests
{
    [TestClass]
    public class BrowserTestClass
    {
        [TestMethod]
        public void testHomeLoad()
        {
            string homeFile = "../../Resources/homeTest.csv";
            string url= home.getHome();
            string expected = "http://google.com";

            StringAssert.Equals(expected, url);           
        }
    }
}
