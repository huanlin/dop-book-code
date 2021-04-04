using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch01.Ex01_BreakingPrinciple1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch01UnitTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestCustomerFullName()
        {
            var customer = new Customer("Bruce", "Wayne", 100);
            Assert.AreEqual("Bruce Wayne", customer.FullName);
        }
    }
}
