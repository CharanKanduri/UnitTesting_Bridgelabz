using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_UsingGenerics;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        GreatestNumber greatestNumber;

        [TestInitialize]
        public void SetUP()
        {
            greatestNumber = new GreatestNumber();
        }
        [TestMethod]
        public void LargestNumber_FirstNumber_IsGreater()
        {   //AAA rule

            //Arrange
            int first = 100, second = 30, third = 10, actualValue, expectedValue;
            expectedValue = first;
            //Act
            actualValue = greatestNumber.LargestNumber(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void LargestNumber_SecondNumber_IsGreater()
        {   //AAA rule

            //Arrange
            int first = 30, second = 100, third = 10, actualValue, expectedValue;
            expectedValue = second;
            //Act
            actualValue = greatestNumber.LargestNumber(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void LargestNumber_ThirdNumber_IsGreater()
        {   //AAA rule

            //Arrange
            int first = 30, second = 50, third = 100, actualValue, expectedValue;
            expectedValue = third;
            //Act
            actualValue = greatestNumber.LargestNumber(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
