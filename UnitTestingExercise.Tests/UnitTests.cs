using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(1, 5, 10, 16)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 0 )]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange

            var test1 = new UnitTestMethods();

            //Act

            var actualSub = test1.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actualSub);

        }

        [Theory]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            var test2 = new UnitTestMethods();

            //Act

            var actualmult = test2.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actualmult);

        }

        [Theory]
        [InlineData(2,2,1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            var test3 = new UnitTestMethods();

            //Act

            var actual = test3.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AreaCode()
        {
            //Arrange

            var expected = 512;


            //Act

            var actual = expected;

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void City()
        {
            //Arrange

            var city = "Austin";

            //Act

            var actual = city;

            //Assert

            Assert.Equal(city, actual);
        }
    }
}
