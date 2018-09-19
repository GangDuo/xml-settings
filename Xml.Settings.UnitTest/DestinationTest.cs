using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xml.Settings.UnitTest
{
    [TestClass]
    public class DestinationTest
    {
        [TestMethod]
        public void TestLoad()
        {
            string[] actual = new string[] { "p1@example.co.jp", "p2@example.co.jp" };
            CollectionAssert.AreEqual(Destination.Load(@"..\..\data\destinations.xml"), actual);
        }
    }
}
