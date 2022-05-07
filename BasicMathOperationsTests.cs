using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    [TestClass()]
    public class BasicMathOperationsTests
    {
        [TestMethod()]
        public void TestAdd()
        {
            // Assemble
            BasicMathOperations basicMathOperation = new BasicMathOperations();
            int expectedResult = 12;

            // Act
            int actualResult = basicMathOperation.Add(9, 3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void SubTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }
    }
}