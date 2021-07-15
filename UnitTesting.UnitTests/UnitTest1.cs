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
        public void Int_LargestNumber_FirstNumber_IsGreater()
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
        public void Int_LargestNumber_SecondNumber_IsGreater()
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
        public void Int_LargestNumber_ThirdNumber_IsGreater()
        {   //AAA rule

            //Arrange
            int first = 30, second = 50, third = 100, actualValue, expectedValue;
            expectedValue = third;
            //Act
            actualValue = greatestNumber.LargestNumber(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        //Testing for Float values

        [TestMethod]
        public void Float_LargestNumber_FirstNumber_IsGreater_()
        {   //AAA rule

            //Arrange
            float first = 100.1F, second = 30.4F, third = 10.6F, actualValue, expectedValue;
            expectedValue = first;
            //Act
            actualValue = greatestNumber.LargestNumberFloat(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Float_LargestNumber_SecondNumber_IsGreater_()
        {   //AAA rule

            //Arrange
            float first = 89.1F, second = 100.1F, third = 10.6F, actualValue, expectedValue;
            expectedValue = second;
            //Act
            actualValue = greatestNumber.LargestNumberFloat(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Float_LargestNumber_ThirdNumber_IsGreater_()
        {   //AAA rule

            //Arrange
            float first = 89.1F, second = 70.1F, third = 100.6F, actualValue, expectedValue;
            expectedValue = third;
            //Act
            actualValue = greatestNumber.LargestNumberFloat(first, second, third);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        //Testing for String values
        [TestMethod]
        public void String_LargestNumber_FirstString_IsGreater()
        {
            string first = "Zoo", second = "Beach", third = "Park", expectedValue, actualValue;
            expectedValue = first;
            actualValue = greatestNumber.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void String_LargestNumber_SecondString_IsGreater()
        {
            string first = "Amusement", second = "Park", third = "Cinema", expectedValue, actualValue;
            expectedValue = second;
            actualValue = greatestNumber.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void String_LargestNumber_ThirdString_IsGreater()
        {
            string first = "Hiking", second = "Beach", third = "Park", expectedValue, actualValue;
            expectedValue = third;
            actualValue = greatestNumber.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
