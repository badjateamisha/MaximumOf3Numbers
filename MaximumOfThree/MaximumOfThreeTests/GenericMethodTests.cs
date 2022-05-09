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
    public class GenericMethodTests
    {
        [TestMethod()]
        public void MaxusingGenericsTest()
        {
            int value = GenericMethod<int>.MaxusingGenerics<int>(4, 3, 2);
            Assert.AreEqual(4, value);
        }
        [TestMethod()]
        public void MaxusingGenericsTest1()
        {
            double value = GenericMethod<double>.MaxusingGenerics<double>(4.4, 5.5, 6.6);
            Assert.AreEqual(6.6, value);
        }
        [TestMethod()]
        public void MaxusingGenericsTest2()
        {
            string value = GenericMethod<string>.MaxusingGenerics<string>("Animal", "Banana", "Apple");
            Assert.AreEqual("Banana", value);
        }
    }
}
