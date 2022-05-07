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
        public void TestSub()
        {
            // Assemble
            BasicMathOperations basicMathOperation = new BasicMathOperations();
            int expectedResult = 6;

            // Act
            int actualResult = basicMathOperation.Sub(9, 3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestMultiply()
        {
            // Assemble
            BasicMathOperations basicMathOperation = new BasicMathOperations();
            int expectedResult = 27;

            // Act
            int actualResult = basicMathOperation.Multiply(9, 3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestDivide()
        {
            // Assemble
            BasicMathOperations basicMathOperation = new BasicMathOperations();
            int expectedResult = 3;

            // Act
            float actualResult = basicMathOperation.Divide(9, 3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
  
}