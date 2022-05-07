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
    public class CommonProgramsTests
    {
       

        [TestMethod]
        public void TestIsEvenNumber()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = true;

            // Act
            bool actualResult = commonPrograms.IsEvenNumber(18);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsNotEvenNumber()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = false;

            // Act
            bool actualResult = commonPrograms.IsEvenNumber(17);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsOddNumber()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = true;

            // Act
            bool actualResult = commonPrograms.IsOddNumber(113);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsNotOddNumber()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = false;

            // Act
            bool actualResult = commonPrograms.IsOddNumber(12);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestIsPrime()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = true;

            // Act
            bool actualResult = commonPrograms.IsPrime(23);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestIsPrimeWithZero()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = true;

            // Act
            bool actualResult = commonPrograms.IsPrime(0);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestIsPrimeWithOne()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
             bool expectedResult = true;

            // Act
            bool actualResult = commonPrograms.IsPrime(1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestIsNotPrime()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = false;

            // Act
            bool actualResult = commonPrograms.IsPrime(24);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void TestIsNotPrimeWithNegativeNumber()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            bool expectedResult = false;

            // Act
            bool actualResult = commonPrograms.IsPrime(-13);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSmallest()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            int[] array = new int[] { 4, 12, 15, 20, 3, 22};
            int expectedResult = 3;

            // Act
            int actualResult = commonPrograms.Smallest(array);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSmallestWrongValue()
        {
            // Assemble
            CommonPrograms commonPrograms = new CommonPrograms();
            int[] array = new int[] { 4, 12, 15, 20, 3, 22 };
            int expectedResult = 4;

            // Act
            int actualResult = commonPrograms.Smallest(array);

            // Assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }
    }
}  