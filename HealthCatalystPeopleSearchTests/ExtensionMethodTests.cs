using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthCatalystPeopleSearch;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace HealthCatalystPeopleSearchTests
{
    [TestClass]
    public class ExtensionMethodTests
    {
        private TestContext _testContext;

        public TestContext testcontext
        {
            get
            {
                return _testContext;
            }
            set
            {
                _testContext = value;
            }
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            string[] arr = { "string", "test", "pass", "wordswithoutspaces", "ok" };
            string passString = "pass";
            string failString = "fail";
            bool resultpass = ExtensionMethods.ContainsAny(passString, arr);
            Assert.AreEqual(resultpass, true);

            bool resultFail = ExtensionMethods.ContainsAny(failString, arr);
            Assert.AreEqual(resultpass, false);
        }

    }
}
