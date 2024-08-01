using System;
using System.Runtime.InteropServices;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
           var actual = calculator.AddNums(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(12, 13, -1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 5, 20)]//Add test data <-------
        [InlineData(6, 6, 36)]
        [InlineData(0, 5, 0)]
        [InlineData(-1, 5, -5)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(5, 5, 1)]
        [InlineData(10, 4, 2.5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
