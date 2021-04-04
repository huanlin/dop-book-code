using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch01.Ex02_AdheringPrinciple1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch01UnitTest
{
    [TestClass]
    public class NameCalculationTest
    {
        [TestMethod]
        public void TestFullName_UsingDynamicType()
        {
            dynamic obj = new ExpandoObject();
            obj.FirstName = "Bruce"; 
            obj.LastName = "Wayne";
            var actual = NameCalculation.FullName(obj);
            Assert.AreEqual("Bruce Wayne", actual);
        }

        [TestMethod]
        public void TestFullName_UsingExplicitType()
        {
            var obj = new CustomerData("Bruce", "Wayne", 100);
            var actual = NameCalculation.FullName(obj);
            Assert.AreEqual("Bruce Wayne", actual);
        }

    }
}
