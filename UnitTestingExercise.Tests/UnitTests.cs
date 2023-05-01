using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 1, 896460, 896461)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -22, -5, -28)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:



            //Arrange
            // create a Calculator object

            var addTest = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = addTest.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]//Add test data <-------
        [InlineData(0, 55, -55)]
        [InlineData(1000, 999, 1)]
        [InlineData(-99, -1, -98)]
        [InlineData(3, -10, 13)]
        [InlineData(-3, 10, -13)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var subtractTest = new Calculator();

            //Act
            var actual = subtractTest.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 2, 12)]//Add test data <-------
        [InlineData(8, 0, 0)]
        [InlineData(1000, 2, 2000)]
        [InlineData(1, 2, 2)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var multiplyTest = new Calculator();
            //Act

           var actual = multiplyTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 2, 0)]//Add test data <-------
        [InlineData(6, 2, 3)]//Add test data <-------
        [InlineData(8, 0, 0)]
        [InlineData(1000, 2, 500)]
        [InlineData(1, 2, .5)]
        public void DivideTest(int num1, int num2, double expected)
        {
            //Arrange

            var divideTest = new Calculator();

            //Act
            var actual = divideTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
