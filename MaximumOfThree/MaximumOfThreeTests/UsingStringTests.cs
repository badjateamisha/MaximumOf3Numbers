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
    public class UsingStringTests
    {
        [TestMethod()]
        public void MaximumstringTest()
        {
            UsingString usingstrings = new UsingString();
            string result = usingstrings.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", result);

        }
        [TestMethod()]
        public void MaximumstringTest2()
        {
            UsingString usingstrings1 = new UsingString();
            string result1 = usingstrings1.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", result1);
        }
        [TestMethod()]
        public void MaximumstringTest3()
        {
            UsingString usingstrings2 = new UsingString();
            string result2 = usingstrings2.MaxValueStrings("Apple", "Peach", "Banana");
            Assert.AreEqual("Banana", result2);
        }
    }
}