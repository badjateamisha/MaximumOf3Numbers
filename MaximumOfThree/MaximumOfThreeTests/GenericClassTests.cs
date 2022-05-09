using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumOfThree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThree.Tests
{
    [TestClass()]
    public class GenericClassTests
    {
        [TestMethod()]
        public void MaxUsingGenericsTest()
        {
            int value = GenericClass.MaxusingGenerics<int>(4, 3, 2);
            Assert.AreEqual(4, value);
        }
        [TestMethod()]
        public void MaxUsingGenericsTest1()
        {
            double value = GenericClass.MaxusingGenerics<double>(4.4, 5.5, 6.6);
            Assert.AreEqual(6.6, value);
        }
        [TestMethod()]
        public void MaxUsingGenericsTest2()
        {
            string value = GenericClass.MaxusingGenerics<string>("Animal", "Banana", "Apple");
            Assert.AreEqual("Banana", value);
        }
    }
}