using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximumOfThree;


namespace MaximumOfThree.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void MaximumTest1()
        {
            UsingInt usingInt = new UsingInt();
            int result = usingInt.Maximum(6, 5, 4);
            Assert.AreEqual(6, result);

        }

        [TestMethod()]
        public void MaximumTest2()
        {
            UsingInt usingInt1 = new UsingInt();
            int result1 = usingInt1.Maximum(3, 7, 6);
            Assert.AreEqual(7, result1);
        }
        [TestMethod()]
        public void MaximumTest3()
        {
            UsingInt usingInt2 = new UsingInt();
            int result2 = usingInt2.Maximum(3, 7, 8);
            Assert.AreEqual(8, result2);
        }
    }
}