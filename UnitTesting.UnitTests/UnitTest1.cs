using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_UsingGenerics;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        GreatestNumber greatestNumber;
        GenericClassForGreaterValue genericGreaterValue;
        GenericClassModified<string> modifiedGenericStringObject;

        [TestInitialize]
        public void SetUP()
        {
            greatestNumber = new GreatestNumber();
            genericGreaterValue = new GenericClassForGreaterValue();
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


        //Testing for Generic-CLass

       
        [TestMethod]
        public void Generics_Int_LargestNumber_FirstNumber_IsGreater()
        {
            int first = 100, second = 38, third = 10, actualValue, expectedValue;
            expectedValue = first;
            actualValue = genericGreaterValue.GenericMethodForGreatest<int>(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Generics_Float_LargestNumber_Second_IsGreater()
        {
            float first = 10.1F, second = 300.4F, third = 10.6F, expectedValue, actualValue;
            expectedValue = second;
            actualValue = genericGreaterValue.GenericMethodForGreatest<float>(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Generics_String_LargestValue_Second_IsGreater()
        {
            string first = "Amusement", second = "Park", third = "Cinema", expectedValue, actualValue;
            expectedValue = second;
            actualValue = genericGreaterValue.GenericMethodForGreatest<string>(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }




        [TestMethod]
        public void ModifiedGenerics_String_LargestValue_Second_IsGreater()
        {
            string first = "Hiking", second = "Beach", third = "Park", expectedValue, actualValue;
            //Refactoring using generics
            modifiedGenericStringObject = new GenericClassModified<string>(first, second, third);
            actualValue = modifiedGenericStringObject.FindMaxNumber();
            expectedValue = third;
            Assert.AreEqual(expectedValue, actualValue);
        }


        //USECASE 4
        [TestMethod]
        public void UseCase4_1()
        {
            GenericClassExtended<int> obj3;
            int expectedValue;
            int[] arrayList = { 1, 44, 6, 34, 97, 103, 2, 777 };
            obj3 = new GenericClassExtended<int>(arrayList);
            expectedValue = 777;
            int actualValue = obj3.MaximumValueFunction(arrayList);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase4_2()
        {
            GenericClassExtended<float> obj3;
            float expectedValue;
            float[] arrayList = { 1, 44.3F, 6, 34, 97, 103, 2, 777.8F };
            obj3 = new GenericClassExtended<float>(arrayList);
            expectedValue = 777.8F;
            float actualValue = obj3.MaximumValueFunction(arrayList);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void UseCase4_3()
        {
            GenericClassExtended<string> obj3;
            string expectedValue;
            string[] arrayList = { "Apple", "Mango", "Grapes" };
            obj3 = new GenericClassExtended<string>(arrayList);
            expectedValue = "Mango";
            string actualValue = obj3.MaximumValueFunction(arrayList);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
